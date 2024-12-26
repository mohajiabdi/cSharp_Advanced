namespace Project_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenue = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogoutMngmt = new FontAwesome.Sharp.IconButton();
            this.btnSettingsMngmt = new FontAwesome.Sharp.IconButton();
            this.btnSearchMngmt = new FontAwesome.Sharp.IconButton();
            this.btnReportMngmt = new FontAwesome.Sharp.IconButton();
            this.btnSalesMngmt = new FontAwesome.Sharp.IconButton();
            this.btnCustomerMngmt = new FontAwesome.Sharp.IconButton();
            this.btnMedicineMngmt = new FontAwesome.Sharp.IconButton();
            this.btnDashboardMngmt = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dashboardDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.panelMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Coral;
            this.lblTitle.Location = new System.Drawing.Point(238, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 43);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Dashboard";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1275, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 27;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1317, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 26;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
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
            this.panelMenue.TabIndex = 25;
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
            // dashboardDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dashboardDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dashboardDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dashboardDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dashboardDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dashboardDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dashboardDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dashboardDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dashboardDataGridView.ColumnHeadersHeight = 25;
            this.dashboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dashboardDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dashboardDataGridView.EnableHeadersVisualStyles = false;
            this.dashboardDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dashboardDataGridView.Location = new System.Drawing.Point(249, 437);
            this.dashboardDataGridView.Name = "dashboardDataGridView";
            this.dashboardDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dashboardDataGridView.RowHeadersVisible = false;
            this.dashboardDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dashboardDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dashboardDataGridView.Size = new System.Drawing.Size(1082, 305);
            this.dashboardDataGridView.TabIndex = 29;
            this.dashboardDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.dashboardDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dashboardDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dashboardDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dashboardDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dashboardDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dashboardDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dashboardDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dashboardDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dashboardDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dashboardDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dashboardDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dashboardDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dashboardDataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.dashboardDataGridView.ThemeStyle.ReadOnly = false;
            this.dashboardDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dashboardDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dashboardDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dashboardDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dashboardDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.dashboardDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dashboardDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.dashboardDataGridView);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.panelMenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelMenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLogoutMngmt;
        private FontAwesome.Sharp.IconButton btnSearchMngmt;
        private FontAwesome.Sharp.IconButton btnReportMngmt;
        private FontAwesome.Sharp.IconButton btnSalesMngmt;
        private FontAwesome.Sharp.IconButton btnSettingsMngmt;
        private FontAwesome.Sharp.IconButton btnCustomerMngmt;
        private FontAwesome.Sharp.IconButton btnMedicineMngmt;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton btnDashboardMngmt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelMenue;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dashboardDataGridView;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private LiveCharts.Wpf.CartesianChart cartesianChart2;
    }
}