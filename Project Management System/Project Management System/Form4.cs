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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }


        private void Getreport(string value = "")
        {
            string conString = "Data Source=DESKTOP-LK1SELP; Database=Pharmacy; Integrated Security=True";
           
            string query = "";
            if (value == "")
                query = "select * from Customers";
            else
                query = "select * from Customers where CustomerName like '%" + value + "%'";

            using (SqlDataAdapter Da = new SqlDataAdapter(query, conString))
            {
                try
                {
                    DataSet Ds = new DataSet();
                    Da.Fill(Ds, "Customers");
                    ReportDataSource source = new ReportDataSource("DataSet2", Ds.Tables[0]);
                    string reportPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                        "C:\\Users\\RAQIIS COMPUTER\\Documents\\GitHub\\Coding-Zone\\cSharp_Advanced\\Project Management System\\Project Management System\\Report1.rdlc");
                    reportViewer1.LocalReport.ReportPath = reportPath;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(source);
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error", ex.Message);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Getreport();
        }
    }
}
