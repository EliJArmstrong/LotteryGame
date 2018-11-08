using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryGame
{
    public partial class LotteryGameForm : Form
    {
        // Holds a list of the winning numbers.
        List<int> lotteryNumbers = new List<int>();
        // Holds the user selected numbers.
        int[] userNumbers = new int[5];

        public LotteryGameForm()
        {
            InitializeComponent();
            fillArrays();
        }
    }
}
