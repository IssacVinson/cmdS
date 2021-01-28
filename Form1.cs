using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmdS
{
    public partial class testingCmds : Form
{

    float Num1;
        float Num2;
        float Ans;

        public testingCmds()
        {
            InitializeComponent();
        }
        private void testingCmds_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {}

        private void txtVal1_TextChanged(object sender, EventArgs e)
        {
            //Num1 = Convert.ToInt32(txtVal1.Text);
            //TryParse
        }

        private void txtVal2_TextChanged(object sender, EventArgs e)
        {
            //Num2 = Convert.ToInt32(Console.ReadLine());
        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            DoOperation(Num1, Num2, "add");
        }
        private void cmdSub_Click(object sender, EventArgs e)
        {
            DoOperation(Num1, Num2, "subtract");
        }
    
        private void cmdMultipy_Click(object sender, EventArgs e)
        {
            DoOperation(Num1, Num2, "multiply");
        }

        private void cmdDiv_Click(object sender, EventArgs e)
        {
            DoOperation(Num1, Num2, "divide");
        }

        private void DoOperation(float val1, float val2, string operationType)
        {
            bool success = false;
            // assign Num1 and Num2 here
            success = float.TryParse(txtVal1.Text, out Num1) && float.TryParse(txtVal2.Text, out Num2);

            if (success)
            {
                if (operationType == "add")
                {
                    Ans = Num1 + Num2;
                    lblAns.Text = Num1 + "+" + Num2 + "=" + Ans;
                    //txtVal1.Text = Ans;
                    txtVal2.Select();
                }
                else if (operationType == "subtract")
                {
                    Ans = Num1 - Num2;
                    lblAns.Text = Num1 + "-" + Num2 + "=" + Ans;
                    //txtVal1.Text = Ans;
                    txtVal2.Select();
                }
                else if (operationType == "multiply")
                {
                    Ans = Num1 * Num2;
                    lblAns.Text = Num1 + "*" + Num2 + "=" + Ans;
                    //txtVal1.Text = Ans;
                    txtVal2.Select();
                }
                else if (operationType == "divide")
                {
                    Ans = Num1 / Num2;
                    lblAns.Text = Num1 + "/" + Num2 + "=" + Ans;
                    //txtVal1.Text = Ans;
                    txtVal2.Select();
                }
            
            }
            else
            {
                lblAns.Text = "You need to only enter numbers!";

            }
        }

    private void cmdClr_Click(object sender, EventArgs e)
    {
        txtVal1.Text = "";
        txtVal2.Text = "";
        lblAns.Text = "";
            txtVal1.Select();
    }
}
}
