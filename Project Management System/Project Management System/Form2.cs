using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class Login : Form
    {

        // Backing Field
        string connectionString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
        public static string CurrentUserRole = string.Empty;

        public Login()
        {
            InitializeComponent();


            this.Load += Form2_Load;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ClearData();
            //LoadRoles();
            panelLogin.Visible = true;
            panelRegister.Visible = false;
            txtUser.Focus ();
            comboRole.SelectedIndex = 0;

            //----------------------------------------------------------

            // Start with 0 opacity
            this.Opacity = 0;

            Timer timer = new Timer();
            timer.Interval = 5; // Adjust interval for transition speed
            timer.Tick += (s, args) =>
            {
                this.Opacity += 0.01; // Gradually increase opacity

                if (this.Opacity >= 1)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();

            //---------------------------------------------------
        }



        void ClearData()
        {
            txtNewPassword.Text = string.Empty;
            txtNewUser.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        //---------------------------------------------------------------------------------------------------------

        

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
            ClearData();
            txtNewUser.Focus();

        }


       

        private void btnGoLogin_Click_1(object sender, EventArgs e)
        {
            ClearData();
            panelLogin.Visible = true;
            panelRegister.Visible = false;
            txtUser.Focus();
        }

    

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";

            string username = txtNewUser.Text.Trim();
            string password = txtNewPassword.Text;
            string role = comboRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            string query = "INSERT INTO UserDt (Username, Password, Role) VALUES (@Username, @Password, @Role)";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();
                            txtNewUser.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) // Unique constraint error
                        {
                            MessageBox.Show("Username already exists. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }




        // Load Combo Roles
        private void LoadRoles()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT RoleName FROM Roles";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboRole.Items.Add(reader["RoleName"].ToString());
                        }
                    }
                }
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            string query = "SELECT Password, Role FROM UserDt WHERE Username = @Username";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader["Password"].ToString();
                                string role = reader["Role"].ToString();

                                if (storedPassword == password)
                                {
                                    // Store the user role in a global variable
                                    CurrentUserRole = role;

                                    if (role == "Admin")
                                    {
                                        MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        // Redirect to admin dashboard
                                        Dashboard adminForm = new Dashboard();
                                        adminForm.Show();
                                        this.Hide(); // Close login form
                                    }
                                    else if (role == "Staff")
                                    {
                                        MessageBox.Show("Welcome Staff!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        // Redirect to staff dashboard
                                        Dashboard staffForm = new Dashboard();
                                        staffForm.Show();
                                        this.Hide(); // Close login form
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRole.SelectedIndex != -1) { 
                ClearData();
                txtNewUser.Focus();

            }
        }
    }
}
