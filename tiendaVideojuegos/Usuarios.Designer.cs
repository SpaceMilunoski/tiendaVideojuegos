namespace tiendaVideojuegos
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.btnAgregarCompradas = new System.Windows.Forms.Button();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbUsuario.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.btnAgregarCompradas);
            this.gbUsuario.Controls.Add(this.cbRol);
            this.gbUsuario.Controls.Add(this.label7);
            this.gbUsuario.Controls.Add(this.tbPass);
            this.gbUsuario.Controls.Add(this.label4);
            this.gbUsuario.Controls.Add(this.tbUsuario);
            this.gbUsuario.Controls.Add(this.label5);
            this.gbUsuario.Controls.Add(this.tbEdad);
            this.gbUsuario.Controls.Add(this.label6);
            this.gbUsuario.Controls.Add(this.tbApellidos);
            this.gbUsuario.Controls.Add(this.label3);
            this.gbUsuario.Controls.Add(this.tbNombre);
            this.gbUsuario.Controls.Add(this.label2);
            this.gbUsuario.Controls.Add(this.tbId);
            this.gbUsuario.Controls.Add(this.label1);
            this.gbUsuario.Location = new System.Drawing.Point(12, 35);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(421, 209);
            this.gbUsuario.TabIndex = 0;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuario";
            // 
            // btnAgregarCompradas
            // 
            this.btnAgregarCompradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompradas.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCompradas.Image")));
            this.btnAgregarCompradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCompradas.Location = new System.Drawing.Point(273, 154);
            this.btnAgregarCompradas.Name = "btnAgregarCompradas";
            this.btnAgregarCompradas.Size = new System.Drawing.Size(90, 39);
            this.btnAgregarCompradas.TabIndex = 14;
            this.btnAgregarCompradas.Text = "Agregar";
            this.btnAgregarCompradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCompradas.UseVisualStyleBackColor = true;
            this.btnAgregarCompradas.Click += new System.EventHandler(this.btnAgregarCompradas_Click);
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "administrador",
            "vendedor"});
            this.cbRol.Location = new System.Drawing.Point(63, 154);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(100, 21);
            this.cbRol.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rol";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(263, 118);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(263, 74);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Usuario";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(263, 29);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 20);
            this.tbEdad.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Edad";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(63, 114);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(63, 74);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(63, 29);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(0, 251);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(597, 187);
            this.dgvUsuario.TabIndex = 2;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.Location = new System.Drawing.Point(632, 262);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(108, 39);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(632, 314);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 39);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(632, 368);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 36);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCompradas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
    }
}