using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryGame
{
    public partial class LotteryGameForm : Form
    {

        PrivateFontCollection privateFont = new PrivateFontCollection();

        // Holds a list of the winning numbers.
        List<int> lotteryNumbers = new List<int>();
        // Holds the user selected numbers.
        int[] userNumbers = new int[5];

        public LotteryGameForm()
        {
            InitializeComponent();
            fillArrays();
            CheckFont();
        }

        private void CheckFont()
        {
            var fontsCollection = new InstalledFontCollection();
            bool found = false;
            foreach (var fontFamiliy in fontsCollection.Families)
            {
                if (fontFamiliy.Name == "Mistral")
                {
                    found = true;
                }
            }

            if (!found)
            {
                AddCutomFont();
                SetFontForLabels(this);
            }
        }

        private void SetFontForLabels(Control control)
        {
            if (control is Label)
            {
                // label to be casted and added to keyAndLabel.
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

        private void AddCutomFont()
        {
            privateFont.AddFontFile("../../Resources/Mistral.TTF");
        }

    }
}
