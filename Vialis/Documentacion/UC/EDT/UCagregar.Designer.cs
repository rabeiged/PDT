namespace Vialis.Documentacion.UC.EDT
{
    partial class UCagregar
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbJerarquia = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTermino = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaTermino = new System.Windows.Forms.Label();
            this.cmbEtapTarHit = new System.Windows.Forms.ComboBox();
            this.lblEtapTarHit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(31, 64);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(55, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Jerarquía:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(31, 145);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmbJerarquia
            // 
            this.cmbJerarquia.FormattingEnabled = true;
            this.cmbJerarquia.Location = new System.Drawing.Point(141, 56);
            this.cmbJerarquia.Name = "cmbJerarquia";
            this.cmbJerarquia.Size = new System.Drawing.Size(121, 21);
            this.cmbJerarquia.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(121, 145);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(238, 88);
            this.txtDescripcion.TabIndex = 7;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(121, 251);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 8;
            // 
            // dtpFechaTermino
            // 
            this.dtpFechaTermino.Location = new System.Drawing.Point(121, 297);
            this.dtpFechaTermino.Name = "dtpFechaTermino";
            this.dtpFechaTermino.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaTermino.TabIndex = 9;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(29, 251);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lblFechaInicio.TabIndex = 10;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaTermino
            // 
            this.lblFechaTermino.AutoSize = true;
            this.lblFechaTermino.Location = new System.Drawing.Point(31, 303);
            this.lblFechaTermino.Name = "lblFechaTermino";
            this.lblFechaTermino.Size = new System.Drawing.Size(81, 13);
            this.lblFechaTermino.TabIndex = 11;
            this.lblFechaTermino.Text = "Fecha Termino:";
            // 
            // cmbEtapTarHit
            // 
            this.cmbEtapTarHit.FormattingEnabled = true;
            this.cmbEtapTarHit.Location = new System.Drawing.Point(141, 24);
            this.cmbEtapTarHit.Name = "cmbEtapTarHit";
            this.cmbEtapTarHit.Size = new System.Drawing.Size(121, 21);
            this.cmbEtapTarHit.TabIndex = 12;
            this.cmbEtapTarHit.SelectedIndexChanged += new System.EventHandler(this.cmbEtapTarHit_SelectedIndexChanged);
            // 
            // lblEtapTarHit
            // 
            this.lblEtapTarHit.AutoSize = true;
            this.lblEtapTarHit.Location = new System.Drawing.Point(31, 27);
            this.lblEtapTarHit.Name = "lblEtapTarHit";
            this.lblEtapTarHit.Size = new System.Drawing.Size(104, 13);
            this.lblEtapTarHit.TabIndex = 13;
            this.lblEtapTarHit.Text = "Etapa / Tarea / Hito";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 184);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Agregar corresponde a la seleccion de etapa tarea e hito, jerarquia en caso de qu" +
    "e seleccione una tarea o hito para que la pueda asociar. al iniciar jerarquia es" +
    "tara invisible";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(478, 374);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // UCagregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEtapTarHit);
            this.Controls.Add(this.cmbEtapTarHit);
            this.Controls.Add(this.lblFechaTermino);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaTermino);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbJerarquia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTipo);
            this.Name = "UCagregar";
            this.Size = new System.Drawing.Size(680, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbJerarquia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaTermino;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaTermino;
        private System.Windows.Forms.ComboBox cmbEtapTarHit;
        private System.Windows.Forms.Label lblEtapTarHit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregar;
    }
}
