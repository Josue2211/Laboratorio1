
namespace LaboratorioProgramacionUno.VISTA
{
    partial class FrmOperaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_tabladescuento = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_iva = new System.Windows.Forms.Label();
            this.label_nombreproducto = new System.Windows.Forms.Label();
            this.label_precioproducto = new System.Windows.Forms.Label();
            this.label_cantidad = new System.Windows.Forms.Label();
            this.txtBox_iva = new System.Windows.Forms.TextBox();
            this.textBox_nombreproducto = new System.Windows.Forms.TextBox();
            this.textBox_precioproducto = new System.Windows.Forms.TextBox();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.label_producto = new System.Windows.Forms.Label();
            this.label_totalsiniva = new System.Windows.Forms.Label();
            this.label_ivaagregar = new System.Windows.Forms.Label();
            this.label_totalyiva = new System.Windows.Forms.Label();
            this.label_totalapagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(1, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 198);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ACCION";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "REGLA";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // label_tabladescuento
            // 
            this.label_tabladescuento.AutoSize = true;
            this.label_tabladescuento.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tabladescuento.Location = new System.Drawing.Point(13, 9);
            this.label_tabladescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tabladescuento.Name = "label_tabladescuento";
            this.label_tabladescuento.Size = new System.Drawing.Size(291, 33);
            this.label_tabladescuento.TabIndex = 2;
            this.label_tabladescuento.Text = "TABLA DE DESCUENTOS";
            this.label_tabladescuento.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(849, 9);
            this.label_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(86, 24);
            this.label_usuario.TabIndex = 3;
            this.label_usuario.Text = "USUARIO";
            this.label_usuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_iva
            // 
            this.label_iva.AutoSize = true;
            this.label_iva.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iva.Location = new System.Drawing.Point(15, 310);
            this.label_iva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_iva.Name = "label_iva";
            this.label_iva.Size = new System.Drawing.Size(37, 24);
            this.label_iva.TabIndex = 4;
            this.label_iva.Text = "IVA";
            // 
            // label_nombreproducto
            // 
            this.label_nombreproducto.AutoSize = true;
            this.label_nombreproducto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombreproducto.Location = new System.Drawing.Point(15, 375);
            this.label_nombreproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nombreproducto.Name = "label_nombreproducto";
            this.label_nombreproducto.Size = new System.Drawing.Size(221, 24);
            this.label_nombreproducto.TabIndex = 5;
            this.label_nombreproducto.Text = "NOMBRE DEL PRODUCTO";
            // 
            // label_precioproducto
            // 
            this.label_precioproducto.AutoSize = true;
            this.label_precioproducto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precioproducto.Location = new System.Drawing.Point(15, 440);
            this.label_precioproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_precioproducto.Name = "label_precioproducto";
            this.label_precioproducto.Size = new System.Drawing.Size(211, 24);
            this.label_precioproducto.TabIndex = 6;
            this.label_precioproducto.Text = "PRECIO DEL PRODUCTO";
            // 
            // label_cantidad
            // 
            this.label_cantidad.AutoSize = true;
            this.label_cantidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cantidad.Location = new System.Drawing.Point(15, 504);
            this.label_cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cantidad.Name = "label_cantidad";
            this.label_cantidad.Size = new System.Drawing.Size(95, 24);
            this.label_cantidad.TabIndex = 7;
            this.label_cantidad.Text = "CANTIDAD";
            // 
            // txtBox_iva
            // 
            this.txtBox_iva.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_iva.Location = new System.Drawing.Point(283, 304);
            this.txtBox_iva.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_iva.Name = "txtBox_iva";
            this.txtBox_iva.Size = new System.Drawing.Size(192, 30);
            this.txtBox_iva.TabIndex = 8;
            this.txtBox_iva.TextChanged += new System.EventHandler(this.txtBox_iva_TextChanged);
            // 
            // textBox_nombreproducto
            // 
            this.textBox_nombreproducto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombreproducto.Location = new System.Drawing.Point(283, 369);
            this.textBox_nombreproducto.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nombreproducto.Name = "textBox_nombreproducto";
            this.textBox_nombreproducto.Size = new System.Drawing.Size(192, 30);
            this.textBox_nombreproducto.TabIndex = 9;
            this.textBox_nombreproducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_precioproducto
            // 
            this.textBox_precioproducto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_precioproducto.Location = new System.Drawing.Point(283, 434);
            this.textBox_precioproducto.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_precioproducto.Name = "textBox_precioproducto";
            this.textBox_precioproducto.Size = new System.Drawing.Size(192, 30);
            this.textBox_precioproducto.TabIndex = 10;
            this.textBox_precioproducto.TextChanged += new System.EventHandler(this.textBox_precioproducto_TextChanged);
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cantidad.Location = new System.Drawing.Point(283, 498);
            this.textBox_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(192, 30);
            this.textBox_cantidad.TabIndex = 11;
            this.textBox_cantidad.TextChanged += new System.EventHandler(this.textBox_cantidad_TextChanged);
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_producto.Location = new System.Drawing.Point(582, 310);
            this.label_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(80, 24);
            this.label_producto.TabIndex = 12;
            this.label_producto.Text = "Producto:";
            this.label_producto.Click += new System.EventHandler(this.label_producto_Click);
            // 
            // label_totalsiniva
            // 
            this.label_totalsiniva.AutoSize = true;
            this.label_totalsiniva.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalsiniva.Location = new System.Drawing.Point(582, 375);
            this.label_totalsiniva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_totalsiniva.Name = "label_totalsiniva";
            this.label_totalsiniva.Size = new System.Drawing.Size(102, 24);
            this.label_totalsiniva.TabIndex = 13;
            this.label_totalsiniva.Text = "Total sin iva:";
            // 
            // label_ivaagregar
            // 
            this.label_ivaagregar.AutoSize = true;
            this.label_ivaagregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ivaagregar.Location = new System.Drawing.Point(582, 437);
            this.label_ivaagregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ivaagregar.Name = "label_ivaagregar";
            this.label_ivaagregar.Size = new System.Drawing.Size(112, 24);
            this.label_ivaagregar.TabIndex = 14;
            this.label_ivaagregar.Text = "Iva a agregar:";
            // 
            // label_totalyiva
            // 
            this.label_totalyiva.AutoSize = true;
            this.label_totalyiva.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalyiva.Location = new System.Drawing.Point(582, 504);
            this.label_totalyiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_totalyiva.Name = "label_totalyiva";
            this.label_totalyiva.Size = new System.Drawing.Size(233, 24);
            this.label_totalyiva.TabIndex = 15;
            this.label_totalyiva.Text = "Total sin descuento y con IVA:";
            // 
            // label_totalapagar
            // 
            this.label_totalapagar.AutoSize = true;
            this.label_totalapagar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalapagar.Location = new System.Drawing.Point(582, 569);
            this.label_totalapagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_totalapagar.Name = "label_totalapagar";
            this.label_totalapagar.Size = new System.Drawing.Size(147, 24);
            this.label_totalapagar.TabIndex = 16;
            this.label_totalapagar.Text = "TOTAL A PAGAR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(943, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Label_user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(848, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(848, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(848, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(848, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(848, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            // 
            // button_calcular
            // 
            this.button_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calcular.Location = new System.Drawing.Point(319, 548);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(121, 45);
            this.button_calcular.TabIndex = 23;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // FrmOperaciones
            // 
            this.AcceptButton = this.button_calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 668);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_totalapagar);
            this.Controls.Add(this.label_totalyiva);
            this.Controls.Add(this.label_ivaagregar);
            this.Controls.Add(this.label_totalsiniva);
            this.Controls.Add(this.label_producto);
            this.Controls.Add(this.textBox_cantidad);
            this.Controls.Add(this.textBox_precioproducto);
            this.Controls.Add(this.textBox_nombreproducto);
            this.Controls.Add(this.txtBox_iva);
            this.Controls.Add(this.label_cantidad);
            this.Controls.Add(this.label_precioproducto);
            this.Controls.Add(this.label_nombreproducto);
            this.Controls.Add(this.label_iva);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.label_tabladescuento);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPERACIONES";
            this.Load += new System.EventHandler(this.FrmOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label_tabladescuento;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label_iva;
        private System.Windows.Forms.Label label_nombreproducto;
        private System.Windows.Forms.Label label_precioproducto;
        private System.Windows.Forms.Label label_cantidad;
        private System.Windows.Forms.TextBox txtBox_iva;
        private System.Windows.Forms.TextBox textBox_nombreproducto;
        private System.Windows.Forms.TextBox textBox_precioproducto;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.Label label_totalsiniva;
        private System.Windows.Forms.Label label_ivaagregar;
        private System.Windows.Forms.Label label_totalyiva;
        private System.Windows.Forms.Label label_totalapagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_calcular;
    }
}