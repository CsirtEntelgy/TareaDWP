﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentista
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_inicioSesion_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form5 v1 = new Form5();
            v1.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
