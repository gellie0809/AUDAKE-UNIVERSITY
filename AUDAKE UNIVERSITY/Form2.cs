using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUDAKE_UNIVERSITY
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Form1 log_in = new Form1();
            log_in.Show();
            this.Hide();

        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            string message = "Sign in succesfully!";
            string title = "Audake University Confirmation";
            MessageBox.Show(message, title);

            Form1 log_in = new Form1();
            log_in.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
