namespace tiendaVideojuegos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbPiezas = new System.Windows.Forms.TextBox();
            this.gbAlta = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbUbicacion = new System.Windows.Forms.ComboBox();
            this.cbPlataforma = new System.Windows.Forms.ComboBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAlta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Piezas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Plataforma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Genero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ubicación FIsica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Clasificación";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(6, 45);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(100, 20);
            this.tbTitulo.TabIndex = 8;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(215, 45);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 9;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(6, 84);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 10;
            // 
            // tbPiezas
            // 
            this.tbPiezas.Location = new System.Drawing.Point(215, 84);
            this.tbPiezas.Name = "tbPiezas";
            this.tbPiezas.Size = new System.Drawing.Size(100, 20);
            this.tbPiezas.TabIndex = 11;
            // 
            // gbAlta
            // 
            this.gbAlta.Controls.Add(this.btnAgregar);
            this.gbAlta.Controls.Add(this.cbUbicacion);
            this.gbAlta.Controls.Add(this.cbPlataforma);
            this.gbAlta.Controls.Add(this.cbClasificacion);
            this.gbAlta.Controls.Add(this.cbGenero);
            this.gbAlta.Controls.Add(this.tbPiezas);
            this.gbAlta.Controls.Add(this.tbDescripcion);
            this.gbAlta.Controls.Add(this.tbPrecio);
            this.gbAlta.Controls.Add(this.tbTitulo);
            this.gbAlta.Controls.Add(this.label7);
            this.gbAlta.Controls.Add(this.label8);
            this.gbAlta.Controls.Add(this.label5);
            this.gbAlta.Controls.Add(this.label6);
            this.gbAlta.Controls.Add(this.label3);
            this.gbAlta.Controls.Add(this.label4);
            this.gbAlta.Controls.Add(this.label2);
            this.gbAlta.Controls.Add(this.label1);
            this.gbAlta.Location = new System.Drawing.Point(14, 30);
            this.gbAlta.Name = "gbAlta";
            this.gbAlta.Size = new System.Drawing.Size(342, 285);
            this.gbAlta.TabIndex = 0;
            this.gbAlta.TabStop = false;
            this.gbAlta.Text = "Alta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 211);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbUbicacion
            // 
            this.cbUbicacion.FormattingEnabled = true;
            this.cbUbicacion.Location = new System.Drawing.Point(215, 163);
            this.cbUbicacion.Name = "cbUbicacion";
            this.cbUbicacion.Size = new System.Drawing.Size(121, 21);
            this.cbUbicacion.TabIndex = 15;
            // 
            // cbPlataforma
            // 
            this.cbPlataforma.FormattingEnabled = true;
            this.cbPlataforma.Location = new System.Drawing.Point(215, 123);
            this.cbPlataforma.Name = "cbPlataforma";
            this.cbPlataforma.Size = new System.Drawing.Size(121, 21);
            this.cbPlataforma.TabIndex = 14;
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Location = new System.Drawing.Point(6, 163);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cbClasificacion.TabIndex = 13;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(6, 123);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(382, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar piezas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(382, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 198);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(327, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ingrese las piezas que compro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Refrescar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.venderToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.venderToolStripMenuItem.Text = "Vender";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAlta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAlta.ResumeLayout(false);
            this.gbAlta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbPiezas;
        private System.Windows.Forms.GroupBox gbAlta;
        private System.Windows.Forms.ComboBox cbUbicacion;
        private System.Windows.Forms.ComboBox cbPlataforma;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

