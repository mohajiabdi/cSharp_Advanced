namespace Classes_and_More_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            Coin myCoin = new Coin();

            myCoin.toss();

            // MessageBox.Show("Side Up is: " + myCoin.getSideUp());
            listBox1.Items.Add(myCoin.getSideUp());



        }

        public void ShowCoin(Coin coin)
        {
            coin.toss();

            MessageBox.Show("Side Up: " + coin.getSideUp());
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Coin mycoin = new Coin();
            ShowCoin(mycoin);
        }

        private void btnTossCoin_Click(object sender, EventArgs e)
        {
            Coin myCoin = new Coin();
            myCoin.toss();
            String coin = myCoin.getSideUp();
            listBox1.Items.Add(coin);
            if(coin == "Head")
            {
                picCoinTail.Visible = false;
                picCoinHead.Visible = true;
            }else
            {
                picCoinTail.Visible = true;
                picCoinHead.Visible = false;
            }
        }
    }
}
