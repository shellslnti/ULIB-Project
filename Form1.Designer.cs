namespace U_LIB_LOGIN
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            loginform = new Panel();
            checkpassword = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            passwordbox = new TextBox();
            passwordtxt = new Label();
            logintxt = new Label();
            emailbox = new TextBox();
            emailtxt = new Label();
            pictureBox1 = new PictureBox();
            welcometxt = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            loginform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginform
            // 
            loginform.BackColor = SystemColors.ButtonHighlight;
            loginform.BorderStyle = BorderStyle.Fixed3D;
            loginform.Controls.Add(label1);
            loginform.Controls.Add(linkLabel1);
            loginform.Controls.Add(checkpassword);
            loginform.Controls.Add(button2);
            loginform.Controls.Add(button1);
            loginform.Controls.Add(passwordbox);
            loginform.Controls.Add(passwordtxt);
            loginform.Controls.Add(logintxt);
            loginform.Controls.Add(emailbox);
            loginform.Controls.Add(emailtxt);
            loginform.Location = new Point(261, 67);
            loginform.Margin = new Padding(4, 3, 4, 3);
            loginform.Name = "loginform";
            loginform.Size = new Size(446, 401);
            loginform.TabIndex = 0;
            loginform.Paint += loginform_Paint;
            // 
            // checkpassword
            // 
            checkpassword.AutoSize = true;
            checkpassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkpassword.ForeColor = SystemColors.ActiveCaptionText;
            checkpassword.Location = new Point(155, 240);
            checkpassword.Name = "checkpassword";
            checkpassword.Size = new Size(148, 29);
            checkpassword.TabIndex = 7;
            checkpassword.Text = "See password";
            checkpassword.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(317, 317);
            button2.Name = "button2";
            button2.Size = new Size(80, 36);
            button2.TabIndex = 6;
            button2.Text = "submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(228, 317);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 5;
            button1.Text = "cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // passwordbox
            // 
            passwordbox.Location = new Point(155, 202);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(242, 32);
            passwordbox.TabIndex = 4;
            passwordbox.TextChanged += passwordbox_TextChanged;
            // 
            // passwordtxt
            // 
            passwordtxt.AutoSize = true;
            passwordtxt.BackColor = Color.Transparent;
            passwordtxt.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtxt.ForeColor = SystemColors.ActiveCaptionText;
            passwordtxt.Location = new Point(37, 207);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(119, 29);
            passwordtxt.TabIndex = 3;
            passwordtxt.Text = "Password";
            // 
            // logintxt
            // 
            logintxt.BackColor = Color.Yellow;
            logintxt.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            logintxt.ForeColor = Color.Purple;
            logintxt.Location = new Point(-2, -2);
            logintxt.Name = "logintxt";
            logintxt.Size = new Size(453, 76);
            logintxt.TabIndex = 2;
            logintxt.Text = "U-LIB LOGIN";
            logintxt.TextAlign = ContentAlignment.MiddleCenter;
            logintxt.Click += label1_Click;
            // 
            // emailbox
            // 
            emailbox.Location = new Point(155, 139);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(242, 32);
            emailbox.TabIndex = 1;
            // 
            // emailtxt
            // 
            emailtxt.AutoSize = true;
            emailtxt.BackColor = Color.Transparent;
            emailtxt.Font = new Font("Bahnschrift Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxt.ForeColor = SystemColors.ActiveCaptionText;
            emailtxt.Location = new Point(37, 138);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(124, 29);
            emailtxt.TabIndex = 0;
            emailtxt.Text = "Username";
            emailtxt.Click += emailtxt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(266, 5);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // welcometxt
            // 
            welcometxt.AutoSize = true;
            welcometxt.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            welcometxt.Location = new Point(324, 9);
            welcometxt.Margin = new Padding(4, 0, 4, 0);
            welcometxt.Name = "welcometxt";
            welcometxt.Size = new Size(383, 43);
            welcometxt.TabIndex = 2;
            welcometxt.Text = "WELCOME TO U-LIB";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Calibri", 6F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(118, 374);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 14);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create One!!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 374);
            label1.Name = "label1";
            label1.Size = new Size(118, 13);
            label1.TabIndex = 9;
            label1.Text = "Don't have an account?";
            label1.Click += label1_Click_1;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(950, 500);
            Controls.Add(pictureBox1);
            Controls.Add(welcometxt);
            Controls.Add(loginform);
            Font = new Font("Lucida Handwriting", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "U-LIB LOGIN";
            Load += Form1_Load;
            loginform.ResumeLayout(false);
            loginform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginform;
        private PictureBox pictureBox1;
        private Label welcometxt;
        private Label emailtxt;
        private TextBox emailbox;
        private Label logintxt;
        private Label passwordtxt;
        private TextBox passwordbox;
        private Button button2;
        private Button button1;
        private CheckBox checkpassword;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}