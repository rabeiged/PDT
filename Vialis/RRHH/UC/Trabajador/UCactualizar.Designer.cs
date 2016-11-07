namespace Vialis.RRHH.UC.Trabajador
{
    partial class UCactualizar
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtRunBusqueda = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.cmbOficioprofesion = new System.Windows.Forms.ComboBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.cmbSalud = new System.Windows.Forms.ComboBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.cmbAfp = new System.Windows.Forms.ComboBox();
            this.lblComuna = new System.Windows.Forms.Label();
            this.cmbTipocontrato = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblPorDesc_afp = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPorDesc_salud = new System.Windows.Forms.Label();
            this.lblSalud = new System.Windows.Forms.Label();
            this.txtPorcAFP = new System.Windows.Forms.TextBox();
            this.lvlAfp = new System.Windows.Forms.Label();
            this.txtPorcSalud = new System.Windows.Forms.TextBox();
            this.lblTipocontrato = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblOficiopro = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblEstadocivil = new System.Windows.Forms.Label();
            this.cmbComuna = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cmbProvidencia = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblRun = new System.Windows.Forms.Label();
            this.cmbRegion_ = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecnac = new System.Windows.Forms.Label();
            this.dtpFecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(433, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Trabajador";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtRunBusqueda
            // 
            this.txtRunBusqueda.Location = new System.Drawing.Point(295, 14);
            this.txtRunBusqueda.Name = "txtRunBusqueda";
            this.txtRunBusqueda.Size = new System.Drawing.Size(121, 20);
            this.txtRunBusqueda.TabIndex = 1;
            this.txtRunBusqueda.TextChanged += new System.EventHandler(this.txtRunBusqueda_TextChanged);
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(16, 99);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoP.TabIndex = 131;
            this.lblApellidoP.Text = "Apellido Paterno:";
            // 
            // cmbOficioprofesion
            // 
            this.cmbOficioprofesion.FormattingEnabled = true;
            this.cmbOficioprofesion.Location = new System.Drawing.Point(119, 292);
            this.cmbOficioprofesion.Name = "cmbOficioprofesion";
            this.cmbOficioprofesion.Size = new System.Drawing.Size(121, 21);
            this.cmbOficioprofesion.TabIndex = 12;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(119, 94);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoP.TabIndex = 4;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(119, 236);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoCivil.TabIndex = 10;
            this.cmbEstadoCivil.Click += new System.EventHandler(this.cmbEstadoCivil_Click);
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(264, 97);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(86, 13);
            this.lblApellidoM.TabIndex = 133;
            this.lblApellidoM.Text = "Apellido Materno";
            // 
            // cmbSalud
            // 
            this.cmbSalud.FormattingEnabled = true;
            this.cmbSalud.Location = new System.Drawing.Point(355, 239);
            this.cmbSalud.Name = "cmbSalud";
            this.cmbSalud.Size = new System.Drawing.Size(121, 21);
            this.cmbSalud.TabIndex = 15;
            this.cmbSalud.Click += new System.EventHandler(this.cmbSalud_Click);
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(355, 92);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoM.TabIndex = 5;
            // 
            // cmbAfp
            // 
            this.cmbAfp.FormattingEnabled = true;
            this.cmbAfp.Location = new System.Drawing.Point(355, 212);
            this.cmbAfp.Name = "cmbAfp";
            this.cmbAfp.Size = new System.Drawing.Size(121, 21);
            this.cmbAfp.TabIndex = 14;
            this.cmbAfp.Click += new System.EventHandler(this.cmbAfp_Click);
            // 
            // lblComuna
            // 
            this.lblComuna.AutoSize = true;
            this.lblComuna.Location = new System.Drawing.Point(16, 209);
            this.lblComuna.Name = "lblComuna";
            this.lblComuna.Size = new System.Drawing.Size(49, 13);
            this.lblComuna.TabIndex = 135;
            this.lblComuna.Text = "Comuna:";
            // 
            // cmbTipocontrato
            // 
            this.cmbTipocontrato.FormattingEnabled = true;
            this.cmbTipocontrato.Location = new System.Drawing.Point(355, 185);
            this.cmbTipocontrato.Name = "cmbTipocontrato";
            this.cmbTipocontrato.Size = new System.Drawing.Size(121, 21);
            this.cmbTipocontrato.TabIndex = 13;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(16, 153);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 139;
            this.lblRegion.Text = "Región:";
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(119, 42);
            this.txtRun.Name = "txtRun";
            this.txtRun.ReadOnly = true;
            this.txtRun.Size = new System.Drawing.Size(121, 20);
            this.txtRun.TabIndex = 124;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(16, 181);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 140;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(119, 122);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(357, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // lblPorDesc_afp
            // 
            this.lblPorDesc_afp.AutoSize = true;
            this.lblPorDesc_afp.Location = new System.Drawing.Point(264, 271);
            this.lblPorDesc_afp.Name = "lblPorDesc_afp";
            this.lblPorDesc_afp.Size = new System.Drawing.Size(41, 13);
            this.lblPorDesc_afp.TabIndex = 143;
            this.lblPorDesc_afp.Text = "% AFP:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(357, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblPorDesc_salud
            // 
            this.lblPorDesc_salud.AutoSize = true;
            this.lblPorDesc_salud.Location = new System.Drawing.Point(264, 296);
            this.lblPorDesc_salud.Name = "lblPorDesc_salud";
            this.lblPorDesc_salud.Size = new System.Drawing.Size(48, 13);
            this.lblPorDesc_salud.TabIndex = 144;
            this.lblPorDesc_salud.Text = "% Salud:";
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.Location = new System.Drawing.Point(264, 242);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(37, 13);
            this.lblSalud.TabIndex = 121;
            this.lblSalud.Text = "Salud:";
            // 
            // txtPorcAFP
            // 
            this.txtPorcAFP.Location = new System.Drawing.Point(355, 266);
            this.txtPorcAFP.Name = "txtPorcAFP";
            this.txtPorcAFP.Size = new System.Drawing.Size(121, 20);
            this.txtPorcAFP.TabIndex = 16;
            // 
            // lvlAfp
            // 
            this.lvlAfp.AutoSize = true;
            this.lvlAfp.Location = new System.Drawing.Point(264, 216);
            this.lvlAfp.Name = "lvlAfp";
            this.lvlAfp.Size = new System.Drawing.Size(30, 13);
            this.lvlAfp.TabIndex = 120;
            this.lvlAfp.Text = "AFP:";
            // 
            // txtPorcSalud
            // 
            this.txtPorcSalud.Location = new System.Drawing.Point(355, 292);
            this.txtPorcSalud.Name = "txtPorcSalud";
            this.txtPorcSalud.Size = new System.Drawing.Size(121, 20);
            this.txtPorcSalud.TabIndex = 17;
            // 
            // lblTipocontrato
            // 
            this.lblTipocontrato.AutoSize = true;
            this.lblTipocontrato.Location = new System.Drawing.Point(264, 188);
            this.lblTipocontrato.Name = "lblTipocontrato";
            this.lblTipocontrato.Size = new System.Drawing.Size(88, 13);
            this.lblTipocontrato.TabIndex = 119;
            this.lblTipocontrato.Text = "Tipo de contrato:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(16, 265);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 147;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblOficiopro
            // 
            this.lblOficiopro.AutoSize = true;
            this.lblOficiopro.Location = new System.Drawing.Point(16, 293);
            this.lblOficiopro.Name = "lblOficiopro";
            this.lblOficiopro.Size = new System.Drawing.Size(89, 13);
            this.lblOficiopro.TabIndex = 117;
            this.lblOficiopro.Text = "Oficio / Profesión";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(119, 264);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 11;
            this.cmbSexo.Click += new System.EventHandler(this.cmbSexo_Click);
            // 
            // lblEstadocivil
            // 
            this.lblEstadocivil.AutoSize = true;
            this.lblEstadocivil.Location = new System.Drawing.Point(16, 237);
            this.lblEstadocivil.Name = "lblEstadocivil";
            this.lblEstadocivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadocivil.TabIndex = 116;
            this.lblEstadocivil.Text = "Estado Civil:";
            // 
            // cmbComuna
            // 
            this.cmbComuna.FormattingEnabled = true;
            this.cmbComuna.Location = new System.Drawing.Point(119, 208);
            this.cmbComuna.Name = "cmbComuna";
            this.cmbComuna.Size = new System.Drawing.Size(121, 21);
            this.cmbComuna.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 125);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 115;
            this.lblDireccion.Text = "Dirección:";
            // 
            // cmbProvidencia
            // 
            this.cmbProvidencia.DisplayMember = "id_provincia";
            this.cmbProvidencia.FormattingEnabled = true;
            this.cmbProvidencia.Location = new System.Drawing.Point(119, 180);
            this.cmbProvidencia.Name = "cmbProvidencia";
            this.cmbProvidencia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvidencia.TabIndex = 8;
            this.cmbProvidencia.ValueMember = "id_provincia";
            this.cmbProvidencia.SelectedIndexChanged += new System.EventHandler(this.cmbProvidencia_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(399, 334);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(121, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar Información";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(16, 44);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(30, 13);
            this.lblRun.TabIndex = 114;
            this.lblRun.Text = "Run:";
            // 
            // cmbRegion_
            // 
            this.cmbRegion_.DisplayMember = "Id_region";
            this.cmbRegion_.FormattingEnabled = true;
            this.cmbRegion_.Location = new System.Drawing.Point(119, 152);
            this.cmbRegion_.Name = "cmbRegion_";
            this.cmbRegion_.Size = new System.Drawing.Size(121, 21);
            this.cmbRegion_.TabIndex = 7;
            this.cmbRegion_.ValueMember = "Id_region";
            this.cmbRegion_.SelectedIndexChanged += new System.EventHandler(this.cmbRegion__SelectedIndexChanged);
            this.cmbRegion_.Click += new System.EventHandler(this.cmbRegion_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 113;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFecnac
            // 
            this.lblFecnac.AutoSize = true;
            this.lblFecnac.Location = new System.Drawing.Point(264, 159);
            this.lblFecnac.Name = "lblFecnac";
            this.lblFecnac.Size = new System.Drawing.Size(94, 13);
            this.lblFecnac.TabIndex = 149;
            this.lblFecnac.Text = "Fecha nacimiento:";
            // 
            // dtpFecha_nacimiento
            // 
            this.dtpFecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_nacimiento.Location = new System.Drawing.Point(355, 159);
            this.dtpFecha_nacimiento.Name = "dtpFecha_nacimiento";
            this.dtpFecha_nacimiento.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha_nacimiento.TabIndex = 148;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha_nacimiento);
            this.groupBox1.Controls.Add(this.lblFecnac);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.cmbRegion_);
            this.groupBox1.Controls.Add(this.lblRun);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.cmbProvidencia);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.cmbComuna);
            this.groupBox1.Controls.Add(this.lblEstadocivil);
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(this.lblOficiopro);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.lblTipocontrato);
            this.groupBox1.Controls.Add(this.txtPorcSalud);
            this.groupBox1.Controls.Add(this.lvlAfp);
            this.groupBox1.Controls.Add(this.txtPorcAFP);
            this.groupBox1.Controls.Add(this.lblSalud);
            this.groupBox1.Controls.Add(this.lblPorDesc_salud);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblPorDesc_afp);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblProvincia);
            this.groupBox1.Controls.Add(this.txtRun);
            this.groupBox1.Controls.Add(this.lblRegion);
            this.groupBox1.Controls.Add(this.cmbTipocontrato);
            this.groupBox1.Controls.Add(this.lblComuna);
            this.groupBox1.Controls.Add(this.cmbAfp);
            this.groupBox1.Controls.Add(this.txtApellidoM);
            this.groupBox1.Controls.Add(this.cmbSalud);
            this.groupBox1.Controls.Add(this.lblApellidoM);
            this.groupBox1.Controls.Add(this.cmbEstadoCivil);
            this.groupBox1.Controls.Add(this.txtApellidoP);
            this.groupBox1.Controls.Add(this.cmbOficioprofesion);
            this.groupBox1.Controls.Add(this.lblApellidoP);
            this.groupBox1.Location = new System.Drawing.Point(28, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 363);
            this.groupBox1.TabIndex = 148;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Personal";
            // 
            // UCactualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtRunBusqueda);
            this.Name = "UCactualizar";
            this.Size = new System.Drawing.Size(680, 450);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtRunBusqueda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.ComboBox cmbOficioprofesion;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.ComboBox cmbSalud;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.ComboBox cmbAfp;
        private System.Windows.Forms.Label lblComuna;
        private System.Windows.Forms.ComboBox cmbTipocontrato;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblPorDesc_afp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPorDesc_salud;
        private System.Windows.Forms.Label lblSalud;
        private System.Windows.Forms.TextBox txtPorcAFP;
        private System.Windows.Forms.Label lvlAfp;
        private System.Windows.Forms.TextBox txtPorcSalud;
        private System.Windows.Forms.Label lblTipocontrato;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblOficiopro;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblEstadocivil;
        private System.Windows.Forms.ComboBox cmbComuna;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cmbProvidencia;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.ComboBox cmbRegion_;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecnac;
        private System.Windows.Forms.DateTimePicker dtpFecha_nacimiento;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
