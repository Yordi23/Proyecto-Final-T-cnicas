﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Tecnicas
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormLoginEstudiante form4 = new FormLoginEstudiante();
            formMain form1 = new formMain();
            {
                this.Hide();
                form4.ShowDialog();
                this.Show();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormLoginMaestro form5 = new FormLoginMaestro();
            formMain form1 = new formMain();
            {
                this.Hide();
                form5.ShowDialog();
                this.Show();

            }
        }
    }
}
