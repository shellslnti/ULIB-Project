namespace U_LIB_LOGIN
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emailtxt_Click(object sender, EventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            passwordbox.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hide
            this.Hide();
            //sambung form2
            Form2 f2 = new Form2();
            //show f2
            f2.ShowDialog();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}