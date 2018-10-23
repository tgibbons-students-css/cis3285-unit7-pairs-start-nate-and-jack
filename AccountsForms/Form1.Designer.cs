namespace AccountsForms
{
    partial class Form1
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
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWithDrawal = new System.Windows.Forms.Button();
            this.txtWithdrawalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReward = new System.Windows.Forms.TextBox();
            this.txtReward2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBalance2 = new System.Windows.Forms.TextBox();
            this.txtWithdrawalAmount2 = new System.Windows.Forms.TextBox();
            this.btnWithDrawal2 = new System.Windows.Forms.Button();
            this.btnDeposit2 = new System.Windows.Forms.Button();
            this.txtDepositAmount2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(53, 51);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(100, 20);
            this.txtAccountName.TabIndex = 0;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(53, 91);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(100, 23);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.Location = new System.Drawing.Point(52, 164);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(137, 147);
            this.listBoxAccounts.TabIndex = 2;
            this.listBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.listBoxAccounts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Accounts";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(200, 95);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account Balance";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(341, 184);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDepositAmount.TabIndex = 7;
            this.txtDepositAmount.TextChanged += new System.EventHandler(this.txtDepositAmount_TextChanged);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(255, 182);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount";
            // 
            // btnWithDrawal
            // 
            this.btnWithDrawal.Location = new System.Drawing.Point(255, 212);
            this.btnWithDrawal.Name = "btnWithDrawal";
            this.btnWithDrawal.Size = new System.Drawing.Size(75, 23);
            this.btnWithDrawal.TabIndex = 10;
            this.btnWithDrawal.Text = "Withdrawal";
            this.btnWithDrawal.UseVisualStyleBackColor = true;
            this.btnWithDrawal.Click += new System.EventHandler(this.btnWithDrawal_Click);
            // 
            // txtWithdrawalAmount
            // 
            this.txtWithdrawalAmount.Location = new System.Drawing.Point(344, 214);
            this.txtWithdrawalAmount.Name = "txtWithdrawalAmount";
            this.txtWithdrawalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtWithdrawalAmount.TabIndex = 11;
            this.txtWithdrawalAmount.TextChanged += new System.EventHandler(this.txtWithdrawalAmount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wells Fargo Account Creator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Reward Points";
            // 
            // txtReward
            // 
            this.txtReward.Location = new System.Drawing.Point(200, 141);
            this.txtReward.Name = "txtReward";
            this.txtReward.Size = new System.Drawing.Size(100, 20);
            this.txtReward.TabIndex = 14;
            // 
            // txtReward2
            // 
            this.txtReward2.Location = new System.Drawing.Point(380, 141);
            this.txtReward2.Name = "txtReward2";
            this.txtReward2.Size = new System.Drawing.Size(100, 20);
            this.txtReward2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Reward Points";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Account Balance";
            // 
            // txtBalance2
            // 
            this.txtBalance2.Location = new System.Drawing.Point(380, 95);
            this.txtBalance2.Name = "txtBalance2";
            this.txtBalance2.Size = new System.Drawing.Size(100, 20);
            this.txtBalance2.TabIndex = 15;
            // 
            // txtWithdrawalAmount2
            // 
            this.txtWithdrawalAmount2.Location = new System.Drawing.Point(344, 291);
            this.txtWithdrawalAmount2.Name = "txtWithdrawalAmount2";
            this.txtWithdrawalAmount2.Size = new System.Drawing.Size(100, 20);
            this.txtWithdrawalAmount2.TabIndex = 22;
            this.txtWithdrawalAmount2.TextChanged += new System.EventHandler(this.txtWithdrawalAmount2_TextChanged);
            // 
            // btnWithDrawal2
            // 
            this.btnWithDrawal2.Location = new System.Drawing.Point(255, 289);
            this.btnWithDrawal2.Name = "btnWithDrawal2";
            this.btnWithDrawal2.Size = new System.Drawing.Size(75, 23);
            this.btnWithDrawal2.TabIndex = 21;
            this.btnWithDrawal2.Text = "Withdrawal";
            this.btnWithDrawal2.UseVisualStyleBackColor = true;
            this.btnWithDrawal2.Click += new System.EventHandler(this.btnWithDrawal2_Click_1);
            // 
            // btnDeposit2
            // 
            this.btnDeposit2.Location = new System.Drawing.Point(255, 259);
            this.btnDeposit2.Name = "btnDeposit2";
            this.btnDeposit2.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit2.TabIndex = 20;
            this.btnDeposit2.Text = "Deposit";
            this.btnDeposit2.UseVisualStyleBackColor = true;
            this.btnDeposit2.Click += new System.EventHandler(this.btnDeposit2_Click_1);
            // 
            // txtDepositAmount2
            // 
            this.txtDepositAmount2.Location = new System.Drawing.Point(341, 261);
            this.txtDepositAmount2.Name = "txtDepositAmount2";
            this.txtDepositAmount2.Size = new System.Drawing.Size(100, 20);
            this.txtDepositAmount2.TabIndex = 19;
            this.txtDepositAmount2.TextChanged += new System.EventHandler(this.txtDepositAmount2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(208, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Primary Acount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Secondary Acount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 385);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWithdrawalAmount2);
            this.Controls.Add(this.btnWithDrawal2);
            this.Controls.Add(this.btnDeposit2);
            this.Controls.Add(this.txtDepositAmount2);
            this.Controls.Add(this.txtReward2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBalance2);
            this.Controls.Add(this.txtReward);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWithdrawalAmount);
            this.Controls.Add(this.btnWithDrawal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAccounts);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.txtAccountName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWithDrawal;
        private System.Windows.Forms.TextBox txtWithdrawalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReward;
        private System.Windows.Forms.TextBox txtReward2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBalance2;
        private System.Windows.Forms.TextBox txtWithdrawalAmount2;
        private System.Windows.Forms.Button btnWithDrawal2;
        private System.Windows.Forms.Button btnDeposit2;
        private System.Windows.Forms.TextBox txtDepositAmount2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

