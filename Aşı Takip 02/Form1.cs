namespace Aşı_Takip_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "SamSam" && textBox2.Text == "12345" && radioButton1.Checked)
            {
                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
            }
            else if (!radioButton1.Checked)
            {
                MessageBox.Show("Robot Tespit Edildi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya sifre hatalıdır.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Console.CapsLock == true)
            {
                lblCapsLock.Text = "Caps Lock Açık";
                lblCapsLock.ForeColor = Color.Green;
            }
            else
            {
                lblCapsLock.Text = "Caps Lock Kapalı";
                lblCapsLock.ForeColor = Color.Red;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Console.CapsLock == true)
            {
                lblCapsLock.Text = "Caps Lock Açık";
                lblCapsLock.ForeColor = Color.Green;
            }
            else
            {
                lblCapsLock.Text = "Caps Lock Kapalı";
                lblCapsLock.ForeColor = Color.Red;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
