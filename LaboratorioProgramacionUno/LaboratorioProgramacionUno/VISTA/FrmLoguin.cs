using LaboratorioProgramacionUno.DOMINIO;
using LaboratorioProgramacionUno.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno.VISTA
{
    public partial class FrmLoguin : Form
    {
        public FrmLoguin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Login log = new Login();

            log.Usuario = txtNombreUsuario.Text;
            log.Password = txtContraseña.Text;
            ClsLogin clsL = new ClsLogin();

            int variabledeevaluacion = clsL.acceso(log);

            if (variabledeevaluacion == 1)
            {

                MessageBox.Show("Bienvenido");
                FrmOperaciones frm = new FrmOperaciones();
                frm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Error");
            }

        }

        private void FrmLoguin_Load(object sender, EventArgs e)
        {

        }
    }
}
