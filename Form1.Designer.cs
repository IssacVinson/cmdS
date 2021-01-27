
using System;

namespace testingCmdS
{
    partial class testingCmds
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdSub = new System.Windows.Forms.Button();
            this.cmdMultipy = new System.Windows.Forms.Button();
            this.cmdDiv = new System.Windows.Forms.Button();
            this.cmdClr = new System.Windows.Forms.Button();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(827, 384);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(116, 48);
            this.cmdAdd.TabIndex = 0;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdSub
            // 
            this.cmdSub.Location = new System.Drawing.Point(827, 457);
            this.cmdSub.Name = "cmdSub";
            this.cmdSub.Size = new System.Drawing.Size(116, 49);
            this.cmdSub.TabIndex = 1;
            this.cmdSub.Text = "Subtract";
            this.cmdSub.UseVisualStyleBackColor = true;
            this.cmdSub.Click += new System.EventHandler(this.cmdSub_Click);
            // 
            // cmdMultipy
            // 
            this.cmdMultipy.Location = new System.Drawing.Point(827, 530);
            this.cmdMultipy.Name = "cmdMultipy";
            this.cmdMultipy.Size = new System.Drawing.Size(116, 40);
            this.cmdMultipy.TabIndex = 2;
            this.cmdMultipy.Text = "Multiply";
            this.cmdMultipy.UseVisualStyleBackColor = true;
            this.cmdMultipy.Click += new System.EventHandler(this.cmdMultipy_Click);
            // 
            // cmdDiv
            // 
            this.cmdDiv.Location = new System.Drawing.Point(827, 593);
            this.cmdDiv.Name = "cmdDiv";
            this.cmdDiv.Size = new System.Drawing.Size(116, 46);
            this.cmdDiv.TabIndex = 3;
            this.cmdDiv.Text = "Divide";
            this.cmdDiv.UseVisualStyleBackColor = true;
            this.cmdDiv.Click += new System.EventHandler(this.cmdDiv_Click);
            // 
            // cmdClr
            // 
            this.cmdClr.Location = new System.Drawing.Point(776, 662);
            this.cmdClr.Name = "cmdClr";
            this.cmdClr.Size = new System.Drawing.Size(167, 66);
            this.cmdClr.TabIndex = 4;
            this.cmdClr.Text = "Clear";
            this.cmdClr.UseVisualStyleBackColor = true;
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(324, 384);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 31);
            this.txtVal1.TabIndex = 5;
            this.txtVal1.TextChanged += new System.EventHandler(this.txtVal1_TextChanged);
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(561, 384);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(100, 31);
            this.txtVal2.TabIndex = 6;
            this.txtVal2.TextChanged += new System.EventHandler(this.txtVal2_TextChanged);
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Location = new System.Drawing.Point(319, 316);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(85, 25);
            this.lblVal1.TabIndex = 7;
            this.lblVal1.Text = "Value 1";
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Location = new System.Drawing.Point(572, 315);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(85, 25);
            this.lblVal2.TabIndex = 8;
            this.lblVal2.Text = "Value 2";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(435, 498);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(83, 25);
            this.lblAns.TabIndex = 9;
            this.lblAns.Text = "Answer";
            this.lblAns.Click += new System.EventHandler(this.label1_Click);
            // 
            // testingCmds
            // 
            this.ClientSize = new System.Drawing.Size(1327, 1068);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblVal2);
            this.Controls.Add(this.lblVal1);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.cmdClr);
            this.Controls.Add(this.cmdDiv);
            this.Controls.Add(this.cmdMultipy);
            this.Controls.Add(this.cmdSub);
            this.Controls.Add(this.cmdAdd);
            this.Name = "testingCmds";
            this.Load += new System.EventHandler(this.testingCmds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void testingCmds_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdSub;
        private System.Windows.Forms.Button cmdMultipy;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.Button cmdClr;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblAns;
    }
}

