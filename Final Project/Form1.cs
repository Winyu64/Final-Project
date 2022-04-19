namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox2.Text == "0")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("กรุณาใส่ Usename และ Password ให้ถูกต้อง");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ปิดการทำงาน");
            Close();
        }
    }
}