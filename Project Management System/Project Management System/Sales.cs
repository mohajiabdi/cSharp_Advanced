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
using Microsoft.VisualBasic.ApplicationServices;

namespace Project_Management_System
{
    public partial class Sales : Form
    {

        // Back Field
        string connectionString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
        private decimal totalSaleAmount = 0;
        public Sales()
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

            this.Load += Sales_Load;
            InitializeCartGrid();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            btnSalesMngmt.IconColor = System.Drawing.Color.Coral;
            btnSalesMngmt.ForeColor = System.Drawing.Color.Coral;


            //-----------------------------------------------------------
            txtMedicineName.ReadOnly = true;
            txtPricePerUnit.ReadOnly = true;
            txtTotalPrice.ReadOnly = true;


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
            MessageBox.Show("Its Under Maintenance, We will Fix it Soon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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





        //---------------------------------------------------------------------------------------------------------------------


        // Crud Methods





        //Clear Method
        void ClearMedicineFields()
        {
            txtMedicineID.Text = string.Empty;
            txtCustomerID.Text = string.Empty;
            txtMedicineName.Text = string.Empty;
            txtPricePerUnit.Text = string.Empty;
            txtQuantity.Text = string.Empty;
           // txtTotalPrice.Text = string.Empty;


            txtMedicineID.Focus();
            txtMedicineName.ReadOnly = true;
            txtPricePerUnit.ReadOnly = true;
            txtTotalPrice.ReadOnly = true;
        }

        // Search Medicine Using Id
        private void SearchMedicine(int medicineID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Price, Quantity FROM Medicines WHERE MedicineID = @MedicineID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MedicineID", medicineID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtMedicineName.Text = reader["Name"].ToString();
                    txtPricePerUnit.Text = reader["Price"].ToString();
                }
                else
                {
                    MessageBox.Show("Medicine not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }

            

            //totalSaleAmount = 0;
        }


        // Add Medicine To Cart
        private void AddToCart()
        {
            if (string.IsNullOrWhiteSpace(txtMedicineID.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal pricePerUnit = Convert.ToDecimal(txtPricePerUnit.Text);
            decimal totalPrice = quantity * pricePerUnit;

            dgvCart.Rows.Add(txtMedicineID.Text, txtMedicineName.Text, quantity, pricePerUnit, totalPrice);
            totalSaleAmount += totalPrice;
            txtTotalPrice.Text = totalSaleAmount.ToString("0.00");

            ClearMedicineFields();
        }


        // Remove Medicine from Cart 
        private void RemoveFromCart()
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                decimal rowTotal = Convert.ToDecimal(dgvCart.SelectedRows[0].Cells["TotalPrice"].Value);
                totalSaleAmount -= rowTotal;
                txtTotalPrice.Text = totalSaleAmount.ToString("0.00");

                dgvCart.Rows.RemoveAt(dgvCart.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a row to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearMedicineFields() ;
        }



        //Complete Sale
        private void CompleteSale()
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty! Add items to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Insert Sale
                    string insertSaleQuery = "INSERT INTO Sales (CustomerID, TotalAmount) OUTPUT INSERTED.SaleID VALUES (@CustomerID, @TotalAmount)";
                    SqlCommand saleCommand = new SqlCommand(insertSaleQuery, connection, transaction);
                    saleCommand.Parameters.AddWithValue("@CustomerID", string.IsNullOrWhiteSpace(txtCustomerID.Text) ? (object)DBNull.Value : Convert.ToInt32(txtCustomerID.Text));
                    saleCommand.Parameters.AddWithValue("@TotalAmount", totalSaleAmount);

                    int saleID = (int)saleCommand.ExecuteScalar();

                    // Insert Sale Details
                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        string insertDetailQuery = @"
                    INSERT INTO SalesDetails (SaleID, MedicineID, Quantity, Price) 
                    VALUES (@SaleID, @MedicineID, @Quantity, @Price);
                    UPDATE Medicines SET Quantity = Quantity - @Quantity WHERE MedicineID = @MedicineID";

                        SqlCommand detailCommand = new SqlCommand(insertDetailQuery, connection, transaction);
                        detailCommand.Parameters.AddWithValue("@SaleID", saleID);
                        detailCommand.Parameters.AddWithValue("@MedicineID", Convert.ToInt32(row.Cells["MedicineID"].Value));
                        detailCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells["Quantity"].Value));
                        detailCommand.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells["PricePerUnit"].Value));

                        detailCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvCart.Rows.Clear();
                    txtTotalPrice.Text = "0.00";
                    totalSaleAmount = 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error completing sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ClearMedicineFields();
        }





        private void InitializeCartGrid()
        {
            dgvCart.Columns.Clear(); // Clear existing columns (if any)

            dgvCart.Columns.Add("MedicineID", "Medicine ID");
            dgvCart.Columns.Add("MedicineName", "Medicine Name");
            dgvCart.Columns.Add("Quantity", "Quantity");
            dgvCart.Columns.Add("PricePerUnit", "Price Per Unit");
            dgvCart.Columns.Add("TotalPrice", "Total Price");
        }



        //--------------------------------------------------------------------------------------------------------------------------------





        private void btnSearchMedicine_Click(object sender, EventArgs e)
        {
            int medicineID;
            if (int.TryParse(txtMedicineID.Text, out medicineID))
            {
                SearchMedicine(medicineID);
            }
            else
            {
                MessageBox.Show("Please enter a valid Medicine ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTotalPrice.Text = totalSaleAmount.ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            RemoveFromCart();
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            CompleteSale();
        }

        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicineID.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please fill in Medicine ID and Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int medicineID;
            if (!int.TryParse(txtMedicineID.Text, out medicineID))
            {
                MessageBox.Show("Medicine ID must be a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal pricePerUnit;
            if (!decimal.TryParse(txtPricePerUnit.Text, out pricePerUnit))
            {
                MessageBox.Show("Price must be a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check stock availability from the database
            int availableStock = GetAvailableStock(medicineID);
            if (quantity > availableStock)
            {
                MessageBox.Show($"Not enough stock available! Only {availableStock} left.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalPrice = quantity * pricePerUnit;

            dgvCart.Rows.Add(txtMedicineID.Text, txtMedicineName.Text, quantity, pricePerUnit.ToString("0.00"), totalPrice.ToString("0.00"));
            totalSaleAmount += totalPrice;
            txtTotalPrice.Text = totalSaleAmount.ToString("0.00");

            // Clear input fields
            txtMedicineID.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtMedicineID.Focus();
        }

        // Method to fetch available stock from the database
        private int GetAvailableStock(int medicineID)
        {
            string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";

            int stock = 0;
            //string connectionString = "conString";
            string query = "SELECT Quantity FROM Medicines WHERE MedicineID = @MedicineID";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicineID", medicineID);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            stock = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("No matching medicine found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return stock;
        }



        private void btnRemoveFromCart_Click_1(object sender, EventArgs e)
        {

            if (dgvCart.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgvCart.SelectedRows)
                {
                    decimal rowTotal = Convert.ToDecimal(selectedRow.Cells["TotalPrice"].Value);
                    totalSaleAmount -= rowTotal;
                    txtTotalPrice.Text = totalSaleAmount.ToString("0.00");

                    dgvCart.Rows.RemoveAt(selectedRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompleteSale_Click_1(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty! Add items to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Insert Sale
                    string insertSaleQuery = "INSERT INTO Sales (CustomerID, TotalAmount) OUTPUT INSERTED.SaleID VALUES (@CustomerID, @TotalAmount)";
                    SqlCommand saleCommand = new SqlCommand(insertSaleQuery, connection, transaction);
                    saleCommand.Parameters.AddWithValue("@CustomerID", string.IsNullOrWhiteSpace(txtCustomerID.Text) ? (object)DBNull.Value : Convert.ToInt32(txtCustomerID.Text));
                    saleCommand.Parameters.AddWithValue("@TotalAmount", totalSaleAmount);

                    int saleID = (int)saleCommand.ExecuteScalar();

                    // Insert Sale Details
                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        if (row.Cells["MedicineID"].Value == DBNull.Value ||
                            row.Cells["Quantity"].Value == DBNull.Value ||
                            row.Cells["PricePerUnit"].Value == DBNull.Value)
                        {
                            MessageBox.Show("Invalid data in cart. Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return; // Exit the method if any cell value is invalid
                        }

                        string insertDetailQuery = @"
        INSERT INTO SalesDetails (SaleID, MedicineID, Quantity, Price)
        VALUES (@SaleID, @MedicineID, @Quantity, @Price);
        UPDATE Medicines SET Quantity = Quantity - @Quantity WHERE MedicineID = @MedicineID";

                        using (SqlCommand detailCommand = new SqlCommand(insertDetailQuery, connection, transaction))
                        {
                            detailCommand.Parameters.AddWithValue("@SaleID", saleID);
                            detailCommand.Parameters.AddWithValue("@MedicineID", Convert.ToInt32(row.Cells["MedicineID"].Value));
                            detailCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells["Quantity"].Value));
                            detailCommand.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells["PricePerUnit"].Value));
                            detailCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvCart.Rows.Clear();
                        txtTotalPrice.Text = "0.00";
                        totalSaleAmount = 0;
                        txtMedicineID.Focus();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error completing sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtTotalPrice.Text = string.Empty;
            ClearMedicineFields();
        }

        private void complete()
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty! Add items to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Insert Sale
                    string insertSaleQuery = "INSERT INTO Sales (CustomerID, TotalAmount) OUTPUT INSERTED.SaleID VALUES (@CustomerID, @TotalAmount)";
                    SqlCommand saleCommand = new SqlCommand(insertSaleQuery, connection, transaction);
                    saleCommand.Parameters.AddWithValue("@CustomerID", string.IsNullOrWhiteSpace(txtCustomerID.Text) ? (object)DBNull.Value : Convert.ToInt32(txtCustomerID.Text));
                    saleCommand.Parameters.AddWithValue("@TotalAmount", totalSaleAmount);

                    int saleID = (int)saleCommand.ExecuteScalar();

                    // Insert Sale Details
                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        if (row.Cells["MedicineID"].Value == DBNull.Value ||
                            row.Cells["Quantity"].Value == DBNull.Value ||
                            row.Cells["PricePerUnit"].Value == DBNull.Value)
                        {
                            MessageBox.Show("Invalid data in cart. Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return; // Exit the method if any cell value is invalid
                        }

                        int medicineID = Convert.ToInt32(row.Cells["MedicineID"].Value);
                        int saleQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                        // Check available quantity
                        string checkQuantityQuery = "SELECT Quantity FROM Medicines WHERE MedicineID = @MedicineID";
                        using (SqlCommand checkQuantityCommand = new SqlCommand(checkQuantityQuery, connection, transaction))
                        {
                            checkQuantityCommand.Parameters.AddWithValue("@MedicineID", medicineID);
                            object result = checkQuantityCommand.ExecuteScalar();

                            if (result == null)
                            {
                                MessageBox.Show($"Medicine with ID {medicineID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                return;
                            }

                            int availableQuantity = Convert.ToInt32(result);
                            if (availableQuantity < saleQuantity)
                            {
                                MessageBox.Show($"Not enough stock for Medicine ID {medicineID}. Available: {availableQuantity}, Requested: {saleQuantity}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                return;
                            }
                        }

                        // Insert sale detail and update stock
                        string insertDetailQuery = @"
                INSERT INTO SalesDetails (SaleID, MedicineID, Quantity, Price)
                VALUES (@SaleID, @MedicineID, @Quantity, @Price);
                UPDATE Medicines SET Quantity = Quantity - @Quantity WHERE MedicineID = @MedicineID";

                        using (SqlCommand detailCommand = new SqlCommand(insertDetailQuery, connection, transaction))
                        {
                            detailCommand.Parameters.AddWithValue("@SaleID", saleID);
                            detailCommand.Parameters.AddWithValue("@MedicineID", medicineID);
                            detailCommand.Parameters.AddWithValue("@Quantity", saleQuantity);
                            detailCommand.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells["PricePerUnit"].Value));
                            detailCommand.ExecuteNonQuery();
                        }
                    }

                    // Commit the transaction if everything is successful
                    transaction.Commit();
                    MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear cart and reset fields
                    dgvCart.Rows.Clear();
                    txtTotalPrice.Text = "0.00";
                    totalSaleAmount = 0;
                    txtMedicineID.Focus();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error completing sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtTotalPrice.Text = string.Empty;
            ClearMedicineFields();

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //public decimal GetTotalIncome(DateTime startDate, DateTime endDate)
        //{
        //    string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
        //    decimal totalIncome = 0;

        //    // SQL query to calculate total income from Sales and SalesDetails
        //    string query = @"
        //SELECT SUM(sd.Quantity * sd.Price) AS TotalIncome
        //FROM Sales s
        //INNER JOIN SalesDetails sd ON s.SaleID = sd.SaleID
        //WHERE s.SaleDate >= @StartDate AND s.SaleDate <= @EndDate";

        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(conString))
        //        {
        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                // Add parameters for date filtering
        //                cmd.Parameters.AddWithValue("@StartDate", startDate);
        //                cmd.Parameters.AddWithValue("@EndDate", endDate);

        //                conn.Open();

        //                // Execute the query and get the result
        //                object result = cmd.ExecuteScalar();
        //                if (result != DBNull.Value)
        //                {
        //                    totalIncome = Convert.ToDecimal(result);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    return totalIncome;
        //}

        public decimal GetTotalIncome()
        {
            string conString = "Data Source=DESKTOP-LK1SELP;Database=Pharmacy;Integrated Security=true;";
            decimal totalIncome = 0;


            // SQL query to calculate total income from Sales and SalesDetails
            string query = @"
     SELECT SUM(sd.Quantity * sd.Price) AS TotalIncome
     FROM Sales s
     INNER JOIN SalesDetails sd ON s.SaleID = sd.SaleID"; 

           

            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       

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

        private void btnSearchMngmt_Click(object sender, EventArgs e)
        {
            SearchBtn();
        }
    }
}
