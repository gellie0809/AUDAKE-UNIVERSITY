﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 logmein = new Form1();
            logmein.Show();
            this.Hide();

        }
    }
}
