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
        public int tipoUsuario;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Login log = new Login();
            ClsLogin cls = new ClsLogin();

            log.Usuario = txtNombreUsuario.Text;
            log.Password = txtContraseña.Text;
            

            Boolean acceso = cls.acceso(log);

            if (acceso == true) {
                if (tipoUsuario == 0)
                {
                    if (txtNombreUsuario.Text == "Carlos")
                    {
                        MessageBox.Show("Acceso permitido" , "" + txtNombreUsuario.Text);
                        FrmOpera frm = new FrmOpera();
                        frm.textBox_nombreproducto.Text = "LAPTOP";
                        frm.textBox_nombreproducto.Enabled = false;
                        frm.txtBox_iva.Enabled = false;
                        frm.label_usuario.Text = txtNombreUsuario.Text;

                        frm.Show();
                    }   
                    if (txtNombreUsuario.Text == "Eva")
                    {
                        MessageBox.Show("Acceso permitido", "" + txtNombreUsuario.Text);
                        FrmOpera frm = new FrmOpera();
                        frm.textBox_nombreproducto.Text = "LAPTOP";
                        frm.textBox_nombreproducto.Enabled = false;
                        frm.txtBox_iva.Enabled = false;
                        frm.label_usuario.Text = txtNombreUsuario.Text;
                        frm.Show();
                    }
                    if (txtNombreUsuario.Text == "Raquel")
                    {
                        MessageBox.Show("No puedes acceder eres Admin", "" + txtNombreUsuario.Text);


                    }
                    if (txtNombreUsuario.Text == "Agustin")
                    {
                        MessageBox.Show("No puedes acceder eres AdminR", "" + txtNombreUsuario.Text);


                    }

                }
                else
                {
                    if (txtNombreUsuario.Text == "Carlos")
                    {
                        MessageBox.Show("Acceso permitido", "" + txtNombreUsuario.Text);
                        FrmOpera frm = new FrmOpera();
                        frm.textBox_nombreproducto.Text = "LAPTOP";
                        frm.textBox_nombreproducto.Enabled = false;
                        frm.txtBox_iva.Enabled = false;
                        frm.label_usuario.Text = txtNombreUsuario.Text;
                        frm.Show();
                    }
                    if (txtNombreUsuario.Text == "Eva")
                    {
                        MessageBox.Show("No puedes acceder eres Usuario", "" + txtNombreUsuario.Text);
                    }  

                    if (txtNombreUsuario.Text == "Raquel")
                    {
                        MessageBox.Show("Acceso permitido", "" + txtNombreUsuario.Text);
                        FrmOpera frm = new FrmOpera();

                        frm.textBox_nombreproducto.Enabled = true;
                        frm.txtBox_iva.Enabled = true;
                        frm.label_usuario.Text = txtNombreUsuario.Text;
                        frm.label_usuario.Text = txtNombreUsuario.Text;
                        frm.Show();
                   

                    }
                    if (txtNombreUsuario.Text == "Agustin")
                    {
                        MessageBox.Show("Acceso permitido", "" + txtNombreUsuario.Text);
                        FrmOpera frm = new FrmOpera();

                        frm.textBox_nombreproducto.Enabled = true;
                        frm.txtBox_iva.Enabled = true;
                        frm.label_usuario.Text = txtNombreUsuario.Text;
                        frm.Show();

                    }

                }



                this.Hide();
            }
            else
            {
                MessageBox.Show("No puedes acceder");

            }


        }

        private void FrmLoguin_Load(object sender, EventArgs e)
        {

        }
    }
}
