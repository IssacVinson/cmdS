
namespace cmdS
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
            this.lblCare = new System.Windows.Forms.Label();
            this.txtCare = new System.Windows.Forms.TextBox();
            this.lblComfort = new System.Windows.Forms.Label();
            this.txtComfort = new System.Windows.Forms.TextBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.lblPositive = new System.Windows.Forms.Label();
            this.txtPositive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCare
            // 
            this.lblCare.AutoSize = true;
            this.lblCare.Location = new System.Drawing.Point(72, 65);
            this.lblCare.Name = "lblCare";
            this.lblCare.Size = new System.Drawing.Size(425, 25);
            this.lblCare.TabIndex = 0;
            this.lblCare.Text = "How was your provider\'s patient care? 1-10";
            // 
            // txtCare
            // 
            this.txtCare.Location = new System.Drawing.Point(77, 113);
            this.txtCare.Name = "txtCare";
            this.txtCare.Size = new System.Drawing.Size(272, 31);
            this.txtCare.TabIndex = 1;
            this.txtCare.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblComfort
            // 
            this.lblComfort.AutoSize = true;
            this.lblComfort.Location = new System.Drawing.Point(72, 181);
            this.lblComfort.Name = "lblComfort";
            this.lblComfort.Size = new System.Drawing.Size(641, 25);
            this.lblComfort.TabIndex = 2;
            this.lblComfort.Text = "Do you feel your provider established a comfortable environment?";
            this.lblComfort.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtComfort
            // 
            this.txtComfort.Location = new System.Drawing.Point(77, 249);
            this.txtComfort.Name = "txtComfort";
            this.txtComfort.Size = new System.Drawing.Size(272, 31);
            this.txtComfort.TabIndex = 3;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(77, 340);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(436, 25);
            this.lblFood.TabIndex = 4;
            this.lblFood.Text = "How can we improve the quality of our food?";
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(82, 412);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(267, 31);
            this.txtFood.TabIndex = 5;
            // 
            // lblPositive
            // 
            this.lblPositive.AutoSize = true;
            this.lblPositive.Location = new System.Drawing.Point(82, 493);
            this.lblPositive.Name = "lblPositive";
            this.lblPositive.Size = new System.Drawing.Size(479, 25);
            this.lblPositive.TabIndex = 6;
            this.lblPositive.Text = "What is one positve experience provided to you?";
            this.lblPositive.Click += new System.EventHandler(this.lblPositive_Click);
            // 
            // txtPositive
            // 
            this.txtPositive.Location = new System.Drawing.Point(82, 565);
            this.txtPositive.Name = "txtPositive";
            this.txtPositive.Size = new System.Drawing.Size(267, 31);
            this.txtPositive.TabIndex = 7;
            // 
            // testingCmds
            // 
            this.ClientSize = new System.Drawing.Size(1326, 966);
            this.Controls.Add(this.txtPositive);
            this.Controls.Add(this.lblPositive);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.txtComfort);
            this.Controls.Add(this.lblComfort);
            this.Controls.Add(this.txtCare);
            this.Controls.Add(this.lblCare);
            this.Name = "testingCmds";
            this.Text = "1w";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdYes;
        private System.Windows.Forms.Button cmdNo;
        private System.Windows.Forms.Label lblCare;
        private System.Windows.Forms.TextBox txtCare;
        private System.Windows.Forms.Label lblComfort;
        private System.Windows.Forms.TextBox txtComfort;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label lblPositive;
        private System.Windows.Forms.TextBox txtPositive;
    }
}

