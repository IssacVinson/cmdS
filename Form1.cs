using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testingCmdS;
{
    public partial class testingCmds : Form
    {
       
        int Num1;
        int Num2;
        string operation;
        int Ans;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtVal1_TextChanged(object sender, EventArgs e)
        {
            Num1 = Console.ReadLine(txtVal1);
        }

        private void txtVal2_TextChanged(object sender, EventArgs e)
        {
            Num2 = Console.ReadLine(txtVal2);
        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Ans = Num1+Num2;
            lblAns.Text = Num1 + "+" + Num2 + "=" + Ans;
        }
        private void cmdSub_Click(object sender, EventArgs e)
        {
            Ans = Num1-Num2;
            lblAns.Text = Num1 + "-" + Num2 + "=" + Ans;
        }
        private void cmdMultipy_Click(object sender, EventArgs e)
        {
            Ans = Num1*Num2;
            lblAns.Text = Num1 + "*" + Num2 + "=" + Ans;
        }

        private void cmdDiv_Click(object sender, EventArgs e)
        {
            Ans = Num1/Num2;
            lblAns.Text = Num1 + "/" + Num2 + "=" + Ans;
        }
    }
}
