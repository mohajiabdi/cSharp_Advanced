namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Overload account = new Overload(10000);

        private void btnShow_Click(object sender, EventArgs e)
        {


            lblBalance.Text = account.Balance.ToString("c");

        }


        private void btnDeposit_Click(object sender, EventArgs e)
        {

            decimal amount;
            if (decimal.TryParse(txtDeposit.Text, out amount))
            {
                account.Deposit(amount);

                lblBalance.Text = account.Balance.ToString("c");

                txtDeposit.Text = string.Empty;


            }
            else
            {
                MessageBox.Show("Invalid Ammount");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtWithdraw.Text, out amount))
            {

                if (account.Balance >= amount)
                {
                    account.Withdraw(amount);

                    lblBalance.Text = account.Balance.ToString("c");

                    txtWithdraw.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Not Enough Balance!..");
                    txtWithdraw.Text = string.Empty;
                    txtWithdraw.Focus();
                }
               


            }
            else
            {
                MessageBox.Show("Invalid Ammount");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            MinimizeBox = true;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            
        }
    }
}
