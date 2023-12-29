namespace AUDAKE_UNIVERSITY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2();
            register.Show();
            this.Hide();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
    }
}
