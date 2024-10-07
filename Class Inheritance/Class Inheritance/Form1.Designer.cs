namespace Class_Inheritance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            txtDrive = new TextBox();
            label12 = new Label();
            txtPassengers = new TextBox();
            label11 = new Label();
            txtDoors = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtModel = new TextBox();
            label3 = new Label();
            txtMileage = new TextBox();
            label2 = new Label();
            txtMake = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            lblObject = new Label();
            label16 = new Label();
            label14 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblPassengers = new Label();
            lblDrive = new Label();
            lblDoors = new Label();
            lblPrice = new Label();
            lblModel = new Label();
            lblMake = new Label();
            lblMileage = new Label();
            label10 = new Label();
            btnCreateObject = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtDrive);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtPassengers);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDoors);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMileage);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMake);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(43, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 571);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Car Data";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Car", "Truck ", "BL" });
            comboBox1.Location = new Point(241, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtDrive
            // 
            txtDrive.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDrive.Location = new Point(178, 420);
            txtDrive.Name = "txtDrive";
            txtDrive.Size = new Size(292, 47);
            txtDrive.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(18, 426);
            label12.Name = "label12";
            label12.Size = new Size(83, 38);
            label12.TabIndex = 2;
            label12.Text = "Drive";
            // 
            // txtPassengers
            // 
            txtPassengers.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassengers.Location = new Point(178, 492);
            txtPassengers.Name = "txtPassengers";
            txtPassengers.Size = new Size(292, 47);
            txtPassengers.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(18, 498);
            label11.Name = "label11";
            label11.Size = new Size(156, 38);
            label11.TabIndex = 2;
            label11.Text = "Passengers";
            // 
            // txtDoors
            // 
            txtDoors.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDoors.Location = new Point(178, 348);
            txtDoors.Name = "txtDoors";
            txtDoors.Size = new Size(292, 47);
            txtDoors.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 354);
            label5.Name = "label5";
            label5.Size = new Size(93, 38);
            label5.TabIndex = 2;
            label5.Text = "Doors";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(178, 281);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(292, 47);
            txtPrice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 287);
            label4.Name = "label4";
            label4.Size = new Size(78, 38);
            label4.TabIndex = 2;
            label4.Text = "Price";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtModel.Location = new Point(181, 153);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(292, 47);
            txtModel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 159);
            label3.Name = "label3";
            label3.Size = new Size(99, 38);
            label3.TabIndex = 2;
            label3.Text = "Model";
            // 
            // txtMileage
            // 
            txtMileage.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMileage.Location = new Point(178, 218);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(292, 47);
            txtMileage.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 224);
            label2.Name = "label2";
            label2.Size = new Size(119, 38);
            label2.TabIndex = 2;
            label2.Text = "Mileage";
            // 
            // txtMake
            // 
            txtMake.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMake.Location = new Point(181, 91);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(292, 47);
            txtMake.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 97);
            label1.Name = "label1";
            label1.Size = new Size(96, 38);
            label1.TabIndex = 0;
            label1.Text = "Make ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblObject);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(lblPassengers);
            groupBox2.Controls.Add(lblDrive);
            groupBox2.Controls.Add(lblDoors);
            groupBox2.Controls.Add(lblPrice);
            groupBox2.Controls.Add(lblModel);
            groupBox2.Controls.Add(lblMake);
            groupBox2.Controls.Add(lblMileage);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(595, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 571);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Object Property";
            // 
            // lblObject
            // 
            lblObject.BorderStyle = BorderStyle.Fixed3D;
            lblObject.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObject.Location = new Point(280, 23);
            lblObject.Name = "lblObject";
            lblObject.Size = new Size(118, 36);
            lblObject.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(18, 493);
            label16.Name = "label16";
            label16.Size = new Size(156, 38);
            label16.TabIndex = 2;
            label16.Text = "Passengers";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(18, 421);
            label14.Name = "label14";
            label14.Size = new Size(83, 38);
            label14.TabIndex = 2;
            label14.Text = "Drive";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 349);
            label6.Name = "label6";
            label6.Size = new Size(93, 38);
            label6.TabIndex = 2;
            label6.Text = "Doors";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 282);
            label7.Name = "label7";
            label7.Size = new Size(78, 38);
            label7.TabIndex = 2;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 154);
            label8.Name = "label8";
            label8.Size = new Size(99, 38);
            label8.TabIndex = 2;
            label8.Text = "Model";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 219);
            label9.Name = "label9";
            label9.Size = new Size(119, 38);
            label9.TabIndex = 2;
            label9.Text = "Mileage";
            // 
            // lblPassengers
            // 
            lblPassengers.BorderStyle = BorderStyle.FixedSingle;
            lblPassengers.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassengers.Location = new Point(180, 493);
            lblPassengers.Name = "lblPassengers";
            lblPassengers.Size = new Size(299, 47);
            lblPassengers.TabIndex = 0;
            // 
            // lblDrive
            // 
            lblDrive.BorderStyle = BorderStyle.FixedSingle;
            lblDrive.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrive.Location = new Point(180, 421);
            lblDrive.Name = "lblDrive";
            lblDrive.Size = new Size(299, 47);
            lblDrive.TabIndex = 0;
            // 
            // lblDoors
            // 
            lblDoors.BorderStyle = BorderStyle.FixedSingle;
            lblDoors.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoors.Location = new Point(180, 349);
            lblDoors.Name = "lblDoors";
            lblDoors.Size = new Size(299, 47);
            lblDoors.TabIndex = 0;
            // 
            // lblPrice
            // 
            lblPrice.BorderStyle = BorderStyle.FixedSingle;
            lblPrice.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(180, 281);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(299, 47);
            lblPrice.TabIndex = 0;
            // 
            // lblModel
            // 
            lblModel.BorderStyle = BorderStyle.FixedSingle;
            lblModel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModel.Location = new Point(180, 153);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(299, 47);
            lblModel.TabIndex = 0;
            // 
            // lblMake
            // 
            lblMake.BorderStyle = BorderStyle.FixedSingle;
            lblMake.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMake.Location = new Point(180, 86);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(299, 47);
            lblMake.TabIndex = 0;
            // 
            // lblMileage
            // 
            lblMileage.BorderStyle = BorderStyle.FixedSingle;
            lblMileage.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMileage.Location = new Point(180, 219);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(299, 47);
            lblMileage.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 92);
            label10.Name = "label10";
            label10.Size = new Size(96, 38);
            label10.TabIndex = 0;
            label10.Text = "Make ";
            // 
            // btnCreateObject
            // 
            btnCreateObject.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateObject.Location = new Point(150, 633);
            btnCreateObject.Name = "btnCreateObject";
            btnCreateObject.Size = new Size(245, 83);
            btnCreateObject.TabIndex = 1;
            btnCreateObject.Text = "Create Object";
            btnCreateObject.UseVisualStyleBackColor = true;
            btnCreateObject.Click += btnCreateObject_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(698, 633);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(245, 83);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 728);
            Controls.Add(btnExit);
            Controls.Add(btnCreateObject);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Car Demo";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDoors;
        private Label label5;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtMileage;
        private Label label2;
        private TextBox txtMake;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblMileage;
        private Label label10;
        private Label lblDoors;
        private Label lblPrice;
        private Label lblModel;
        private Label lblMake;
        private Button btnCreateObject;
        private Button btnExit;
        private TextBox txtDrive;
        private Label label12;
        private TextBox txtPassengers;
        private Label label11;
        private Label label16;
        private Label label14;
        private Label lblPassengers;
        private Label lblDrive;
        private ComboBox comboBox1;
        private Label lblObject;
    }
}
