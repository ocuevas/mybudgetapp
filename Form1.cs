using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project3
{
    public partial class budgetApp : Form
    {
        private static int budgetAmount = 0;
        private static int expensesAmount = 0;
        private static int amountLeft = 0;
        
        

        public budgetApp()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BudgetApp_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBudget_Click(object sender, EventArgs e)
        {
            showBudget.Text = "$" + inputBudget.Text;
            budgetAmount = int.Parse(inputBudget.Text);
            amountLeft = budgetAmount;
            leftAmountShow.Text = "$" + amountLeft.ToString();
            this.inputBudget.Clear();
        }

        private void AddExpenses_Click(object sender, EventArgs e)
        {
            expensesList.Items.Add(nameExpense.Text + "         " + "$" + expenseAmount.Text);
            expensesAmount = int.Parse(expenseAmount.Text);
            amountLeft -= expensesAmount;

            
            leftAmountShow.Text = "$" + (amountLeft).ToString();

            this.nameExpense.Clear();
            this.expenseAmount.Clear();
        }

        private void DeleteExpenses_Click(object sender, EventArgs e)
        {
            if(this.expensesList.SelectedIndex >= 0)
            {
                this.expensesList.Items.RemoveAt(this.expensesList.SelectedIndex);
                
            }
        }
    }
}
