namespace Class_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        class Car : Automobile
        {
            public int Doors { get; set; }
        }


        //the GetcarData Method accepts a Car Object as an 
        //Argument. it assigns the data entered by 
        //User to object's Properties
        private void GetCarData(Car car)
        {
            //Temporary variables to hold Mileage, Price and Doors
            int mileage;
            double price;
            int doors;

            //get the car's Make
            car.Make = txtMake.Text;

            //get the car's Model
            car.Model = txtModel.Text;

            //get the car's Mileage
            if (int.TryParse(txtMileage.Text, out mileage))
            {
                car.Mileage = mileage;

                //Get the Car's price
                if (double.TryParse(txtPrice.Text, out price))
                {
                    car.Price = price;

                    //Get the Car's Number of Doors
                    if (int.TryParse(txtDoors.Text, out doors))
                    {
                        car.Doors = doors;
                    }
                    else
                    {
                        //Display Error Message
                        MessageBox.Show("Invalid number of Doors!..");
                    }
                }
                else
                {
                    //Display Error Message
                    MessageBox.Show("Invalid Price!..");
                }
            }
            else
            {
                //Display Error Message
                MessageBox.Show("Invalid Mileage!..");
            }


        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            //Create a Car Object 
            Car myCar1 = new Car();

            //Get car Data 
            GetCarData(myCar1);

            //Clear textBoxes and Focus on MakeText Box
            txtMake.Text = "";
            txtModel.Text = "";
            txtMileage.Text = "";
            txtPrice.Text = "";
            txtDoors.Text = "";
            txtMake.Focus();


            //Display The Car Data
            lblMake.Text = myCar1.Make ;
            lblModel.Text = myCar1.Model ;
            lblMileage.Text = myCar1.Mileage.ToString();
            lblPrice.Text = myCar1.Price.ToString("c");
            lblDoors.Text = myCar1.Doors.ToString();
            



        }
    }
}
