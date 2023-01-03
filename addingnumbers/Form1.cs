using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int TurnIntoInt(string inputstring, int biggerthen = 0)
        {
            int inputnum;
            if (int.TryParse(inputstring, out inputnum) && inputnum > biggerthen) { return inputnum; }
            else if (!int.TryParse(inputstring, out inputnum) && inputstring == "") { return biggerthen; }
            else { return biggerthen - 1; }
        }

        private void inputTB_TextChanged(object sender, EventArgs e)
        {
            string[] numbersinstring = inputTB.Text.Split(',');
            int sumofnumbers = 0;
            foreach (string number in numbersinstring)
            {
                int tempnumber = TurnIntoInt(number);
                if (tempnumber > 0) { sumofnumbers += tempnumber; }
            }
            outputLB.Text = $"The sum was:\n{sumofnumbers}";
        }
    }
}
