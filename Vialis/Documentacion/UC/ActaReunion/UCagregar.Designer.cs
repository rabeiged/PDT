namespace Vialis.Documentacion.UC.ActaReunion
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
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblParticipantes = new System.Windows.Forms.Label();
            this.txtNombreParticipante = new System.Windows.Forms.TextBox();
            this.lstParticipantes = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblRun = new System.Windows.Forms.Label();
            this.lblNombreParticipante = new System.Windows.Forms.Label();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(48, 309);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(43, 13);
            this.lblDetalle.TabIndex = 0;
            this.lblDetalle.Text = "Detalle:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(48, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(132, 31);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(132, 309);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(391, 100);
            this.txtDetalle.TabIndex = 3;
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.Location = new System.Drawing.Point(48, 172);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(71, 13);
            this.lblParticipantes.TabIndex = 4;
            this.lblParticipantes.Text = "Participantes:";
            // 
            // txtNombreParticipante
            // 
            this.txtNombreParticipante.Location = new System.Drawing.Point(132, 146);
            this.txtNombreParticipante.Name = "txtNombreParticipante";
            this.txtNombreParticipante.Size = new System.Drawing.Size(200, 20);
            this.txtNombreParticipante.TabIndex = 5;
            // 
            // lstParticipantes
            // 
            this.lstParticipantes.FormattingEnabled = true;
            this.lstParticipantes.Location = new System.Drawing.Point(132, 172);
            this.lstParticipantes.Name = "lstParticipantes";
            this.lstParticipantes.Size = new System.Drawing.Size(200, 121);
            this.lstParticipantes.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(352, 141);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(352, 270);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 8;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(586, 386);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(48, 112);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(27, 13);
            this.lblRun.TabIndex = 10;
            this.lblRun.Text = "Run";
            // 
            // lblNombreParticipante
            // 
            this.lblNombreParticipante.AutoSize = true;
            this.lblNombreParticipante.Location = new System.Drawing.Point(48, 146);
            this.lblNombreParticipante.Name = "lblNombreParticipante";
            this.lblNombreParticipante.Size = new System.Drawing.Size(47, 13);
            this.lblNombreParticipante.TabIndex = 11;
            this.lblNombreParticipante.Text = "Nombre:";
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(132, 112);
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(200, 20);
            this.txtRun.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(352, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // UCagregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtRun);
            this.Controls.Add(this.lblNombreParticipante);
            this.Controls.Add(this.lblRun);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstParticipantes);
            this.Controls.Add(this.txtNombreParticipante);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDetalle);
            this.Name = "UCagregar";
            this.Size = new System.Drawing.Size(680, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblParticipantes;
        private System.Windows.Forms.TextBox txtNombreParticipante;
        private System.Windows.Forms.ListBox lstParticipantes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Label lblNombreParticipante;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.Button btnBuscar;
    }
}
