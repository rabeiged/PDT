namespace Vialis.Documentacion.UC.Proyecto
{
    partial class frmTrabajador
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
            this.cmbProfesionOficio = new System.Windows.Forms.ComboBox();
            this.lblRun = new System.Windows.Forms.Label();
            this.lblProfesionOficio = new System.Windows.Forms.Label();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProfesionOficio
            // 
            this.cmbProfesionOficio.FormattingEnabled = true;
            this.cmbProfesionOficio.Location = new System.Drawing.Point(118, 47);
            this.cmbProfesionOficio.Name = "cmbProfesionOficio";
            this.cmbProfesionOficio.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesionOficio.TabIndex = 0;
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(21, 18);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(30, 13);
            this.lblRun.TabIndex = 1;
            this.lblRun.Text = "Run:";
            // 
            // lblProfesionOficio
            // 
            this.lblProfesionOficio.AutoSize = true;
            this.lblProfesionOficio.Location = new System.Drawing.Point(21, 50);
            this.lblProfesionOficio.Name = "lblProfesionOficio";
            this.lblProfesionOficio.Size = new System.Drawing.Size(91, 13);
            this.lblProfesionOficio.TabIndex = 2;
            this.lblProfesionOficio.Text = "Profesión / Oificio";
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(118, 15);
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(121, 20);
            this.txtRun.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 95);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(24, 246);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(300, 108);
            this.listBox2.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(249, 202);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(249, 360);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(12, 408);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(249, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 443);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtRun);
            this.Controls.Add(this.lblProfesionOficio);
            this.Controls.Add(this.lblRun);
            this.Controls.Add(this.cmbProfesionOficio);
            this.Name = "frmTrabajador";
            this.Text = "frmTrabajador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProfesionOficio;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Label lblProfesionOficio;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnBuscar;
    }
}