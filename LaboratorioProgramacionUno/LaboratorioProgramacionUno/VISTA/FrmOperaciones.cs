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
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MENOR o IGUAL 50 NO TENDRÁ DESCUENTO", " <= 50");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100 TENDRÁ UN DESCUENTO DEL 0.05 ", " > 50 and < 100");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL A 100 O MENOR QUE 101 TENDRÁ UN DESCUENTO DEL 0.10 ", " >= 100 and < 101");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL 101 Y MENOR QUE 150 TENDRÁ UN DESCUENTO DEL 0.20 ", " > 101 and < 150");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRÁ UN DESCUENTO DEL 0.50 ", " > 150");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox_nombreproducto.Text;
        }

        private void label_producto_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtBox_iva_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_precioproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_calcular_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculando");

            int multiplicacion;
            multiplicacion = Convert.ToInt32(textBox_precioproducto.Text) * Convert.ToInt32(textBox_cantidad.Text);

            int suma;
            suma = multiplicacion + Convert.ToInt32(txtBox_iva.Text);



            

        }
    }
}
