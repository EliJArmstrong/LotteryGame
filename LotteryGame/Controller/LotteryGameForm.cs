// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>LotteryGameForm.cs</file>
// <date>2018-11-09</date>
// <summary>This Is the code for the UI for the lottery game.</summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 4 hours. </remarks>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;


// ----------------------------------------------------------------------------
// The Name Space for LotteryGame.
// ----------------------------------------------------------------------------
namespace LotteryGame
{
    /// -----------------------------------------------------------------------
    /// <summary>The LotteryGameForm partial class with base of Form.</summary>
    /// -----------------------------------------------------------------------
    public partial class LotteryGameForm : Form
    {
        // Creates a object to stores private fonts.
        PrivateFontCollection privateFont = new PrivateFontCollection();

        // Holds a array of the winning numbers.
        int[] lotteryNumbers = new int[5];

        // Holds the user selected numbers.
        int[] userNumbers = { 1, 2, 3, 4, 5 };

        /// -------------------------------------------------------------------
        /// <summary>Constructor</summary>
        /// -------------------------------------------------------------------
        public LotteryGameForm()
        {
            InitializeComponent();
            fillArrays();
            CheckFont();
        }
        
        /// -------------------------------------------------------------------
        /// <summary>
        /// This checks if the font used for the GUI is installed in 
        /// the system.
        /// </summary>
        /// -------------------------------------------------------------------
        private void CheckFont()
        {
            // Holds an array for installed fonts.
            var fontsCollection = new InstalledFontCollection();
            // Holds a bool that will be true if the font is true. Else false. 
            bool found = false;

            foreach (var fontFamiliy in fontsCollection.Families)
            {
                if (fontFamiliy.Name == "Mistral")
                {
                    found = true;
                }
            }

            // if the font is not found the font is added and set to correct 
            // labels.
            if (!found)
            {
                AddCutomFont();
                SetFontForLabels(this);
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// Sets the GUI's desired font for all labels with a tag of 100
        /// </summary>
        /// <param name="control">All the controls of the GUI.</param>
        /// -------------------------------------------------------------------
        private void SetFontForLabels(Control control)
        {
            if (control is Label)
            {
                // label to be casted and font changed to desired font.
                Label label = control as Label;

                if(label.Tag != null && label.Tag.Equals(100))
                {
                    label.Font = new Font(privateFont.Families[0], label.Font.Size);
                }  
            }
            else
            {
                foreach (Control child in control.Controls)
                {
                    SetFontForLabels(child);
                }

            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// Adds the font to private fronts from the resources folder.  
        /// </summary>
        /// -------------------------------------------------------------------
        private void AddCutomFont()
        {
            privateFont.AddFontFile("../../Resources/Mistral.TTF");
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method gets called when the value of a NUmericUpDown 
        /// (Yep thats what its called) is called. This method will call other
        /// methods to make sure that all the users numbers are distinct. If 
        /// they are not the play button will be grayed out and will not be 
        /// able to be interacted with. 
        /// </summary>
        /// <param name="sender">The caller of the method.</param>
        /// <param name="e">The event choices that are offered.</param>
        /// -------------------------------------------------------------------
        private void UserNumber_ValueChanged(object sender, EventArgs e)
        {
            // The sender casted to a NumericUpDown 
            var upDown = sender as NumericUpDown;
            userNumbers[(int)upDown.Tag] = (int)upDown.Value;
            RedundancyCheck();
            if (!Distinct())
            {
                PlayBtn.Enabled = false;
                PlayBtn.BackColor = Color.Gray;
            }
            else
            {
                PlayBtn.Enabled = true;
                PlayBtn.BackColor = Color.Crimson;
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This checks if any of the numbers are unique if not a label 
        /// will show under the numbers that are the same.
        /// </summary>
        /// -------------------------------------------------------------------
        private void RedundancyCheck()
        {
            // Ends the for loop if same number is found
            bool NotRedundent = true; 

            for (int i = 0; i < userNumbers.Length; i++)
            {
                NotRedundent = true;
                for (int j = 0; j < userNumbers.Length && NotRedundent; j++)
                {
                    if (i != j)
                    {
                        if(userNumbers[i] == userNumbers[j])
                        {
                            errorLbls[i].Visible = true;
                            NotRedundent = false;
                        }
                        else
                        {
                            errorLbls[i].Visible = false;
                        }
                    }
                }
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method gets called when the button thats texts is set to "I'm 
        /// feeling lucky" is click. When clicked the numbers in the users 
        /// boxes are set with random numbers that are unique. The userNumber 
        /// array is set with the same numbers. 
        /// </summary>
        /// <param name="sender">The caller of the method.</param>
        /// <param name="e">The event choices that are offered.</param>
        /// -------------------------------------------------------------------
        private void NumberPickerBtn_Click(object sender, EventArgs e)
        {
            FillArrayRandom(userNumbers);
            for (int i = 0; i < userNumbers.Length; i++)
            {
                upAndDowns[i].Value = userNumbers[i];
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// Fills the passed int array with unique random numbers.
        /// </summary>
        /// <param name="array">the array to be filled.</param>
        /// -------------------------------------------------------------------
        private void FillArrayRandom(int [] array)
        {
            var random = new Random();  // random number generator class.
            // A list to make sure a number has not been chosen more than once. 
            var list = new List<int>(); 

            for (int i = 0; i < array.Length; i++)
            {
                var number = random.Next(1, 41); // Holds the random number.
                while (list.Contains(number))
                {
                    number = random.Next(1, 41);
                }
                list.Add(number);
                array[i] = number;
            }

        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// Is called when the play button is clicked. When the button test 
        /// displays "Play" then the lottery numbers a chosen and the UI 
        /// elements are shown. If the button displays play again the UI is 
        /// reset and the button displayed at "Play" once again. 
        /// </summary>
        /// <param name="sender">The caller of the method.</param>
        /// <param name="e">The event choices that are offered.</param>
        /// -------------------------------------------------------------------
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (PlayBtn.Text.Equals("Play"))
            {
                PlayBtn.Text = "Play Again";
                FillArrayRandom(lotteryNumbers);
                SelectionSort(lotteryNumbers);
                SetWinningLabels();
                DisableUI();
                ShowLotteryNumbers();
                InfoLbl.Visible = false;
                SetWinOrLoseLbl(Win());
                WinLoseLbl.Visible = true;
            }
            else
            {
                PlayBtn.Text = "Play";
                EnabledUI();
                HideLotterNumbers();
                InfoLbl.Visible = true;
                WinLoseLbl.Visible = false;
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// The method set the label that tells the user that he/she won or 
        /// lost. If the passed bool is true the label will be set to 
        /// "You Win!". else the label is set to "You Lose!". The position for
        /// the label to set to the middle of the form after being set.
        /// </summary>
        /// <param name="win">
        /// The bool to be passed if with is true the label will be set to
        /// "You Win!" else it will be set to "You Lose!".
        /// </param>
        /// -------------------------------------------------------------------
        private void SetWinOrLoseLbl(bool win) {
            if (win)
            {
                WinLoseLbl.Text = "You Win!";
            }
            else
            {
                WinLoseLbl.Text = "You Lose!";
            }

            WinLoseLbl.Location = new Point(this.Width/2 - WinLoseLbl.Width/2, WinLoseLbl.Location.Y);
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method returns true if the users numbers match the lottery 
        /// numbers else false.
        /// </summary>
        /// <returns>A bool that if the users numbers match the lottery 
        /// numbers is set to true else false..</returns>
        /// -------------------------------------------------------------------
        private bool Win()
        {
            // The bool to be returned.
            bool win = true;
            for (int i = 0; i < userNumbers.Length && win; i++)
            {
                if (!lotteryNumbers.Contains(userNumbers[i]))
                {
                    win = false;
                }
            }
            return win;
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This is a method to sort int arrays using the SelectionSort from 
        /// the book. It sorts the array from least to greatest.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        /// -------------------------------------------------------------------
        private void SelectionSort(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var smallest = i; // The index for the smallest number.
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                Swap(ref array[i], ref array[smallest]);
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// Swaps two ints memory locations.
        /// </summary>
        /// <param name="first">The first int to be swapped.</param>
        /// <param name="second">The second int to be swapped.</param>
        /// -------------------------------------------------------------------
        private void Swap(ref int first, ref int second)
        {
            var temp = first; // Holds the value of the first number. 
            first = second;
            second = temp;
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// Shows the lottery number labels and banners of the numbers.
        /// </summary>
        /// -------------------------------------------------------------------
        private void ShowLotteryNumbers()
        {
            leftPanel.Visible = true;
            rightPanel.Visible = true;
            lotteryLbl1.Visible = true;
            lotteryLbl2.Visible = true;
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// Hides the lottery number labels and banners of the numbers.
        /// </summary>
        /// -------------------------------------------------------------------
        private void HideLotterNumbers()
        {
            leftPanel.Visible = false;
            rightPanel.Visible = false;
            lotteryLbl1.Visible = false;
            lotteryLbl2.Visible = false;
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method sets the lottery numbers to the lottery number labels.
        /// </summary>
        /// -------------------------------------------------------------------
        private void SetWinningLabels()
        {
            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                lotteryNumberLbls[i].Text = lotteryNumbers[i].ToString();
                lotteryNumberLbls[i + 5].Text = lotteryNumbers[i].ToString();
            }
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// Disables the UI that is interact-able besides for the play button.
        /// </summary>
        /// ------------------------------------------------------------------=
        private void DisableUI()
        {
            for (int i = 0; i < upAndDowns.Count; i++)
            {
                upAndDowns[i].Enabled = false;
            }
            numberPickerBtn.Enabled = false;
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// Enables the UI that is interact-able.
        /// </summary>
        /// ------------------------------------------------------------------=
        private void EnabledUI()
        {
            for (int i = 0; i < upAndDowns.Count; i++)
            {
                upAndDowns[i].Enabled = true;
            }
            numberPickerBtn.Enabled = true;
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// Returns true if the user chosen numbers are all unique. Else false.
        /// </summary>
        /// -------------------------------------------------------------------
        private bool Distinct()
        {
            // Holds the value if all the user numbers are unique.
            bool distinct = true; 

            for (int i = 0; i < errorLbls.Count && distinct; i++)
            {
                distinct = !errorLbls[i].Visible;
            }

            return distinct;
        }

    }
}
