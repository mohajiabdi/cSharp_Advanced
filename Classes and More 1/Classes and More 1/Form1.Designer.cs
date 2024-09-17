namespace Classes_and_More_1
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
            btnToss = new Button();
            listBox1 = new ListBox();
            btnClear = new Button();
            btnShow = new Button();
            picCoinHead = new PictureBox();
            picCoinTail = new PictureBox();
            btnTossCoin = new Button();
            ((System.ComponentModel.ISupportInitialize)picCoinHead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCoinTail).BeginInit();
            SuspendLayout();
            // 
            // btnToss
            // 
            btnToss.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToss.Location = new Point(12, 372);
            btnToss.Name = "btnToss";
            btnToss.Size = new Size(142, 68);
            btnToss.TabIndex = 0;
            btnToss.Text = "Toss";
            btnToss.UseVisualStyleBackColor = true;
            btnToss.Click += btnToss_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(454, 340);
            listBox1.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(324, 372);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 68);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnExit_Click;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(167, 372);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(142, 68);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // picCoinHead
            // 
            picCoinHead.Image = (Image)resources.GetObject("picCoinHead.Image");
            picCoinHead.Location = new Point(536, 12);
            picCoinHead.Name = "picCoinHead";
            picCoinHead.Size = new Size(351, 340);
            picCoinHead.SizeMode = PictureBoxSizeMode.Zoom;
            picCoinHead.TabIndex = 4;
            picCoinHead.TabStop = false;
            // 
            // picCoinTail
            // 
            picCoinTail.Image = (Image)resources.GetObject("picCoinTail.Image");
            picCoinTail.Location = new Point(536, 12);
            picCoinTail.Name = "picCoinTail";
            picCoinTail.Size = new Size(351, 340);
            picCoinTail.SizeMode = PictureBoxSizeMode.Zoom;
            picCoinTail.TabIndex = 5;
            picCoinTail.TabStop = false;
            // 
            // btnTossCoin
            // 
            btnTossCoin.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTossCoin.Location = new Point(563, 367);
            btnTossCoin.Name = "btnTossCoin";
            btnTossCoin.Size = new Size(300, 73);
            btnTossCoin.TabIndex = 6;
            btnTossCoin.Text = "Toss Coin ";
            btnTossCoin.UseVisualStyleBackColor = true;
            btnTossCoin.Click += btnTossCoin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 513);
            Controls.Add(btnTossCoin);
            Controls.Add(picCoinTail);
            Controls.Add(picCoinHead);
            Controls.Add(btnShow);
            Controls.Add(btnClear);
            Controls.Add(listBox1);
            Controls.Add(btnToss);
            Name = "Form1";
            Text = "Toss Head Or Tail";
            ((System.ComponentModel.ISupportInitialize)picCoinHead).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCoinTail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnToss;
        private ListBox listBox1;
        private Button btnClear;
        private Button btnShow;
        private PictureBox picCoinHead;
        private PictureBox picCoinTail;
        private Button btnTossCoin;
    }
}
