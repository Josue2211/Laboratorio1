﻿using LaboratorioProgramacionUno.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmLoguin frm = new FrmLoguin();
            frm.Show();
        }

        private void txtAdministrador_Click(object sender, EventArgs e)
        {

        }
    }
}
