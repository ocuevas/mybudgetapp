namespace project3
{
    partial class budgetApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputBudget = new System.Windows.Forms.TextBox();
            this.submitBudget = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameExpense = new System.Windows.Forms.TextBox();
            this.expenseAmount = new System.Windows.Forms.TextBox();
            this.addExpenses = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expensesList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showBudget = new System.Windows.Forms.Label();
            this.leftAmountShow = new System.Windows.Forms.Label();
            this.deleteExpenses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Weekly Budget";
            // 
            // inputBudget
            // 
            this.inputBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBudget.Location = new System.Drawing.Point(37, 132);
            this.inputBudget.Name = "inputBudget";
            this.inputBudget.Size = new System.Drawing.Size(208, 45);
            this.inputBudget.TabIndex = 1;
            this.inputBudget.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // submitBudget
            // 
            this.submitBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(4)))), ((int)(((byte)(36)))));
            this.submitBudget.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBudget.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.submitBudget.Location = new System.Drawing.Point(250, 132);
            this.submitBudget.Name = "submitBudget";
            this.submitBudget.Size = new System.Drawing.Size(116, 47);
            this.submitBudget.TabIndex = 2;
            this.submitBudget.Text = "Submit";
            this.submitBudget.UseVisualStyleBackColor = false;
            this.submitBudget.Click += new System.EventHandler(this.SubmitBudget_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "What\'s your budget for this week?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Expenses";
            // 
            // nameExpense
            // 
            this.nameExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameExpense.Location = new System.Drawing.Point(37, 328);
            this.nameExpense.Name = "nameExpense";
            this.nameExpense.Size = new System.Drawing.Size(293, 45);
            this.nameExpense.TabIndex = 5;
            // 
            // expenseAmount
            // 
            this.expenseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseAmount.Location = new System.Drawing.Point(37, 409);
            this.expenseAmount.Name = "expenseAmount";
            this.expenseAmount.Size = new System.Drawing.Size(293, 45);
            this.expenseAmount.TabIndex = 5;
            // 
            // addExpenses
            // 
            this.addExpenses.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenses.ForeColor = System.Drawing.Color.White;
            this.addExpenses.Location = new System.Drawing.Point(222, 475);
            this.addExpenses.Name = "addExpenses";
            this.addExpenses.Size = new System.Drawing.Size(108, 57);
            this.addExpenses.TabIndex = 6;
            this.addExpenses.Text = "Add";
            this.addExpenses.UseVisualStyleBackColor = false;
            this.addExpenses.Click += new System.EventHandler(this.AddExpenses_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(32, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(32, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount: ";
            // 
            // expensesList
            // 
            this.expensesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesList.FormattingEnabled = true;
            this.expensesList.ItemHeight = 31;
            this.expensesList.Location = new System.Drawing.Point(442, 202);
            this.expensesList.Name = "expensesList";
            this.expensesList.Size = new System.Drawing.Size(429, 252);
            this.expensesList.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(433, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Budget:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(616, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "Left:";
            // 
            // showBudget
            // 
            this.showBudget.AutoSize = true;
            this.showBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(242)))), ((int)(((byte)(55)))));
            this.showBudget.Location = new System.Drawing.Point(557, 123);
            this.showBudget.Name = "showBudget";
            this.showBudget.Size = new System.Drawing.Size(0, 31);
            this.showBudget.TabIndex = 10;
            // 
            // leftAmountShow
            // 
            this.leftAmountShow.AutoSize = true;
            this.leftAmountShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftAmountShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(202)))), ((int)(((byte)(4)))));
            this.leftAmountShow.Location = new System.Drawing.Point(742, 126);
            this.leftAmountShow.Name = "leftAmountShow";
            this.leftAmountShow.Size = new System.Drawing.Size(0, 31);
            this.leftAmountShow.TabIndex = 11;
            // 
            // deleteExpenses
            // 
            this.deleteExpenses.BackColor = System.Drawing.Color.Red;
            this.deleteExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteExpenses.ForeColor = System.Drawing.Color.White;
            this.deleteExpenses.Location = new System.Drawing.Point(725, 475);
            this.deleteExpenses.Name = "deleteExpenses";
            this.deleteExpenses.Size = new System.Drawing.Size(146, 49);
            this.deleteExpenses.TabIndex = 12;
            this.deleteExpenses.Text = "Delete ";
            this.deleteExpenses.UseVisualStyleBackColor = false;
            this.deleteExpenses.Click += new System.EventHandler(this.DeleteExpenses_Click);
            // 
            // budgetApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(927, 576);
            this.Controls.Add(this.deleteExpenses);
            this.Controls.Add(this.leftAmountShow);
            this.Controls.Add(this.showBudget);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expensesList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addExpenses);
            this.Controls.Add(this.expenseAmount);
            this.Controls.Add(this.nameExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitBudget);
            this.Controls.Add(this.inputBudget);
            this.Controls.Add(this.label1);
            this.Name = "budgetApp";
            this.Text = "budgetApp";
            this.Load += new System.EventHandler(this.BudgetApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBudget;
        private System.Windows.Forms.Button submitBudget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameExpense;
        private System.Windows.Forms.TextBox expenseAmount;
        private System.Windows.Forms.Button addExpenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox expensesList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label showBudget;
        private System.Windows.Forms.Label leftAmountShow;
        private System.Windows.Forms.Button deleteExpenses;
    }
}

