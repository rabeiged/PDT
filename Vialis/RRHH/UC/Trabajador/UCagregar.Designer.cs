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
            this.components = new System.ComponentModel.Container();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipocontrato = new System.Windows.Forms.Label();
            this.cmbTipocontrato = new System.Windows.Forms.ComboBox();
            this.epRun = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPorcAFP = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApParterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApMaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPorcSalud = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPorcAFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApParterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApMaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPorcSalud)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComuna
            // 
            this.lblComuna.AutoSize = true;
            this.lblComuna.Location = new System.Drawing.Point(17, 201);
            this.lblComuna.Name = "lblComuna";
            this.lblComuna.Size = new System.Drawing.Size(49, 13);
            this.lblComuna.TabIndex = 79;
            this.lblComuna.Text = "Comuna:";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(355, 93);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoM.TabIndex = 3;
            this.txtApellidoM.Validated += new System.EventHandler(this.txtApellidoM_Validated);
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(263, 96);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoM.TabIndex = 77;
            this.lblApellidoM.Text = "Apellido Materno:";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(119, 92);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoP.TabIndex = 2;
            this.txtApellidoP.Validated += new System.EventHandler(this.txtApellidoP_Validated);
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(16, 97);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoP.TabIndex = 75;
            this.lblApellidoP.Text = "Apellido Paterno:";
            // 
            // cmbOficioprofesion
            // 
            this.cmbOficioprofesion.FormattingEnabled = true;
            this.cmbOficioprofesion.Location = new System.Drawing.Point(119, 272);
            this.cmbOficioprofesion.Name = "cmbOficioprofesion";
            this.cmbOficioprofesion.Size = new System.Drawing.Size(121, 21);
            this.cmbOficioprofesion.TabIndex = 12;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(119, 220);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoCivil.TabIndex = 10;
            // 
            // cmbAfp
            // 
            this.cmbAfp.FormattingEnabled = true;
            this.cmbAfp.Location = new System.Drawing.Point(355, 199);
            this.cmbAfp.Name = "cmbAfp";
            this.cmbAfp.Size = new System.Drawing.Size(121, 21);
            this.cmbAfp.TabIndex = 14;
            this.cmbAfp.Click += new System.EventHandler(this.cmbAFP_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(355, 324);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Registrar trabajador";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(119, 42);
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(121, 20);
            this.txtRun.TabIndex = 1;
            this.txtRun.Validated += new System.EventHandler(this.txtRun_Validated);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(119, 117);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(357, 20);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.Validated += new System.EventHandler(this.txtDireccion_Validated);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(357, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.Location = new System.Drawing.Point(264, 254);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(37, 13);
            this.lblSalud.TabIndex = 64;
            this.lblSalud.Text = "Salud:";
            // 
            // lvlAfp
            // 
            this.lvlAfp.AutoSize = true;
            this.lvlAfp.Location = new System.Drawing.Point(264, 200);
            this.lvlAfp.Name = "lvlAfp";
            this.lvlAfp.Size = new System.Drawing.Size(30, 13);
            this.lvlAfp.TabIndex = 63;
            this.lvlAfp.Text = "AFP:";
            // 
            // lblOficiopro
            // 
            this.lblOficiopro.AutoSize = true;
            this.lblOficiopro.Location = new System.Drawing.Point(17, 275);
            this.lblOficiopro.Name = "lblOficiopro";
            this.lblOficiopro.Size = new System.Drawing.Size(92, 13);
            this.lblOficiopro.TabIndex = 60;
            this.lblOficiopro.Text = "Oficio / Profesión:";
            // 
            // lblEstadocivil
            // 
            this.lblEstadocivil.AutoSize = true;
            this.lblEstadocivil.Location = new System.Drawing.Point(17, 227);
            this.lblEstadocivil.Name = "lblEstadocivil";
            this.lblEstadocivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadocivil.TabIndex = 59;
            this.lblEstadocivil.Text = "Estado Civil:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 123);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 58;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(17, 45);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(30, 13);
            this.lblRun.TabIndex = 57;
            this.lblRun.Text = "Run:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 56;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(17, 149);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 83;
            this.lblRegion.Text = "Región:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(16, 175);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 84;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cmbRegion
            // 
            this.cmbRegion.DisplayMember = "Id_region";
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(119, 142);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(121, 21);
            this.cmbRegion.TabIndex = 7;
            this.cmbRegion.ValueMember = "Id_region";
            this.cmbRegion.SelectedIndexChanged += new System.EventHandler(this.cmbRegion_SelectedIndexChanged);
            this.cmbRegion.Click += new System.EventHandler(this.cmbRegion_Click);
            // 
            // lblPorDesc_afp
            // 
            this.lblPorDesc_afp.AutoSize = true;
            this.lblPorDesc_afp.Location = new System.Drawing.Point(264, 227);
            this.lblPorDesc_afp.Name = "lblPorDesc_afp";
            this.lblPorDesc_afp.Size = new System.Drawing.Size(41, 13);
            this.lblPorDesc_afp.TabIndex = 87;
            this.lblPorDesc_afp.Text = "% AFP:";
            // 
            // lblPorDesc_salud
            // 
            this.lblPorDesc_salud.AutoSize = true;
            this.lblPorDesc_salud.Location = new System.Drawing.Point(264, 281);
            this.lblPorDesc_salud.Name = "lblPorDesc_salud";
            this.lblPorDesc_salud.Size = new System.Drawing.Size(48, 13);
            this.lblPorDesc_salud.TabIndex = 88;
            this.lblPorDesc_salud.Text = "% Salud:";
            // 
            // txtPorcAFP
            // 
            this.txtPorcAFP.Location = new System.Drawing.Point(355, 226);
            this.txtPorcAFP.Name = "txtPorcAFP";
            this.txtPorcAFP.Size = new System.Drawing.Size(121, 20);
            this.txtPorcAFP.TabIndex = 15;
            this.txtPorcAFP.Text = "0";
            this.txtPorcAFP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcAFP_KeyPress);
            // 
            // txtPorcSalud
            // 
            this.txtPorcSalud.Location = new System.Drawing.Point(355, 279);
            this.txtPorcSalud.Name = "txtPorcSalud";
            this.txtPorcSalud.Size = new System.Drawing.Size(121, 20);
            this.txtPorcSalud.TabIndex = 17;
            this.txtPorcSalud.Text = "0";
            this.txtPorcSalud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcSalud_KeyPress);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(17, 253);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 91;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(119, 246);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 11;
            // 
            // lblFecnac
            // 
            this.lblFecnac.AutoSize = true;
            this.lblFecnac.Location = new System.Drawing.Point(264, 146);
            this.lblFecnac.Name = "lblFecnac";
            this.lblFecnac.Size = new System.Drawing.Size(94, 13);
            this.lblFecnac.TabIndex = 94;
            this.lblFecnac.Text = "Fecha nacimiento:";
            // 
            // dtpFecha_nacimiento
            // 
            this.dtpFecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_nacimiento.Location = new System.Drawing.Point(355, 146);
            this.dtpFecha_nacimiento.Name = "dtpFecha_nacimiento";
            this.dtpFecha_nacimiento.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha_nacimiento.TabIndex = 13;
            // 
            // cmbSalud
            // 
            this.cmbSalud.FormattingEnabled = true;
            this.cmbSalud.Location = new System.Drawing.Point(355, 252);
            this.cmbSalud.Name = "cmbSalud";
            this.cmbSalud.Size = new System.Drawing.Size(121, 21);
            this.cmbSalud.TabIndex = 16;
            this.cmbSalud.Click += new System.EventHandler(this.cmbSalud_Click);
            // 
            // cmbComuna
            // 
            this.cmbComuna.FormattingEnabled = true;
            this.cmbComuna.Location = new System.Drawing.Point(119, 194);
            this.cmbComuna.Name = "cmbComuna";
            this.cmbComuna.Size = new System.Drawing.Size(121, 21);
            this.cmbComuna.TabIndex = 9;
            // 
            // cmbProvidencia
            // 
            this.cmbProvidencia.DisplayMember = "id_provincia";
            this.cmbProvidencia.FormattingEnabled = true;
            this.cmbProvidencia.Location = new System.Drawing.Point(119, 168);
            this.cmbProvidencia.Name = "cmbProvidencia";
            this.cmbProvidencia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvidencia.TabIndex = 8;
            this.cmbProvidencia.ValueMember = "id_provincia";
            this.cmbProvidencia.SelectedIndexChanged += new System.EventHandler(this.cmbProvidencia_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipocontrato);
            this.groupBox1.Controls.Add(this.cmbTipocontrato);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblPorDesc_afp);
            this.groupBox1.Controls.Add(this.cmbSalud);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblApellidoM);
            this.groupBox1.Controls.Add(this.txtRun);
            this.groupBox1.Controls.Add(this.lblPorDesc_salud);
            this.groupBox1.Controls.Add(this.txtApellidoM);
            this.groupBox1.Controls.Add(this.cmbRegion);
            this.groupBox1.Controls.Add(this.dtpFecha_nacimiento);
            this.groupBox1.Controls.Add(this.lblSalud);
            this.groupBox1.Controls.Add(this.txtApellidoP);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.lblRun);
            this.groupBox1.Controls.Add(this.txtPorcAFP);
            this.groupBox1.Controls.Add(this.lblComuna);
            this.groupBox1.Controls.Add(this.cmbProvidencia);
            this.groupBox1.Controls.Add(this.lblFecnac);
            this.groupBox1.Controls.Add(this.lvlAfp);
            this.groupBox1.Controls.Add(this.lblApellidoP);
            this.groupBox1.Controls.Add(this.cmbAfp);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.txtPorcSalud);
            this.groupBox1.Controls.Add(this.cmbComuna);
            this.groupBox1.Controls.Add(this.lblProvincia);
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(this.lblOficiopro);
            this.groupBox1.Controls.Add(this.cmbOficioprofesion);
            this.groupBox1.Controls.Add(this.cmbEstadoCivil);
            this.groupBox1.Controls.Add(this.lblEstadocivil);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.lblRegion);
            this.groupBox1.Location = new System.Drawing.Point(28, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 363);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Personal";
            // 
            // lblTipocontrato
            // 
            this.lblTipocontrato.AutoSize = true;
            this.lblTipocontrato.Location = new System.Drawing.Point(264, 173);
            this.lblTipocontrato.Name = "lblTipocontrato";
            this.lblTipocontrato.Size = new System.Drawing.Size(88, 13);
            this.lblTipocontrato.TabIndex = 121;
            this.lblTipocontrato.Text = "Tipo de contrato:";
            // 
            // cmbTipocontrato
            // 
            this.cmbTipocontrato.FormattingEnabled = true;
            this.cmbTipocontrato.Location = new System.Drawing.Point(355, 172);
            this.cmbTipocontrato.Name = "cmbTipocontrato";
            this.cmbTipocontrato.Size = new System.Drawing.Size(121, 21);
            this.cmbTipocontrato.TabIndex = 120;
            // 
            // epRun
            // 
            this.epRun.ContainerControl = this;
            // 
            // epNombre
            // 
            this.epNombre.ContainerControl = this;
            // 
            // epPorcAFP
            // 
            this.epPorcAFP.ContainerControl = this;
            // 
            // epApParterno
            // 
            this.epApParterno.ContainerControl = this;
            // 
            // epApMaterno
            // 
            this.epApMaterno.ContainerControl = this;
            // 
            // epDireccion
            // 
            this.epDireccion.ContainerControl = this;
            // 
            // epPorcSalud
            // 
            this.epPorcSalud.ContainerControl = this;
            // 
            // UCagregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCagregar";
            this.Size = new System.Drawing.Size(680, 450);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPorcAFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApParterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApMaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPorcSalud)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTipocontrato;
        private System.Windows.Forms.ComboBox cmbTipocontrato;
        private System.Windows.Forms.ErrorProvider epRun;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epPorcAFP;
        private System.Windows.Forms.ErrorProvider epApParterno;
        private System.Windows.Forms.ErrorProvider epApMaterno;
        private System.Windows.Forms.ErrorProvider epDireccion;
        private System.Windows.Forms.ErrorProvider epPorcSalud;
    }
}
