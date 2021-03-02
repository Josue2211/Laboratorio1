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
    public partial class FrmOpera : Form
    {
        public FrmOpera()
        {
            InitializeComponent();
        }
        public string estadousuario;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MENOR o IGUAL 50 NO TENDRÁ DESCUENTO", " <= 50");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100 TENDRÁ UN DESCUENTO DEL 0.05 ", " > 50 and < 100");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL A 100 O MENOR QUE 101 TENDRÁ UN DESCUENTO DEL 0.10 ", " >= 100 and < 101");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL 101 Y MENOR QUE 150 TENDRÁ UN DESCUENTO DEL 0.20 ", " > 101 and < 150");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRÁ UN DESCUENTO DEL 0.50 ", " > 150");
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            string lbl = textBox_nombreproducto.Text;
            label2.Text = lbl;
            if (txtBox_iva.Text == ("") || txtBox_iva.Text == null)
            {
                double p = Convert.ToDouble(textBox_precioproducto.Text);
                double c = Convert.ToDouble(textBox_cantidad.Text);
                double t = p * c;
                label3.Text = t.ToString();

                double a = Convert.ToDouble(textBox_precioproducto.Text);
                double i = t * 0.13;
                label4.Text = i.ToString();

                double b = t + i;

                label5.Text = p.ToString();

                if (t <= 50)
                {
                    double o = t + i;
                    label6.Text = o.ToString();

                }
                else if (t > 50 && t < 100)
                {
                    double resul = t * 0.05;
                    double res = t - resul + i;
                    label6.Text = res.ToString();


                }
                else if (t > 150)
                {
                    double resul = t * 0.50;
                    double res = t - resul + i;
                    label6.Text = res.ToString();
                }
            }
            else
            {
                double p = Convert.ToDouble(textBox_precioproducto.Text);
                double c = Convert.ToDouble(textBox_cantidad.Text);
                double t = p * c;
                label3.Text = t.ToString();

                double b = Convert.ToDouble(textBox_precioproducto.Text);
                double i = t * (Convert.ToDouble(txtBox_iva.Text)) / 100;
                label4.Text = i.ToString();

                double a = t + i;

                label5.Text = p.ToString();

                if (t <= 50)
                {
                    double o = t + i;
                    label6.Text = o.ToString();

                }
                else if (t > 50 && t < 100)
                {
                    double resul = t * 0.05;
                    double res = t - resul + i;
                    label6.Text = res.ToString();
                }
                else if (t >= 100 && t < 101)
                {
                    double resul = t * 0.10;
                    double res = (t + i) - resul;
                    label6.Text = res.ToString();
                }
                else if (t >= 101 && t < 150)
                {
                    double resul = t * 0.20;
                    double res = t - resul + i;
                    label6.Text = res.ToString();
                }
                else if (t > 150)
                {
                    double resul = t * 0.50;
                    double res = t - resul + i;
                    label6.Text = res.ToString();
                }
            }
        }

        private void FrmOpera_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label_nombreproducto_Click(object sender, EventArgs e)
        {

        }
    }
}

