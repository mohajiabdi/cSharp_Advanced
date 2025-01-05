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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Windows.Forms.DataVisualization.Charting;



namespace Project_Management_System
{
    public partial class Dashboard : Form
    {
        // Backing Field
        string connectionString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
        public Dashboard()
        {
            InitializeComponent();

            LoadSalesData();
            //LoadSalesDataToChart();

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



            // Start the animation on form load
            this.Load += Dashboard_Load;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblTotalIncome.Text = GetTotalIncome().ToString();


            btnDashboardMngmt.IconColor = System.Drawing.Color.Coral;
            btnDashboardMngmt.ForeColor = System.Drawing.Color.Coral;



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
        //---------------------------------------------------------------------------------------------------------


        // Load sales Data to DataGridView
        private void LoadSalesData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string query = @"
                    SELECT 
                        s.SaleID,
                        c.CustomerName,
                        c.ContactNumber,
                        m.Name AS MedicineName,
                        s.SaleDate,
                        sd.Quantity,
                        sd.Price * sd.Quantity AS TotalPrice
                    FROM 
                        Sales s
                    LEFT JOIN 
                        Customers c ON s.CustomerID = c.CustomerID
                    INNER JOIN 
                        SalesDetails sd ON s.SaleID = sd.SaleID
                    INNER JOIN 
                        Medicines m ON sd.MedicineID = m.MedicineID
                    ORDER BY s.SaleDate Desc;";  //   Added order by clause


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dashboardDataGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //private void LoadSalesDataToChart()
        //{
        //    try
        //    {
        //        using (var connection = new SqlConnection(connectionString))
        //        using (var command = new SqlCommand(@"
        //        SELECT 
        //            DATEPART(MONTH, s.SaleDate) AS Month, 
        //            SUM(s.TotalAmount) AS TotalIncome 
        //        FROM 
        //            Sales s
        //        GROUP BY DATEPART(MONTH, s.SaleDate)", connection))
        //        {
        //            connection.Open(); // Open the connection before executing the command

        //            using (var reader = command.ExecuteReader())
        //            {
        //                var values = new List<double>();
        //                var labels = new List<string>();

        //                while (reader.Read())
        //                {
        //                    labels.Add($"Month {reader.GetInt32(0)}");
        //                    values.Add(reader.GetDouble(1));
        //                }

        //                cartesianChart1.Series.Clear();
        //                cartesianChart1.Series.Add(new LineSeries
        //                {
        //                    Values = new ChartValues<double>(values),
        //                    PointGeometry = null,
        //                    LineSmoothness = 0.2,
        //                    StrokeThickness = 2
        //                });

        //                cartesianChart1.AxisX[0].Labels = labels.ToArray();
        //                cartesianChart1.AxisX[0].Title = "Month";

        //                cartesianChart1.AxisY[0].Title = "Total Income";
        //                cartesianChart1.AxisY[0].LabelFormatter = value => value.ToString("C");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error loading sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}







        private DataTable GetIncomeData()
        {
            DataTable incomeData = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                FORMAT(SaleDate, 'yyyy-MM') AS Month, 
                SUM(TotalAmount) AS TotalIncome
            FROM Sales
            GROUP BY FORMAT(SaleDate, 'yyyy-MM')
            ORDER BY Month";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(incomeData);
                }
            }

            return incomeData;
        }




        //private void LoadIncomeChart()
        //{
        //    DataTable incomeData = GetIncomeData();

        //    chartIncome.Series.Clear(); // Clear any existing series
        //    chartIncome.Titles.Clear();

        //    // Add a title
        //    chartIncome.Titles.Add("Monthly Income");

        //    // Create a new series
        //    Series series = new Series("Income")
        //    {
        //        ChartType = SeriesChartType.Line // Change to Line for a line chart
        //    };

        //    foreach (DataRow row in incomeData.Rows)
        //    {
        //        string month = row["Month"].ToString();
        //        decimal totalIncome = Convert.ToDecimal(row["TotalIncome"]);

        //        series.Points.AddXY(month, totalIncome);
        //    }

        //    chartIncome.Series.Add(series);
        //}


        //----------------------------------------------------------------------------------------------------------


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
            //Login login = new Login();
            //login.ShowDialog();
            //this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        // 
        public decimal GetTotalIncome(DateTime? startDate = null, DateTime? endDate = null)
        {
            string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            decimal totalIncome = 0;


            // SQL query to calculate total income from Sales and SalesDetails
            string query = @"
            SELECT SUM(sd.Quantity * sd.Price) AS TotalIncome
            FROM Sales s
            INNER JOIN SalesDetails sd ON s.SaleID = sd.SaleID
            WHERE 1 = 1"; // Always true to make dynamic filtering easier

            // Add date filters if specified
            if (startDate.HasValue)
            {
                query += " AND s.SaleDate >= @StartDate";
            }
            if (endDate.HasValue)
            {
                query += " AND s.SaleDate <= @EndDate";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters for dynamic date filtering
                        if (startDate.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@StartDate", startDate.Value);
                        }
                        if (endDate.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@EndDate", endDate.Value);
                        }

                        conn.Open();

                        // Execute the query and get the result
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalIncome = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalIncome;
        }

     
    }
}


