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
            outputList.Items.Clear();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            outputList.Items.Clear();
            Coin myCoin = new Coin();

            myCoin.toss();

            for (int i = 0; i < 5; i++) {
                outputList.Items.Add(myCoin.getSideUp());
                myCoin.toss();
            }

            // MessageBox.Show("Side Up is: " + myCoin.getSideUp());
           



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
            outputList.Items.Add(coin);
            if (coin == "Head")
            {
                picCoinTail.Visible = false;
                picCoinHead.Visible = true;
            }
            else
            {
                picCoinTail.Visible = true;
                picCoinHead.Visible = false;
            }
        }

        private void btnPetName_Click(object sender, EventArgs e)
        {
            Pet cat = new Pet();
            Pet bird = new Pet();

            cat.magac = "Bisad";
            bird.magac = "Shimbir";

            MessageBox.Show("Cat name is : " + cat.magac + "\nBird Name is : " + bird.magac);

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle myCircle = new Circle();
            myCircle.Diameter = 100;

            MessageBox.Show("Diameter is :"+ myCircle.Diameter +
                "\nRadius is :"+myCircle.Radius);
        }
    }
}
