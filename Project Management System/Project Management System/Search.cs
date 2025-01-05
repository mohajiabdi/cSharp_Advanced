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

namespace Project_Management_System
{
    public partial class Search : Form
    {
        // Backing Fields
        string conString = "Data Source=DESKTOP-LK1SELP; Database=Pharmacy; Integrated Security=True";
        public Search()
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

            this.Load += Search_Load;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            btnSearchMngmt.IconColor = System.Drawing.Color.Coral;
            btnSearchMngmt.ForeColor = System.Drawing.Color.Coral;

            comboChoose.SelectedIndex = 0;
            comboList.SelectedIndex = 0;


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
            // Check if the logged-in user is an Admin
            if (Login.CurrentUserRole == "Admin")
            {
                // Additional admin-specific UI elements can be displayed here
                settingsBtn();
            }

            // Check if the logged-in user is an Staff
            if (Login.CurrentUserRole == "Staff")
            {

                // Additional admin-specific UI elements can be displayed here
                MessageBox.Show("You don't have Previlege to access Users Settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }

        private void btnLogoutMngmt_Click(object sender, EventArgs e)
        {
            logOutBtn();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        // Methods 


        // Populate Customer Names in Combo Box
        private void PopulateCustomerNames()
        {
            

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT CustomerName FROM Customers Order By CustomerName asc";
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();
                    comboList.Items.Clear();
                    while (reader.Read())
                    {
                        comboList.Items.Add(reader["CustomerName"].ToString());
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        // Popluate Customer IDS  in Combo Box
        private void PopulateCustomerIDs()
        {


            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT CustomerID FROM Customers Order By CustomerID asc";
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();
                    comboList.Items.Clear();
                    while (reader.Read())
                    {
                        comboList.Items.Add(reader["CustomerID"].ToString());
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Popluate Customer IDS  in Combo Box
        private void PopulatePhoneNumber()
        {


            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT ContactNumber FROM Customers order by CustomerName asc";
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();
                    comboList.Items.Clear();
                    while (reader.Read())
                    {
                        comboList.Items.Add(reader["ContactNumber"].ToString());
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        // Popluate Customer IDS  in Combo Box
        private void PopulateMedicineIDs()
        {


            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT MedicineID FROM Medicines order by MedicineID";
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader reader = cmd.ExecuteReader();
                    comboList.Items.Clear();
                    while (reader.Read())
                    {
                        comboList.Items.Add(reader["MedicineID"].ToString());
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        // Popluate Customer IDS  in Combo Box
        private void PopulateMedicineNames()
        {


            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Name FROM Medicines order by Name asc";
                    SqlCommand cmd = new SqlCommand(query, con);
                    

                    SqlDataReader reader = cmd.ExecuteReader();
                    comboList.Items.Clear();
                    while (reader.Read())
                    {
                        comboList.Items.Add(reader["Name"].ToString());
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        //SHowing Customer Info Using only ID
        private void ShowCustomerUsingID()
        {
            

            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", int.Parse(comboList.SelectedItem.ToString()));
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            searchDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //SHowing Customer Info Using only Customer Name
        private void ShowCustomerUsingName()
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Customers WHERE CustomerName = @CustomerName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName",comboList.SelectedItem.ToString());
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            searchDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //SHowing Customer Info Using only Phone Number
        private void ShowCustomerUsingPhone()
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Customers WHERE ContactNumber = @ContactNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContactNumber", comboList.SelectedItem.ToString());
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            searchDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //SHowing Medicine Info Using only Id
        private void ShowMediciceUsingID()
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Medicines WHERE MedicineID = @MedicineID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MedicineID", comboList.SelectedItem.ToString());
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            searchDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Medicine data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //SHowing Medicine Info Using only Name
        private void ShowMedicineUsingName()
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Medicines WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", comboList.SelectedItem.ToString());
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            searchDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //SHowing Medicine Info Using only Name
        private void ShowAllMedicines()
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Medicines ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            searchDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //SHowing Medicine Info Using only Name
        private void ShowAllCustomers()
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Customers ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            searchDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboChoose.SelectedIndex == 0) { 
                
                PopulateCustomerIDs();
                comboList.SelectedIndex = 0;
                searchDataGridView.DataSource = "";
            }



            if (comboChoose.SelectedIndex == 1) {
                PopulateCustomerNames();
                comboList.SelectedIndex = 0;
                searchDataGridView.DataSource = "";
            }

            if (comboChoose.SelectedIndex == 2) {
            
                PopulatePhoneNumber();
                comboList.SelectedIndex = 0;
                searchDataGridView.DataSource = "";
            }
            if (comboChoose.SelectedIndex == 3) { 
                PopulateMedicineIDs();
                comboList.SelectedIndex = 0;
                searchDataGridView.DataSource = "";
            }

            if (comboChoose.SelectedIndex == 4) {
            
                PopulateMedicineNames();
                comboList.SelectedIndex = 0;
                searchDataGridView.DataSource = "";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (comboChoose.SelectedIndex == 0)
            {

               
                ShowCustomerUsingID();
            }



            if (comboChoose.SelectedIndex == 1)
            {
                ShowCustomerUsingName();
            }

            if (comboChoose.SelectedIndex == 2)
            {

               ShowCustomerUsingPhone();
            }
            if (comboChoose.SelectedIndex == 3)
            {
               ShowMediciceUsingID();
            }

            if (comboChoose.SelectedIndex == 4)
            {

                ShowMedicineUsingName();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (comboChoose.SelectedIndex == 0)
            {


                ShowAllCustomers();
            }



            if (comboChoose.SelectedIndex == 1)
            {
                ShowAllCustomers();
            }

            if (comboChoose.SelectedIndex == 2)
            {

                ShowAllCustomers();
            }
            if (comboChoose.SelectedIndex == 3)
            {
                ShowAllMedicines();
            }

            if (comboChoose.SelectedIndex == 4)
            {

                ShowAllMedicines();
            }
        }
    }
}
