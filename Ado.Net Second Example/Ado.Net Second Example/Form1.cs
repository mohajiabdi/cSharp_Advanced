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
using System.Data.SqlClient;

namespace Ado.Net_Second_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //string conString = "Server = DESKTOP-LK1SELP\\SQL EXPRESS; Database = Bank; Integrated Security = True";
            string conString = "Data Source=DESKTOP-LK1SELP; Database=Bank; Integrated Security=True";


            // Using block ensures the connection is properly closed and disposed
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    // Open the connection
                    con.Open();
                    string query = "Select * from Customer";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error" + ex.Message);

                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
