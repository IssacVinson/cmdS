using System;
using System.IO;
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

        private void label1_Click(object sender, EventArgs e)
        { }

        private void txtVal1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVal2_TextChanged(object sender, EventArgs e)
        {

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
                    txtVal1.Text = "" + Ans;
                    txtVal2.Text = "";
                    txtVal2.Select();
                }
                else if (operationType == "subtract")
                {
                    Ans = Num1 - Num2;
                    lblAns.Text = Num1 + "-" + Num2 + "=" + Ans;
                    txtVal1.Text = "" + Ans;
                    txtVal2.Text = "";
                    txtVal2.Select();
                }
                else if (operationType == "multiply")
                {
                    Ans = Num1 * Num2;
                    lblAns.Text = Num1 + "*" + Num2 + "=" + Ans;
                    txtVal1.Text = "" + Ans;
                    txtVal2.Text = "";
                    txtVal2.Select();
                }
                else if (operationType == "divide")
                {
                    Ans = Num1 / Num2;
                    lblAns.Text = Num1 + "/" + Num2 + "=" + Ans;
                    txtVal1.Text = "" + Ans;
                    txtVal2.Text = "";
                    txtVal2.Select();
                }

            }
            else
            {
                lblAns.Text = "You need to enter numbers!";

            }
        }

        private void cmdClr_Click(object sender, EventArgs e)
        {
            txtVal1.Text = "";
            txtVal2.Text = "";
            lblAns.Text = "";
            txtVal1.Select();
        }
        private void WriteWindowDimensions()
        {
            // Store the path of the textfile in your system

            string file = AppDomain.CurrentDomain.BaseDirectory + "AppSettings.txt";



            // To write all of the text to the file

            string text = "MainFormHeight=" + this.Height + "\r\n";
            text = text + "MainFormWidth=" + this.Width;

            File.WriteAllText(file, text);



        }


        private void testingCmds_ResizeEnd_1(object sender, EventArgs e)
        {
            WriteWindowDimensions();

        }
        void SetComponents()
        {
            int formHeight = this.Height;
            int formWidth = this.Width;
            int vertGap = this.Height / 100;
            int horGap = this.Width / 100;

            // set height, width, top, left of cmdAdd
            cmdAdd.Left = formWidth / 12;
            cmdAdd.Top = formHeight / 10;
            cmdAdd.Width = formWidth / 8;
            cmdAdd.Height = formHeight / 8;
             

            // set height, width, top, left of cmdSub
            cmdSub.Left = formWidth / 12;
            cmdSub.Top = formHeight / 8 + vertGap * 15;
            cmdSub.Width = formWidth / 8; 
            cmdSub.Height = formHeight / 8;

            // set height, width, top, left of cmdMultiply
            cmdMultipy.Left = formWidth / 12;
            cmdMultipy.Top = formHeight / 8 + vertGap * 33;
            cmdMultipy.Width = formWidth / 8;
            cmdMultipy.Height = formHeight / 8;

            // set height, width, top, left of cmdDiv
            cmdDiv.Left = formWidth / 12;
            cmdDiv.Top = formHeight / 8 + vertGap * 51;
            cmdDiv.Width = formWidth / 8;
            cmdDiv.Height = formHeight / 8;

            // set height, width, top, left of cmdClr
            cmdClr.Left = formWidth / 12;
            cmdClr.Top = formHeight / 8 + vertGap * 70;
            cmdClr.Width = formWidth / 8;
            cmdClr.Height = formHeight / 8;

            // set height, width, top, left of txtVal1
            txtVal1.Left = formWidth / 4 + horGap * 12;
            txtVal1.Top = formHeight / 2 - vertGap * 25;
            txtVal1.Width = formWidth / 8;
            txtVal1.Height = formHeight / 8;

            // set height, width, top, left of txtVal2
            txtVal2.Left = formWidth / 4 + horGap * 45;
            txtVal2.Top = formHeight / 2 - vertGap * 25;
            txtVal2.Width = formWidth / 8;
            txtVal2.Height = formHeight / 8;

            // set height, width, top, left of lblAns
            lblAns.Left = formWidth / 2;
            lblAns.Top = formHeight / 2;
            lblAns.Width = formWidth / 8;
            lblAns.Height = formHeight / 8;

            // set height, width, top, left of lblVal1
            lblVal1.Left = formWidth / 4 + horGap * 12;
            lblVal1.Top = formHeight / 2 - vertGap * 30;
            lblVal1.Width = formWidth / 8;
            lblVal1.Height = formHeight / 8;

            // set height, width, top, left of lblVal2
            lblVal2.Left = formWidth / 4 + horGap * 45;
            lblVal2.Top = formHeight / 2 - vertGap * 30;
            lblVal2.Width = formWidth / 8;
            lblVal2.Height = formHeight / 8;
        }
        private void testingCmds_Resize_1(object sender, EventArgs e)
        {
 
            SetComponents();

        }

        private void testingCmds_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "AppSettings.txt"))
            {
                string line = "";


                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("MainFormWidth="))
                    {
                        string[] chunks = line.Split('=');
                        int width = this.Width;
                        if (Int32.TryParse(chunks[1], out width))
                        {
                            this.Width = width;

                        }
                    }
                    else if (line.StartsWith("MainFormHeight="))
                    {
                        string[] chunks = line.Split('=');
                        int height = this.Height;
                        if (Int32.TryParse(chunks[1], out height))
                        {
                            this.Height = height;
                        }
                    }
                }
            }
        }
    }
}

