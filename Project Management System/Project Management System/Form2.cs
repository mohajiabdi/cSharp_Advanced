﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelRegister.Visible = false;
            txtUser.Focus ();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
            txtNameaniga.Focus();

        }


       

        private void btnGoLogin_Click_1(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelRegister.Visible = false;
            txtUser.Focus();
        }
    }
}
