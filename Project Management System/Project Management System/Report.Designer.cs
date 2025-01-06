namespace Project_Management_System
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelMenue = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogoutMngmt = new FontAwesome.Sharp.IconButton();
            this.btnSettingsMngmt = new FontAwesome.Sharp.IconButton();
            this.btnSearchMngmt = new FontAwesome.Sharp.IconButton();
            this.btnReportMngmt = new FontAwesome.Sharp.IconButton();
            this.btnSalesMngmt = new FontAwesome.Sharp.IconButton();
            this.btnCustomerMngmt = new FontAwesome.Sharp.IconButton();
            this.btnMedicineMngmt = new FontAwesome.Sharp.IconButton();
            this.btnDashboardMngmt = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboChoose = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pharmacyDataSet3 = new Project_Management_System.PharmacyDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMenue.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelMenue
            // 
            this.panelMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.panelMenue.Controls.Add(this.btnLogoutMngmt);
            this.panelMenue.Controls.Add(this.btnSettingsMngmt);
            this.panelMenue.Controls.Add(this.btnSearchMngmt);
            this.panelMenue.Controls.Add(this.btnReportMngmt);
            this.panelMenue.Controls.Add(this.btnSalesMngmt);
            this.panelMenue.Controls.Add(this.btnCustomerMngmt);
            this.panelMenue.Controls.Add(this.btnMedicineMngmt);
            this.panelMenue.Controls.Add(this.btnDashboardMngmt);
            this.panelMenue.Controls.Add(this.guna2Panel1);
            this.panelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenue.Location = new System.Drawing.Point(0, 0);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.ShadowDecoration.Parent = this.panelMenue;
            this.panelMenue.Size = new System.Drawing.Size(220, 768);
            this.panelMenue.TabIndex = 22;
            // 
            // btnLogoutMngmt
            // 
            this.btnLogoutMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutMngmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogoutMngmt.FlatAppearance.BorderSize = 0;
            this.btnLogoutMngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutMngmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutMngmt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogoutMngmt.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogoutMngmt.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogoutMngmt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogoutMngmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoutMngmt.Location = new System.Drawing.Point(0, 684);
            this.btnLogoutMngmt.Name = "btnLogoutMngmt";
            this.btnLogoutMngmt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogoutMngmt.Size = new System.Drawing.Size(220, 80);
            this.btnLogoutMngmt.TabIndex = 11;
            this.btnLogoutMngmt.Text = "Log Out";
            this.btnLogoutMngmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoutMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogoutMngmt.UseVisualStyleBackColor = true;
            this.btnLogoutMngmt.Click += new System.EventHandler(this.btnLogoutMngmt_Click);
            // 
            // btnSettingsMngmt
            // 
            this.btnSettingsMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsMngmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettingsMngmt.FlatAppearance.BorderSize = 0;
            this.btnSettingsMngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsMngmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsMngmt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettingsMngmt.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btnSettingsMngmt.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettingsMngmt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettingsMngmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsMngmt.Location = new System.Drawing.Point(0, 604);
            this.btnSettingsMngmt.Name = "btnSettingsMngmt";
            this.btnSettingsMngmt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSettingsMngmt.Size = new System.Drawing.Size(220, 80);
            this.btnSettingsMngmt.TabIndex = 10;
            this.btnSettingsMngmt.Text = "Settings";
            this.btnSettingsMngmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettingsMngmt.UseVisualStyleBackColor = true;
            this.btnSettingsMngmt.Click += new System.EventHandler(this.btnSettingsMngmt_Click);
            // 
            // btnSearchMngmt
            // 
            this.btnSearchMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMngmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchMngmt.FlatAppearance.BorderSize = 0;
            this.btnSearchMngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMngmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMngmt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchMngmt.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchMngmt.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchMngmt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchMngmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMngmt.Location = new System.Drawing.Point(0, 524);
            this.btnSearchMngmt.Name = "btnSearchMngmt";
            this.btnSearchMngmt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearchMngmt.Size = new System.Drawing.Size(220, 80);
            this.btnSearchMngmt.TabIndex = 9;
            this.btnSearchMngmt.Text = "Search and Filter";
            this.btnSearchMngmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchMngmt.UseVisualStyleBackColor = true;
            this.btnSearchMngmt.Click += new System.EventHandler(this.btnSearchMngmt_Click);
            // 
            // btnReportMngmt
            // 
            this.btnReportMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportMngmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportMngmt.FlatAppearance.BorderSize = 0;
            this.btnReportMngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportMngmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMngmt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReportMngmt.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassChart;
            this.btnReportMngmt.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnReportMngmt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportMngmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportMngmt.Location = new System.Drawing.Point(0, 444);
            this.btnReportMngmt.Name = "btnReportMngmt";
            this.btnReportMngmt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportMngmt.Size = new System.Drawing.Size(220, 80);
            this.btnReportMngmt.TabIndex = 8;
            this.btnReportMngmt.Text = "Report";
            this.btnReportMngmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportMngmt.UseVisualStyleBackColor = true;
            this.btnReportMngmt.Click += new System.EventHandler(this.btnReportMngmt_Click);
            // 
            // btnSalesMngmt
            // 
            this.btnSalesMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesMngmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesMngmt.FlatAppearance.BorderSize = 0;
            this.btnSalesMngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesMngmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesMngmt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesMngmt.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btnSalesMngmt.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesMngmt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalesMngmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesMngmt.Location = new System.Drawing.Point(0, 364);
            this.btnSalesMngmt.Name = "btnSalesMngmt";
            this.btnSalesMngmt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalesMngmt.Size = new System.Drawing.Size(220, 80);
            this.btnSalesMngmt.TabIndex = 7;
            this.btnSalesMngmt.Text = "Sales Management";
            this.btnSalesMngmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesMngmt.UseVisualStyleBackColor = true;
            this.btnSalesMngmt.Click += new System.EventHandler(this.btnSalesMngmt_Click);
            // 
            // btnCustomerMngmt
            // 
            this.btnCustomerMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerMngmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerMngmt.FlatAppearance.BorderSize = 0;
            this.btnCustomerMngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerMngmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerMngmt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomerMngmt.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnCustomerMngmt.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomerMngmt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomerMngmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerMngmt.Location = new System.Drawing.Point(0, 284);
            this.btnCustomerMngmt.Name = "btnCustomerMngmt";
            this.btnCustomerMngmt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCustomerMngmt.Size = new System.Drawing.Size(220, 80);
            this.btnCustomerMngmt.TabIndex = 5;
            this.btnCustomerMngmt.Text = "Customers";
            this.btnCustomerMngmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerMngmt.UseVisualStyleBackColor = true;
            this.btnCustomerMngmt.Click += new System.EventHandler(this.btnCustomerMngmt_Click);
            // 
            // btnMedicineMngmt
            // 
            this.btnMedicineMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicineMngmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicineMngmt.FlatAppearance.BorderSize = 0;
            this.btnMedicineMngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicineMngmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineMngmt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicineMngmt.IconChar = FontAwesome.Sharp.IconChar.Capsules;
            this.btnMedicineMngmt.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicineMngmt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMedicineMngmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicineMngmt.Location = new System.Drawing.Point(0, 204);
            this.btnMedicineMngmt.Name = "btnMedicineMngmt";
            this.btnMedicineMngmt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMedicineMngmt.Size = new System.Drawing.Size(220, 80);
            this.btnMedicineMngmt.TabIndex = 2;
            this.btnMedicineMngmt.Text = "Medicine";
            this.btnMedicineMngmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicineMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicineMngmt.UseVisualStyleBackColor = true;
            this.btnMedicineMngmt.Click += new System.EventHandler(this.btnMedicineMngmt_Click);
            // 
            // btnDashboardMngmt
            // 
            this.btnDashboardMngmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboardMngmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboardMngmt.FlatAppearance.BorderSize = 0;
            this.btnDashboardMngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardMngmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardMngmt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboardMngmt.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnDashboardMngmt.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboardMngmt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboardMngmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardMngmt.Location = new System.Drawing.Point(0, 124);
            this.btnDashboardMngmt.Name = "btnDashboardMngmt";
            this.btnDashboardMngmt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboardMngmt.Size = new System.Drawing.Size(220, 80);
            this.btnDashboardMngmt.TabIndex = 1;
            this.btnDashboardMngmt.Text = "Dashboard";
            this.btnDashboardMngmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboardMngmt.UseVisualStyleBackColor = true;
            this.btnDashboardMngmt.Click += new System.EventHandler(this.btnDashboardMngmt_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.button1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(220, 124);
            this.guna2Panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(220, 126);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hobyo Pharmacy";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Coral;
            this.lblTitle.Location = new System.Drawing.Point(230, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 43);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Report";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1272, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 24;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1314, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 23;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.txtSearch);
            this.guna2ShadowPanel1.Controls.Add(this.btnSearch);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2ShadowPanel1.Controls.Add(this.lblInfo);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2ShadowPanel1.Controls.Add(this.comboChoose);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(252, 107);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel1.ShadowShift = 7;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1082, 160);
            this.guna2ShadowPanel1.TabIndex = 27;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(501, 76);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Full Name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(292, 36);
            this.txtSearch.TabIndex = 56;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(843, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(132, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Roboto Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(378, 15);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(252, 32);
            this.guna2HtmlLabel8.TabIndex = 55;
            this.guna2HtmlLabel8.Text = "Search and Filter Data";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Roboto Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(362, 81);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(41, 30);
            this.lblInfo.TabIndex = 51;
            this.lblInfo.Text = "hey";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Roboto Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(29, 76);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(95, 30);
            this.guna2HtmlLabel2.TabIndex = 41;
            this.guna2HtmlLabel2.Text = "Choose : ";
            // 
            // comboChoose
            // 
            this.comboChoose.BackColor = System.Drawing.Color.Transparent;
            this.comboChoose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChoose.FocusedColor = System.Drawing.Color.Empty;
            this.comboChoose.FocusedState.Parent = this.comboChoose;
            this.comboChoose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboChoose.FormattingEnabled = true;
            this.comboChoose.HoverState.Parent = this.comboChoose;
            this.comboChoose.ItemHeight = 30;
            this.comboChoose.Items.AddRange(new object[] {
            "Customer",
            "Medicine",
            "Sales",
            "SalesDetails"});
            this.comboChoose.ItemsAppearance.Parent = this.comboChoose;
            this.comboChoose.Location = new System.Drawing.Point(137, 76);
            this.comboChoose.Name = "comboChoose";
            this.comboChoose.ShadowDecoration.Parent = this.comboChoose;
            this.comboChoose.Size = new System.Drawing.Size(200, 36);
            this.comboChoose.TabIndex = 0;
            this.comboChoose.SelectedIndexChanged += new System.EventHandler(this.comboChoose_SelectedIndexChanged);
            // 
            // pharmacyDataSet3
            // 
            this.pharmacyDataSet3.DataSetName = "PharmacyDataSet3";
            this.pharmacyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pharmacyDataSet3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project_Management_System.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(263, 325);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(998, 402);
            this.reportViewer1.TabIndex = 28;
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers";
            this.CustomersBindingSource.DataSource = this.pharmacyDataSet3;
            // 
            // pharmacyDataSet3BindingSource
            // 
            this.pharmacyDataSet3BindingSource.DataSource = this.pharmacyDataSet3;
            this.pharmacyDataSet3BindingSource.Position = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panelMenue);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panelMenue.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelMenue;
        private FontAwesome.Sharp.IconButton btnLogoutMngmt;
        private FontAwesome.Sharp.IconButton btnSettingsMngmt;
        private FontAwesome.Sharp.IconButton btnSearchMngmt;
        private FontAwesome.Sharp.IconButton btnReportMngmt;
        private FontAwesome.Sharp.IconButton btnSalesMngmt;
        private FontAwesome.Sharp.IconButton btnCustomerMngmt;
        private FontAwesome.Sharp.IconButton btnMedicineMngmt;
        private FontAwesome.Sharp.IconButton btnDashboardMngmt;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox comboChoose;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private PharmacyDataSet3 pharmacyDataSet3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private System.Windows.Forms.BindingSource pharmacyDataSet3BindingSource;
    }
}