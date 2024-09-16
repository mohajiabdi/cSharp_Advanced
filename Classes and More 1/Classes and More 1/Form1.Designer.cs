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
            btnToss = new Button();
            listBox1 = new ListBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnToss
            // 
            btnToss.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToss.Location = new Point(12, 294);
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
            listBox1.Size = new Size(368, 256);
            listBox1.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(236, 294);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 68);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 418);
            Controls.Add(btnClear);
            Controls.Add(listBox1);
            Controls.Add(btnToss);
            Name = "Form1";
            Text = "Toss Head Or Tail";
            ResumeLayout(false);
        }

        #endregion

        private Button btnToss;
        private ListBox listBox1;
        private Button btnClear;
    }
}
