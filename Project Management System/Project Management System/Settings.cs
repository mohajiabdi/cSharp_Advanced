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
using System.Xml.Linq;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace Project_Management_System
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();



            // Check if the logged-in user is an Admin
            if (Login.CurrentUserRole == "Admin")
            {

                // Show Admin-specific features
                btnAdminRole.Visible = true;
                btnStaffRole.Visible = false;
                // Additional admin-specific UI elements can be displayed here
            }

            // Check if the logged-in user is an Staff
            if (Login.CurrentUserRole == "Staff")
            {

                // Show Admin-specific features
                btnAdminRole.Visible = false;
                btnStaffRole.Visible = true;
                // Additional admin-specific UI elements can be displayed here

            }


            this.Load += Settings_Load;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            RefreshUserGrid();
            btnSettingsMngmt.IconColor = System.Drawing.Color.Coral;
            btnSettingsMngmt.ForeColor = System.Drawing.Color.Coral;


            //----------------------------------------------------------
            comboChoose.SelectedIndex  = 0;
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



        //-------------------------------------------------------------------------------------------------------------------------------

        // Extra Mehods 
        public void dashboardBtn()
        {
            lblTitle.Text = "Dashboard";

            Dashboard dashboard = new Dashboard();


            this.Hide();
            dashboard.ShowDialog();
            //this.Show();

            btnDashboardMngmt.IconColor = System.Drawing.Color.Coral;
            btnDashboardMngmt.ForeColor = System.Drawing.Color.Coral;
            btnCustomerMngmt.IconColor = System.Drawing.Color.White;
            btnCustomerMngmt.ForeColor = System.Drawing.Color.White;
            btnLogoutMngmt.IconColor = System.Drawing.Color.White;
            btnLogoutMngmt.ForeColor = System.Drawing.Color.White;
            btnMedicineMngmt.IconColor = System.Drawing.Color.White;
            btnMedicineMngmt.ForeColor = System.Drawing.Color.White;
            btnReportMngmt.IconColor = System.Drawing.Color.White;
            btnReportMngmt.ForeColor = System.Drawing.Color.White;
            btnSalesMngmt.IconColor = System.Drawing.Color.White;
            btnSalesMngmt.ForeColor = System.Drawing.Color.White;
            btnSearchMngmt.IconColor = System.Drawing.Color.White;
            btnSearchMngmt.ForeColor = System.Drawing.Color.White;
            btnSettingsMngmt.IconColor = System.Drawing.Color.White;
            btnSettingsMngmt.ForeColor = System.Drawing.Color.White;
        }

        public void customerBtn()
        {
            lblTitle.Text = "Customer";

            Customer customer = new Customer();


            this.Hide();
            customer.ShowDialog();
            //this.Show();

            btnDashboardMngmt.IconColor = System.Drawing.Color.White;
            btnDashboardMngmt.ForeColor = System.Drawing.Color.White;
            btnCustomerMngmt.IconColor = System.Drawing.Color.Coral;
            btnCustomerMngmt.ForeColor = System.Drawing.Color.Coral;
            btnLogoutMngmt.IconColor = System.Drawing.Color.White;
            btnLogoutMngmt.ForeColor = System.Drawing.Color.White;
            btnMedicineMngmt.IconColor = System.Drawing.Color.White;
            btnMedicineMngmt.ForeColor = System.Drawing.Color.White;
            btnReportMngmt.IconColor = System.Drawing.Color.White;
            btnReportMngmt.ForeColor = System.Drawing.Color.White;
            btnSalesMngmt.IconColor = System.Drawing.Color.White;
            btnSalesMngmt.ForeColor = System.Drawing.Color.White;
            btnSearchMngmt.IconColor = System.Drawing.Color.White;
            btnSearchMngmt.ForeColor = System.Drawing.Color.White;
            btnSettingsMngmt.IconColor = System.Drawing.Color.White;
            btnSettingsMngmt.ForeColor = System.Drawing.Color.White;
        }

        public void medicineBtn()
        {
            lblTitle.Text = "Medicine";

            Medicine medicine = new Medicine();

            this.Hide();
            medicine.ShowDialog();
            //this.Show();





            btnDashboardMngmt.IconColor = System.Drawing.Color.White;
            btnDashboardMngmt.ForeColor = System.Drawing.Color.White;
            btnCustomerMngmt.IconColor = System.Drawing.Color.White;
            btnCustomerMngmt.ForeColor = System.Drawing.Color.White;
            btnLogoutMngmt.IconColor = System.Drawing.Color.White;
            btnLogoutMngmt.ForeColor = System.Drawing.Color.White;
            btnMedicineMngmt.IconColor = System.Drawing.Color.Coral;
            btnMedicineMngmt.ForeColor = System.Drawing.Color.Coral;
            btnReportMngmt.IconColor = System.Drawing.Color.White;
            btnReportMngmt.ForeColor = System.Drawing.Color.White;
            btnSalesMngmt.IconColor = System.Drawing.Color.White;
            btnSalesMngmt.ForeColor = System.Drawing.Color.White;
            btnSearchMngmt.IconColor = System.Drawing.Color.White;
            btnSearchMngmt.ForeColor = System.Drawing.Color.White;
            btnSettingsMngmt.IconColor = System.Drawing.Color.White;
            btnSettingsMngmt.ForeColor = System.Drawing.Color.White;
        }

        public void salesBtn()
        {
            lblTitle.Text = "Sales";

            Sales sales = new Sales();

            this.Hide();
            sales.ShowDialog();
            //this.Show();

            btnDashboardMngmt.IconColor = System.Drawing.Color.White;
            btnDashboardMngmt.ForeColor = System.Drawing.Color.White;
            btnCustomerMngmt.IconColor = System.Drawing.Color.White;
            btnCustomerMngmt.ForeColor = System.Drawing.Color.White;
            btnLogoutMngmt.IconColor = System.Drawing.Color.White;
            btnLogoutMngmt.ForeColor = System.Drawing.Color.White;
            btnMedicineMngmt.IconColor = System.Drawing.Color.White;
            btnMedicineMngmt.ForeColor = System.Drawing.Color.White;
            btnReportMngmt.IconColor = System.Drawing.Color.White;
            btnReportMngmt.ForeColor = System.Drawing.Color.White;
            btnSalesMngmt.IconColor = System.Drawing.Color.Coral;
            btnSalesMngmt.ForeColor = System.Drawing.Color.Coral;
            btnSearchMngmt.IconColor = System.Drawing.Color.White;
            btnSearchMngmt.ForeColor = System.Drawing.Color.White;
            btnSettingsMngmt.IconColor = System.Drawing.Color.White;
            btnSettingsMngmt.ForeColor = System.Drawing.Color.White;


        }

        public void reportBtn()
        {
            lblTitle.Text = "Report";

            Report report = new Report();

            this.Hide();
            report.ShowDialog();
            //this.Show();

            btnDashboardMngmt.IconColor = System.Drawing.Color.White;
            btnDashboardMngmt.ForeColor = System.Drawing.Color.White;
            btnCustomerMngmt.IconColor = System.Drawing.Color.White;
            btnCustomerMngmt.ForeColor = System.Drawing.Color.White;
            btnLogoutMngmt.IconColor = System.Drawing.Color.White;
            btnLogoutMngmt.ForeColor = System.Drawing.Color.White;
            btnMedicineMngmt.IconColor = System.Drawing.Color.White;
            btnMedicineMngmt.ForeColor = System.Drawing.Color.White;
            btnReportMngmt.IconColor = System.Drawing.Color.Coral;
            btnReportMngmt.ForeColor = System.Drawing.Color.Coral;
            btnSalesMngmt.IconColor = System.Drawing.Color.White;
            btnSalesMngmt.ForeColor = System.Drawing.Color.White;
            btnSearchMngmt.IconColor = System.Drawing.Color.White;
            btnSearchMngmt.ForeColor = System.Drawing.Color.White;
            btnSettingsMngmt.IconColor = System.Drawing.Color.White;
            btnSettingsMngmt.ForeColor = System.Drawing.Color.White;

        }

        public void SearchBtn()
        {
            lblTitle.Text = "Search";

            Search search = new Search();

            this.Hide();
            search.ShowDialog();
            //this.Show();


            btnDashboardMngmt.IconColor = System.Drawing.Color.White;
            btnDashboardMngmt.ForeColor = System.Drawing.Color.White;
            btnCustomerMngmt.IconColor = System.Drawing.Color.White;
            btnCustomerMngmt.ForeColor = System.Drawing.Color.White;
            btnLogoutMngmt.IconColor = System.Drawing.Color.White;
            btnLogoutMngmt.ForeColor = System.Drawing.Color.White;
            btnMedicineMngmt.IconColor = System.Drawing.Color.White;
            btnMedicineMngmt.ForeColor = System.Drawing.Color.White;
            btnReportMngmt.IconColor = System.Drawing.Color.White;
            btnReportMngmt.ForeColor = System.Drawing.Color.White;
            btnSalesMngmt.IconColor = System.Drawing.Color.White;
            btnSalesMngmt.ForeColor = System.Drawing.Color.White;
            btnSearchMngmt.IconColor = System.Drawing.Color.Coral;
            btnSearchMngmt.ForeColor = System.Drawing.Color.Coral;
            btnSettingsMngmt.IconColor = System.Drawing.Color.White;
            btnSettingsMngmt.ForeColor = System.Drawing.Color.White;

        }

        public void settingsBtn()
        {
            lblTitle.Text = "Settings";


            Settings settings = new Settings();

            this.Hide();
            settings.ShowDialog();
            //this.Show();

            btnDashboardMngmt.IconColor = System.Drawing.Color.White;
            btnDashboardMngmt.ForeColor = System.Drawing.Color.White;
            btnCustomerMngmt.IconColor = System.Drawing.Color.White;
            btnCustomerMngmt.ForeColor = System.Drawing.Color.White;
            btnLogoutMngmt.IconColor = System.Drawing.Color.White;
            btnLogoutMngmt.ForeColor = System.Drawing.Color.White;
            btnMedicineMngmt.IconColor = System.Drawing.Color.White;
            btnMedicineMngmt.ForeColor = System.Drawing.Color.White;
            btnReportMngmt.IconColor = System.Drawing.Color.White;
            btnReportMngmt.ForeColor = System.Drawing.Color.White;
            btnSalesMngmt.IconColor = System.Drawing.Color.White;
            btnSalesMngmt.ForeColor = System.Drawing.Color.White;
            btnSearchMngmt.IconColor = System.Drawing.Color.White;
            btnSearchMngmt.ForeColor = System.Drawing.Color.White;
            btnSettingsMngmt.IconColor = System.Drawing.Color.Coral;
            btnSettingsMngmt.ForeColor = System.Drawing.Color.Coral;
        }

        public void logOutBtn()
        {

            lblTitle.Text = "Logout";


            btnDashboardMngmt.IconColor = System.Drawing.Color.White;
            btnDashboardMngmt.ForeColor = System.Drawing.Color.White;
            btnCustomerMngmt.IconColor = System.Drawing.Color.White;
            btnCustomerMngmt.ForeColor = System.Drawing.Color.White;
            btnLogoutMngmt.IconColor = System.Drawing.Color.Coral;
            btnLogoutMngmt.ForeColor = System.Drawing.Color.Coral;
            btnMedicineMngmt.IconColor = System.Drawing.Color.White;
            btnMedicineMngmt.ForeColor = System.Drawing.Color.White;
            btnReportMngmt.IconColor = System.Drawing.Color.White;
            btnReportMngmt.ForeColor = System.Drawing.Color.White;
            btnSalesMngmt.IconColor = System.Drawing.Color.White;
            btnSalesMngmt.ForeColor = System.Drawing.Color.White;
            btnSearchMngmt.IconColor = System.Drawing.Color.White;
            btnSearchMngmt.ForeColor = System.Drawing.Color.White;
            btnSettingsMngmt.IconColor = System.Drawing.Color.White;
            btnSettingsMngmt.ForeColor = System.Drawing.Color.White;


            MessageBox.Show("You Are Logged Out!!");
            Login.CurrentUserRole = string.Empty;
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }


        private void btnDashboardMngmt_Click(object sender, EventArgs e)
        {
            dashboardBtn();
        }

        private void btnMedicineMngmt_Click(object sender, EventArgs e)
        {
            medicineBtn();
        }

        private void btnCustomerMngmt_Click(object sender, EventArgs e)
        {
            customerBtn();
        }

        private void btnSalesMngmt_Click(object sender, EventArgs e)
        {
            salesBtn();
        }

        private void btnReportMngmt_Click(object sender, EventArgs e)
        {
            reportBtn();
        }

        private void btnSearchMngmt_Click(object sender, EventArgs e)
        {
            SearchBtn();
        }

        private void btnSettingsMngmt_Click(object sender, EventArgs e)
        {
            settingsBtn();
        }

        private void btnLogoutMngmt_Click(object sender, EventArgs e)
        {
            logOutBtn();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        // Method to Add a new user
        public void AddUser(string username, string password, string role)
        {
            string connectionString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO UserDt (Username, Password, Role) VALUES (@Username, @Password, @Role)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to Update an existing user's details
        public void UpdateUser(int userId, string username, string password, string role)
        {
            string connectionString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE UserDt SET Username = @Username, Password = @Password, Role = @Role WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to Delete a user by their ID
        public void DeleteUser(int userId)
        {
            string connectionString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM UserDt WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to check if a user exists by username (optional, useful for validation)
        public bool UserExists(string username)
        {
            string connectionString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM UserDt WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";

            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;
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
                            RefreshUserGrid();
                            clearData();
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




        //----------------------------------------------------------------


        // get user by id
        private void getUserById(int UserID)
        {
            string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            // clearData();
            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "Select * from UserDt where UserId = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@UserID", UserID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtUserName.Text = reader["UserName"].ToString();
                    txtPassword.Text = reader["Password"]?.ToString(); // Handle NULL for ContactNumber
                }
                else
                {
                    MessageBox.Show("User not found. Please check the ID.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                conn.Close();

            }

        }
        

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            // clearData();

            if (!int.TryParse(txtId.Text, out int UserID))
            {
                MessageBox.Show("Please enter a valid User ID.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Step 1: Fetch details if textboxes are empty
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                getUserById(UserID); 
                return;
            }
        }

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Additional admin-specific UI elements can be displayed here
            if (comboChoose.SelectedIndex == 0)
            {
               
                clearData();
                txtId.Visible = false;
                lblId.Visible = false;
                btnRetrieve.Visible = false;
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                lblChoose.Visible = true;
                comboRole.Visible = true;
               

            }
            if (comboChoose.SelectedIndex == 1)
            {
                clearData();
                txtId.Visible = true;
                lblId.Visible = true;
                btnRetrieve.Visible = true;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = false;
                lblChoose.Visible = true;
                comboRole.Visible = true;

                txtId.Focus();

            }


            if (comboChoose.SelectedIndex == 2)
            {
                clearData();
                txtId.Visible = true;
                lblId.Visible = true;
                btnRetrieve.Visible = true;
                btnSave.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = true;
                lblChoose.Visible = false;
                comboRole.Visible = false;
                txtPassword.ReadOnly = true;
                txtUserName.ReadOnly = true;

                txtId.Focus();


            }
          
        }


        // Update Customer Info
        private void UpdateUser(int UserID, string UserName, string Password)
        {
            string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "UPDATE UserDt SET UserName = @UserName, Password = @Password WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void UpdateUser1(int UserID, string UserName, string Password, string Role)
        {
            string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "UPDATE UserDt SET UserName = @UserName, Password = @Password, Role = @Role WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Role", Role);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please check the User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        // Delete Customer
        private void DeleteCustomer(int UserID)
        {
                string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string query = "DELETE FROM UserDt WHERE UserID = @UserID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
        }

        //Get Customer
        private DataTable GetUSer()
        {
            string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            DataTable UserTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "SELECT * FROM UserDt";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(UserTable);
            }

            return UserTable;
        }


        //REfresh Customer GridView
        private void RefreshUserGrid()
        {
            UserDataGridView.DataSource = GetUSer();
        }

        void clearData()
        {
            txtId.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int UserID) ||
                string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a valid User ID and UserName.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string role = comboRole.SelectedItem.ToString();
                //UpdateUser(UserID, txtUserName.Text, txtPassword.Text);
                UpdateUser1(UserID, txtUserName.Text, txtPassword.Text, role);
               // MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshUserGrid();
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int UserID))
            {
                MessageBox.Show("Please enter a valid Customer ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this User?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteUser(UserID);
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshUserGrid();
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            clearData();
        }
    }
}
    

