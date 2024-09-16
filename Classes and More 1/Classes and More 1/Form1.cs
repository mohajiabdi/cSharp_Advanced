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
    }
}
