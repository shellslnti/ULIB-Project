namespace U_LIB_LOGIN
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel4 = new Panel();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button8 = new Button();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            welcometxt = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkMagenta;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 500);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Cari buku";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(247, 20);
            button1.Name = "button1";
            button1.Size = new Size(50, 22);
            button1.TabIndex = 1;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(welcometxt);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(202, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 60);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(202, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(748, 440);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 50);
            button2.Name = "button2";
            button2.Size = new Size(202, 45);
            button2.TabIndex = 0;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 188);
            button3.Name = "button3";
            button3.Size = new Size(202, 45);
            button3.TabIndex = 1;
            button3.Text = "Pengembalian";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 141);
            button4.Name = "button4";
            button4.Size = new Size(202, 45);
            button4.TabIndex = 2;
            button4.Text = "Peminjaman";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 440);
            panel4.Name = "panel4";
            panel4.Size = new Size(202, 60);
            panel4.TabIndex = 3;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(202, 60);
            button5.TabIndex = 0;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 239);
            button6.Name = "button6";
            button6.Size = new Size(199, 45);
            button6.TabIndex = 4;
            button6.Text = "Aturan Perpustakaan";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 290);
            button7.Name = "button7";
            button7.Size = new Size(202, 45);
            button7.TabIndex = 5;
            button7.Text = "Pengaturan";
            button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 66);
            label1.Name = "label1";
            label1.Size = new Size(10, 21);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 157);
            label2.Name = "label2";
            label2.Size = new Size(10, 21);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonFace;
            label3.Location = new Point(0, 204);
            label3.Name = "label3";
            label3.Size = new Size(10, 21);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonFace;
            label4.Location = new Point(0, 255);
            label4.Name = "label4";
            label4.Size = new Size(10, 21);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ButtonFace;
            label5.Location = new Point(0, 306);
            label5.Name = "label5";
            label5.Size = new Size(10, 21);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 6);
            label6.Name = "label6";
            label6.Size = new Size(289, 45);
            label6.TabIndex = 0;
            label6.Text = "Rekomendasi Buku";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 195);
            label7.Name = "label7";
            label7.Size = new Size(205, 45);
            label7.TabIndex = 1;
            label7.Text = "Buku Terbaru";
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(0, 99);
            button8.Name = "button8";
            button8.Size = new Size(202, 45);
            button8.TabIndex = 11;
            button8.Text = "Kategori Buku";
            button8.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ButtonFace;
            label8.Location = new Point(0, 113);
            label8.Name = "label8";
            label8.Size = new Size(10, 21);
            label8.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(595, 7);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // welcometxt
            // 
            welcometxt.AutoSize = true;
            welcometxt.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            welcometxt.Location = new Point(645, 17);
            welcometxt.Margin = new Padding(4, 0, 4, 0);
            welcometxt.Name = "welcometxt";
            welcometxt.Size = new Size(83, 29);
            welcometxt.TabIndex = 4;
            welcometxt.Text = "U-LIB";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(-14, 222);
            label9.Name = "label9";
            label9.Size = new Size(891, 45);
            label9.TabIndex = 2;
            label9.Text = "___________________________________________________________________";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(-48, 17);
            label10.Name = "label10";
            label10.Size = new Size(891, 45);
            label10.TabIndex = 3;
            label10.Text = "___________________________________________________________________";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 500);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private Panel panel4;
        private Button button5;
        private Button button7;
        private Button button6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button8;
        private PictureBox pictureBox1;
        private Label welcometxt;
        private Label label9;
        private Label label10;
    }
}