namespace Vialis.RRHH.UC.Trabajador
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
            this.lblComuna = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.cmbOficioprofesion = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cmbAfp = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSalud = new System.Windows.Forms.Label();
            this.lvlAfp = new System.Windows.Forms.Label();
            this.lblOficiopro = new System.Windows.Forms.Label();
            this.lblEstadocivil = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRun = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.lblPorDesc_afp = new System.Windows.Forms.Label();
            this.lblPorDesc_salud = new System.Windows.Forms.Label();
            this.txtPorcAFP = new System.Windows.Forms.TextBox();
            this.txtPorcSalud = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblFecnac = new System.Windows.Forms.Label();
            this.dtpFecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbSalud = new System.Windows.Forms.ComboBox();
            this.cmbComuna = new System.Windows.Forms.ComboBox();
            this.cmbProvidencia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblComuna
            // 
            this.lblComuna.AutoSize = true;
            this.lblComuna.Location = new System.Drawing.Point(42, 220);
            this.lblComuna.Name = "lblComuna";
            this.lblComuna.Size = new System.Drawing.Size(49, 13);
            this.lblComuna.TabIndex = 79;
            this.lblComuna.Text = "Comuna:";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(402, 75);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(148, 20);
            this.txtApellidoM.TabIndex = 78;
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(303, 78);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(86, 13);
            this.lblApellidoM.TabIndex = 77;
            this.lblApellidoM.Text = "Apellido Materno";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(166, 75);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(131, 20);
            this.txtApellidoP.TabIndex = 76;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(42, 78);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoP.TabIndex = 75;
            this.lblApellidoP.Text = "Apellido Paterno:";
            // 
            // cmbOficioprofesion
            // 
            this.cmbOficioprofesion.FormattingEnabled = true;
            this.cmbOficioprofesion.Location = new System.Drawing.Point(166, 310);
            this.cmbOficioprofesion.Name = "cmbOficioprofesion";
            this.cmbOficioprofesion.Size = new System.Drawing.Size(121, 21);
            this.cmbOficioprofesion.TabIndex = 74;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(167, 244);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoCivil.TabIndex = 72;
            // 
            // cmbAfp
            // 
            this.cmbAfp.FormattingEnabled = true;
            this.cmbAfp.Location = new System.Drawing.Point(368, 220);
            this.cmbAfp.Name = "cmbAfp";
            this.cmbAfp.Size = new System.Drawing.Size(121, 21);
            this.cmbAfp.TabIndex = 70;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(557, 411);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 68;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(166, 106);
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(205, 20);
            this.txtRun.TabIndex = 67;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(166, 133);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(457, 20);
            this.txtDireccion.TabIndex = 66;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(384, 20);
            this.txtNombre.TabIndex = 65;
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.Location = new System.Drawing.Point(320, 277);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(37, 13);
            this.lblSalud.TabIndex = 64;
            this.lblSalud.Text = "Salud:";
            // 
            // lvlAfp
            // 
            this.lvlAfp.AutoSize = true;
            this.lvlAfp.Location = new System.Drawing.Point(321, 220);
            this.lvlAfp.Name = "lvlAfp";
            this.lvlAfp.Size = new System.Drawing.Size(30, 13);
            this.lvlAfp.TabIndex = 63;
            this.lvlAfp.Text = "AFP:";
            // 
            // lblOficiopro
            // 
            this.lblOficiopro.AutoSize = true;
            this.lblOficiopro.Location = new System.Drawing.Point(42, 313);
            this.lblOficiopro.Name = "lblOficiopro";
            this.lblOficiopro.Size = new System.Drawing.Size(89, 13);
            this.lblOficiopro.TabIndex = 60;
            this.lblOficiopro.Text = "Oficio / Profesión";
            // 
            // lblEstadocivil
            // 
            this.lblEstadocivil.AutoSize = true;
            this.lblEstadocivil.Location = new System.Drawing.Point(42, 252);
            this.lblEstadocivil.Name = "lblEstadocivil";
            this.lblEstadocivil.Size = new System.Drawing.Size(62, 13);
            this.lblEstadocivil.TabIndex = 59;
            this.lblEstadocivil.Text = "Estado Civil";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(41, 133);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 58;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(41, 106);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(30, 13);
            this.lblRun.TabIndex = 57;
            this.lblRun.Text = "Run:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 56;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(42, 166);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 83;
            this.lblRegion.Text = "Región:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(41, 193);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 84;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cmbRegion
            // 
            this.cmbRegion.DisplayMember = "Id_region";
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(167, 163);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(121, 21);
            this.cmbRegion.TabIndex = 86;
            this.cmbRegion.ValueMember = "Id_region";
            this.cmbRegion.SelectedIndexChanged += new System.EventHandler(this.cmbRegion_SelectedIndexChanged);
            // 
            // lblPorDesc_afp
            // 
            this.lblPorDesc_afp.AutoSize = true;
            this.lblPorDesc_afp.Location = new System.Drawing.Point(320, 247);
            this.lblPorDesc_afp.Name = "lblPorDesc_afp";
            this.lblPorDesc_afp.Size = new System.Drawing.Size(38, 13);
            this.lblPorDesc_afp.TabIndex = 87;
            this.lblPorDesc_afp.Text = "% AFP";
            // 
            // lblPorDesc_salud
            // 
            this.lblPorDesc_salud.AutoSize = true;
            this.lblPorDesc_salud.Location = new System.Drawing.Point(320, 305);
            this.lblPorDesc_salud.Name = "lblPorDesc_salud";
            this.lblPorDesc_salud.Size = new System.Drawing.Size(45, 13);
            this.lblPorDesc_salud.TabIndex = 88;
            this.lblPorDesc_salud.Text = "% Salud";
            // 
            // txtPorcAFP
            // 
            this.txtPorcAFP.Location = new System.Drawing.Point(368, 247);
            this.txtPorcAFP.Name = "txtPorcAFP";
            this.txtPorcAFP.Size = new System.Drawing.Size(43, 20);
            this.txtPorcAFP.TabIndex = 89;
            // 
            // txtPorcSalud
            // 
            this.txtPorcSalud.Location = new System.Drawing.Point(368, 302);
            this.txtPorcSalud.Name = "txtPorcSalud";
            this.txtPorcSalud.Size = new System.Drawing.Size(43, 20);
            this.txtPorcSalud.TabIndex = 90;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(42, 280);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 91;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(167, 277);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 92;
            // 
            // lblFecnac
            // 
            this.lblFecnac.AutoSize = true;
            this.lblFecnac.Location = new System.Drawing.Point(320, 171);
            this.lblFecnac.Name = "lblFecnac";
            this.lblFecnac.Size = new System.Drawing.Size(94, 13);
            this.lblFecnac.TabIndex = 94;
            this.lblFecnac.Text = "Fecha nacimiento:";
            // 
            // dtpFecha_nacimiento
            // 
            this.dtpFecha_nacimiento.Location = new System.Drawing.Point(436, 166);
            this.dtpFecha_nacimiento.Name = "dtpFecha_nacimiento";
            this.dtpFecha_nacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_nacimiento.TabIndex = 95;
            // 
            // cmbSalud
            // 
            this.cmbSalud.FormattingEnabled = true;
            this.cmbSalud.Location = new System.Drawing.Point(368, 274);
            this.cmbSalud.Name = "cmbSalud";
            this.cmbSalud.Size = new System.Drawing.Size(121, 21);
            this.cmbSalud.TabIndex = 96;
            // 
            // cmbComuna
            // 
            this.cmbComuna.FormattingEnabled = true;
            this.cmbComuna.Location = new System.Drawing.Point(167, 217);
            this.cmbComuna.Name = "cmbComuna";
            this.cmbComuna.Size = new System.Drawing.Size(121, 21);
            this.cmbComuna.TabIndex = 80;
            // 
            // cmbProvidencia
            // 
            this.cmbProvidencia.DisplayMember = "id_provincia";
            this.cmbProvidencia.FormattingEnabled = true;
            this.cmbProvidencia.Location = new System.Drawing.Point(167, 190);
            this.cmbProvidencia.Name = "cmbProvidencia";
            this.cmbProvidencia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvidencia.TabIndex = 85;
            this.cmbProvidencia.ValueMember = "id_provincia";
            this.cmbProvidencia.SelectedIndexChanged += new System.EventHandler(this.cmbProvidencia_SelectedIndexChanged);
            // 
            // UCagregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbSalud);
            this.Controls.Add(this.dtpFecha_nacimiento);
            this.Controls.Add(this.lblFecnac);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtPorcSalud);
            this.Controls.Add(this.txtPorcAFP);
            this.Controls.Add(this.lblPorDesc_salud);
            this.Controls.Add(this.lblPorDesc_afp);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.cmbProvidencia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cmbComuna);
            this.Controls.Add(this.lblComuna);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.cmbOficioprofesion);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.cmbAfp);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRun);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSalud);
            this.Controls.Add(this.lvlAfp);
            this.Controls.Add(this.lblOficiopro);
            this.Controls.Add(this.lblEstadocivil);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblRun);
            this.Controls.Add(this.lblNombre);
            this.Name = "UCagregar";
            this.Size = new System.Drawing.Size(680, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblComuna;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.ComboBox cmbOficioprofesion;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.ComboBox cmbAfp;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSalud;
        private System.Windows.Forms.Label lvlAfp;
        private System.Windows.Forms.Label lblOficiopro;
        private System.Windows.Forms.Label lblEstadocivil;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Label lblPorDesc_afp;
        private System.Windows.Forms.Label lblPorDesc_salud;
        private System.Windows.Forms.TextBox txtPorcAFP;
        private System.Windows.Forms.TextBox txtPorcSalud;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblFecnac;
        private System.Windows.Forms.DateTimePicker dtpFecha_nacimiento;
        private System.Windows.Forms.ComboBox cmbSalud;
        private System.Windows.Forms.ComboBox cmbComuna;
        private System.Windows.Forms.ComboBox cmbProvidencia;
    }
}
