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


        class Truck : Automobile
        {
            public string Drive { get; set; }
        }

        class Bl : Automobile
        {
            public int Passengers { get; set; }
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


        // get Truck Data 
        private void GetTruckData(Truck truck)
        {
            int mileage;
            double price;

            

            //get the car's Make
            truck.Make = txtMake.Text;

            //get the car's Model
            truck.Model = txtModel.Text;


            //get the car's Drive, is it 4 wheels or 8 wheels
            truck.Drive = txtDrive.Text;

            //get the car's Mileage
            if (int.TryParse(txtMileage.Text, out mileage))
            {
                truck.Mileage = mileage;

                //Get the Car's price
                if (double.TryParse(txtPrice.Text, out price))
                {
                    truck.Price = price;
                }
                else
                {
                    //Display Error Message
                    MessageBox.Show("Invalid Price..");
                    
                }
            }
            else
            {
                //Display Error Message
                MessageBox.Show("Invalid Mileage!..");
                
            }
        }

        //Get Bl Data
        private void GetBlData(Bl bl)
        {
            int mileage;
            double price;
            int passengers;


           

            //get the car's Make
            bl.Make = txtMake.Text;

            //get the car's Model
            bl.Model = txtModel.Text;




            //get the car's Mileage
            if (int.TryParse(txtMileage.Text, out mileage))
            {
                bl.Mileage = mileage;

                //Get the Car's price
                if (double.TryParse(txtPrice.Text, out price))
                {
                    bl.Price = price;

                    //Get the Car's Total Passengers
                    if (int.TryParse(txtPassengers.Text, out passengers))
                    {
                        bl.Passengers = passengers;
                    }
                    else
                    {
                        //Display Error Message
                        MessageBox.Show("Wrong Passenger Number!..");
                       
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




        //Display Car Data in Labels on the right
        private void displayCarData(Car car)
        {
            //Clear textBoxes and Focus on MakeText Box
            txtMake.Text = "";
            txtModel.Text = "";
            txtMileage.Text = "";
            txtPrice.Text = "";
            txtDoors.Text = "";
            txtDrive.Text = "";
            txtPassengers.Text = "";
            txtMake.Focus();


            //Display The Car Data
            lblMake.Text = car.Make;
            lblModel.Text = car.Model;
            lblMileage.Text = car.Mileage.ToString();
            lblPrice.Text = car.Price.ToString("c");
            lblDoors.Text = car.Doors.ToString();



        }


        //Display Truck Data in Labels  on the right
        private void displayTruckData(Truck truck)
        {
            //Clear textBoxes and Focus on MakeText Box
            txtMake.Text = "";
            txtModel.Text = "";
            txtMileage.Text = "";
            txtPrice.Text = "";
            txtDoors.Text = "";
            txtDrive.Text = "";
            txtPassengers.Text = "";
            txtMake.Focus();


            //Display The Car Data
            lblMake.Text = truck.Make;
            lblModel.Text = truck.Model;
            lblMileage.Text = truck.Mileage.ToString();
            lblPrice.Text = truck.Price.ToString("c");
            lblDrive.Text = truck.Drive;

        }


        //Display BL Data in Labels on the right
        private void displayBlData(Bl bl)
        {
            //Clear textBoxes and Focus on MakeText Box
            txtMake.Text = "";
            txtModel.Text = "";
            txtMileage.Text = "";
            txtPrice.Text = "";
            txtDoors.Text = "";
            txtDrive.Text = "";
            txtPassengers.Text = "";
            txtMake.Focus();


            //Display The Car Data
            lblMake.Text = bl.Make;
            lblModel.Text = bl.Model;
            lblMileage.Text = bl.Mileage.ToString();
            lblPrice.Text = bl.Price.ToString("c");
            lblPassengers.Text = bl.Passengers.ToString();

        }
        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            //Create a Car Object 
            Car myCar = new Car();
            Truck myTruck = new Truck();
            Bl myBl = new Bl();


            if (comboBox1.SelectedIndex == 0) {
                GetCarData(myCar);
                displayCarData(myCar);
                lblObject.Text = comboBox1.Text;
                comboBox1.SelectedIndex = 1;
                comboBox1.SelectedIndex = 0;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                GetTruckData(myTruck);
                displayTruckData(myTruck);
                lblObject.Text = comboBox1.Text;
                comboBox1.SelectedIndex = 2;
                comboBox1.SelectedIndex = 1;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                GetBlData(myBl);
                displayBlData(myBl);
                lblObject.Text = comboBox1.Text;
                comboBox1.SelectedIndex = 1;
                comboBox1.SelectedIndex = 2;
            }


           











        }

        void clearData()
        {
            //Clear textBoxes and Focus on MakeText Box
            txtMake.Text = "";
            txtModel.Text = "";
            txtMileage.Text = "";
            txtPrice.Text = "";
            txtDoors.Text = "";
            txtDrive.Text = "";
            txtPassengers.Text = "";
            txtMake.Focus();

            lblDoors.Text = "";
            lblMake.Text = "";
            lblModel.Text = "";
            lblPassengers.Text = "";
            lblPrice.Text = "";
            lblDrive.Text = "";
            lblMileage.Text = "";
            lblObject.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                clearData();
                txtDrive.Enabled = false;
                txtPassengers.Enabled = false;
                txtMake.Enabled = true;
                txtModel.Enabled = true;
                txtMileage.Enabled = true;
                txtPrice.Enabled = true;
                txtDoors.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                clearData();
                txtMake.Enabled = true;
                txtModel.Enabled = true;
                txtMileage.Enabled = true;
                txtPrice.Enabled = true;
                txtDoors.Enabled = false;
                txtPassengers.Enabled = false;
                txtDrive.Enabled = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                clearData();
                txtMake.Enabled = true;
                txtModel.Enabled = true;
                txtMileage.Enabled = true;
                txtPrice.Enabled = true;
                txtDoors.Enabled = false;
                txtDrive.Enabled = false;
                txtPassengers.Enabled = true;
            }
        }
    }
}
