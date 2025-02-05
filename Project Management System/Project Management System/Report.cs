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
using Microsoft.Reporting.WinForms;
using System.IO;

namespace Project_Management_System
{
    public partial class Report : Form
    {
        // Back Field
        string connectionString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
        public Report()
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


            this.Load += Report_Load;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            comboChoose.SelectedIndex = 0;
        

            // TODO: This line of code loads data into the 'pharmacyDataSet1.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.pharmacyDataSet1.Customers);
            btnReportMngmt.IconColor = System.Drawing.Color.Coral;
            btnReportMngmt.ForeColor = System.Drawing.Color.Coral;

            
          
            this.reportViewer1.RefreshReport();
            //this.reportViewerCustomer.RefreshReport();



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

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
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




        //Methods 

      

        //--------------------------------------------------------------------------------------------------------------------------------------

        private void GetReportMedicine(string filterValue = "")
        {
            string connectionString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            string query;

            // Construct the query based on the filter value
            if (string.IsNullOrWhiteSpace(filterValue))
            {
                query = "SELECT * FROM Medicines";
            }
            else
            {
                query = "SELECT * FROM Medicines WHERE Name LIKE @FilterValue";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(filterValue))
                        {
                            command.Parameters.AddWithValue("@FilterValue", "%" + filterValue + "%");
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet dataSet = new DataSet();
                            adapter.Fill(dataSet, "Medicines");

                            ReportDataSource source = new ReportDataSource("PharmacyDataSet", dataSet.Tables[0]);

                            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                              "C:\\Users\\RAQIIS COMPUTER\\Documents\\GitHub\\Coding-Zone\\cSharp_Advanced\\Project Management System\\Project Management System\\Report2.rdlc");
                            reportViewer1.LocalReport.ReportPath = reportPath;
                            reportViewer1.LocalReport.DataSources.Clear();
                            reportViewer1.LocalReport.DataSources.Add(source);
                            reportViewer1.RefreshReport();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //----------------------------------------------------------------------------------

        private void GetReportCustomer(string filterValue = "")
        {
            string connectionString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            string query;

            // Construct the query based on the filter value
            if (string.IsNullOrWhiteSpace(filterValue))
            {
                query = "SELECT * FROM Customers";
            }
            else
            {
                query = "SELECT * FROM Customers WHERE CustomerName LIKE @FilterValue";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(filterValue))
                        {
                            command.Parameters.AddWithValue("@FilterValue", "%" + filterValue + "%");
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet dataSet = new DataSet();
                            adapter.Fill(dataSet, "Customers");

                            ReportDataSource source = new ReportDataSource("DataSet1", dataSet.Tables[0]);

                            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                              "C:\\Users\\RAQIIS COMPUTER\\Documents\\GitHub\\Coding-Zone\\cSharp_Advanced\\Project Management System\\Project Management System\\Report1.rdlc");
                            reportViewer1.LocalReport.ReportPath = reportPath;
                            reportViewer1.LocalReport.DataSources.Clear();
                            reportViewer1.LocalReport.DataSources.Add(source);
                            reportViewer1.RefreshReport();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            


            if (comboChoose.SelectedIndex == 0)
            {
                GetReportCustomer(txtSearch.Text);
            }

            if (comboChoose.SelectedIndex == 1)
            {
                GetReportMedicine(txtSearch.Text);
            }
           
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void comboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboChoose.SelectedIndex == 0) {
                
                txtSearch.Text = string.Empty;
                txtSearch.Focus();
                GetReportCustomer();
            }

            if (comboChoose.SelectedIndex == 1)
            {
                txtSearch.Text = string.Empty;
                txtSearch.Focus();
                GetReportMedicine();
            }
           
        }
    }
}
