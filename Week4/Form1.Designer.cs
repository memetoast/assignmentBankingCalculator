namespace Week4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonChecking = new System.Windows.Forms.RadioButton();
            this.radioButtonSaving = new System.Windows.Forms.RadioButton();
            this.textStartingBalance = new System.Windows.Forms.TextBox();
            this.textDeposit = new System.Windows.Forms.TextBox();
            this.textWithdraw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose your account";
            // 
            // radioButtonChecking
            // 
            this.radioButtonChecking.AutoSize = true;
            this.radioButtonChecking.Location = new System.Drawing.Point(22, 56);
            this.radioButtonChecking.Name = "radioButtonChecking";
            this.radioButtonChecking.Size = new System.Drawing.Size(96, 24);
            this.radioButtonChecking.TabIndex = 1;
            this.radioButtonChecking.Text = "Checkings";
            this.radioButtonChecking.UseVisualStyleBackColor = true;
            // 
            // radioButtonSaving
            // 
            this.radioButtonSaving.AutoSize = true;
            this.radioButtonSaving.Location = new System.Drawing.Point(236, 56);
            this.radioButtonSaving.Name = "radioButtonSaving";
            this.radioButtonSaving.Size = new System.Drawing.Size(80, 24);
            this.radioButtonSaving.TabIndex = 2;
            this.radioButtonSaving.Text = "Savings";
            this.radioButtonSaving.UseVisualStyleBackColor = true;
            // 
            // textStartingBalance
            // 
            this.textStartingBalance.Location = new System.Drawing.Point(149, 106);
            this.textStartingBalance.Name = "textStartingBalance";
            this.textStartingBalance.Size = new System.Drawing.Size(125, 27);
            this.textStartingBalance.TabIndex = 3;
            // 
            // textDeposit
            // 
            this.textDeposit.Location = new System.Drawing.Point(149, 139);
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.Size = new System.Drawing.Size(125, 27);
            this.textDeposit.TabIndex = 4;
            // 
            // textWithdraw
            // 
            this.textWithdraw.Location = new System.Drawing.Point(149, 172);
            this.textWithdraw.Name = "textWithdraw";
            this.textWithdraw.Size = new System.Drawing.Size(125, 27);
            this.textWithdraw.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Starting balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deposit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Withdraw";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Interest Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Transaction Fee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "0.5%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "$ 1.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Your total";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(101, 344);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(125, 27);
            this.textTotal.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 525);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textWithdraw);
            this.Controls.Add(this.textDeposit);
            this.Controls.Add(this.textStartingBalance);
            this.Controls.Add(this.radioButtonSaving);
            this.Controls.Add(this.radioButtonChecking);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton radioButtonChecking;
        private RadioButton radioButtonSaving;
        private TextBox textStartingBalance;
        private TextBox textDeposit;
        private TextBox textWithdraw;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textTotal;
        private Button button3;
    }
}