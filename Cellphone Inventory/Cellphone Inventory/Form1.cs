namespace Cellphone_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBrand.Focus();
        }

        // List to Hold CellPhone Objects...
        List<Phone> phonelist = new List<Phone>();


        private void btnAddphone_Click(object sender, EventArgs e)
        {
            //create myPhone Object
            Phone myPhone = new Phone();

            //Add myPhone obejct to the list
            getPhoneData(myPhone);

            //Add an entry to List Box
            listBox1.Items.Add(myPhone.Brand + " , " + myPhone.Model);

            // Call ClearTexts Method
            ClearTexts();



        }

        private void getPhoneData(Phone phonelist)
        {
            //temp variable to hold price
            decimal price;

            //get phone Brand
            phonelist.Brand = txtBrand.Text;

            //get phone Model
            phonelist.Model = txtModel.Text;


            //get Phone Price
            if (decimal.TryParse(txtPrice.Text, out price))
            {
                phonelist.Price = price;
            }
            else
            {
                //display Error Message
                MessageBox.Show("Invalid Price..");
            }

        }

        void ClearTexts()
        {
            txtBrand.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtBrand.Focus();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Check if there is a selected item
            if (listBox1.SelectedIndex != -1)
            {
                // Get index of the selected item
                int index = listBox1.SelectedIndex;

                // Check if the index is within the range of the phonelist
                if (index >= 0 && index < phonelist.Count)
                {
                    // Display the selected item Price
                    MessageBox.Show(phonelist[index].Price.ToString("c"));
                }
                else
                {
                    MessageBox.Show("Selected index is out of range.");
                }
            }
            else
            {
                MessageBox.Show("No item is selected.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close Form1
            this.Close();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            // Check the count of items in the phonelist
            MessageBox.Show("Phonelist Count: " + phonelist.Count);

            // Check the selected index
            MessageBox.Show("Selected Index: " + listBox1.SelectedIndex);
        }
    }
}
