using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ado.Net_first_Example
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            comboChoose.SelectedIndex = 0;           
        }


        // Method to make it easier for me



        //Clear all
        private void clearData() {
            txtName.Text = "";
            txtAddress.Text = "";
            dateDob.ShowUpDown = false;
            comboChoose.Focus();
            //comboChoose.SelectedIndex = 0;
            comboNames.Items.Clear();






        }



        //  New Customer Info 
        private void newCustomer()
        {
            // Get data from the form controls
            string name = txtName.Text;
            string dob = dateDob.Value.ToString("yyyy-MM-dd"); // Assuming dateDob is a DateTimePicker control
            string address = txtAddress.Text;

            // Connection string (replace with your actual details)
            string conString = "Data Source=DESKTOP-LK1SELP; Database=Bank; Integrated Security=True";

            // Using block ensures proper connection handling
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    // Open the connection
                    con.Open();

                    // Prepare the INSERT statement with parameters
                    string query = "INSERT INTO Customer (custName, DOB, homeAddress) VALUES (@Name, @DOB, @Address)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters to the command (prevents SQL injection)
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Address", address);

                    // Execute the INSERT command
                    cmd.ExecuteNonQuery();

                    // Show success message (optional)
                    MessageBox.Show("Customer data inserted successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        


        // Populate Names in Combo Box
        private void PopulateComboBoxNames()
        {
            string conString = "Data Source=DESKTOP-LK1SELP; Database=Bank; Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT custName FROM Customer";
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboNames.Items.Add(reader["custName"].ToString());
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        // Update Customer
        private void customerUpdate()
        {
            string selectedName = comboNames.SelectedItem.ToString();
            string newName = txtNameUpdate.Text;
            string newDOB = dateDob.Value.ToString("yyyy-MM-dd");
            string newAddress = txtAddress.Text;

            string conString = "Data Source=DESKTOP-LK1SELP; Database=Bank; Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Customer SET custName = @NewName, DOB = @NewDOB, homeAddress = @NewAddress WHERE custName = @OldName";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@NewName", newName);
                    cmd.Parameters.AddWithValue("@NewDOB", newDOB);
                    cmd.Parameters.AddWithValue("@NewAddress", newAddress);
                    cmd.Parameters.AddWithValue("@OldName", selectedName);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer information updated successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        // Delete Customer
        public void DeleteCustomer()
        {
            string customerName = comboNames.SelectedItem.ToString();
            string conString = "Data Source=DESKTOP-LK1SELP; Database=Bank; Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Customer WHERE custName = @CustomerName";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@CustomerName", customerName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Customer not found or deletion failed.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }





        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form1 formOne = new Form1();

            formOne.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboChoose.SelectedIndex == 0)
            {
                txtId.ReadOnly = true;
                comboNames.Visible = false;
                txtName.Visible = true;
                btnDelete.Visible = false;
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                txtNameUpdate.Visible = false;
                txtAddress.ReadOnly = false;

            }

            if (comboChoose.SelectedIndex == 1)
            {
                txtId.ReadOnly = true;
                 txtName.Visible = false;
                comboNames.Visible = true;
                comboNames.DropDownStyle = ComboBoxStyle.DropDownList;
                btnDelete.Visible = false;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                txtNameUpdate.Visible = true;
                txtAddress.ReadOnly = false;

                clearData();
                PopulateComboBoxNames();
            }
            if (comboChoose.SelectedIndex == 2)
            {
                txtId.ReadOnly = true;
                 txtName.Visible = false;
                comboNames.Visible = true;
                btnDelete.Visible = true;
                btnSave.Visible = false;
                btnUpdate.Visible = false;
                txtAddress.ReadOnly = true;
                dateDob.ShowUpDown = false;
                txtNameUpdate.Visible = false;
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            customerUpdate();
            clearData();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
            clearData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newCustomer();
            clearData();

        }
    }
}
