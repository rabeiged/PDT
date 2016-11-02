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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtPorcSalud = new System.Windows.Forms.TextBox();
            this.txtPorcAFP = new System.Windows.Forms.TextBox();
            this.lblPorDesc_salud = new System.Windows.Forms.Label();
            this.lblPorDesc_afp = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblComuna = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.cmbOficioprofesion = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cmbSalud = new System.Windows.Forms.ComboBox();
            this.cmbAfp = new System.Windows.Forms.ComboBox();
            this.cmbTipocontrato = new System.Windows.Forms.ComboBox();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSalud = new System.Windows.Forms.Label();
            this.lvlAfp = new System.Windows.Forms.Label();
            this.lblTipocontrato = new System.Windows.Forms.Label();
            this.lblOficiopro = new System.Windows.Forms.Label();
            this.lblEstadocivil = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRun = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbProvidencia = new System.Windows.Forms.ComboBox();
            this.cmbComuna = new System.Windows.Forms.ComboBox();
            this.cmbRegion_ = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(510, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 23);
            this.btnBuscar.TabIndex = 112;
            this.btnBuscar.Text = "Buscar Trabajador";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtRunBusqueda
            // 
            this.txtRunBusqueda.Location = new System.Drawing.Point(332, 23);
            this.txtRunBusqueda.Name = "txtRunBusqueda";
            this.txtRunBusqueda.Size = new System.Drawing.Size(159, 20);
            this.txtRunBusqueda.TabIndex = 111;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(291, 407);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(142, 23);
            this.btnActualizar.TabIndex = 98;
            this.btnActualizar.Text = "Actualizar Información";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtPorcSalud
            // 
            this.txtPorcSalud.Location = new System.Drawing.Point(498, 356);
            this.txtPorcSalud.Name = "txtPorcSalud";
            this.txtPorcSalud.Size = new System.Drawing.Size(43, 20);
            this.txtPorcSalud.TabIndex = 146;
            // 
            // txtPorcAFP
            // 
            this.txtPorcAFP.Location = new System.Drawing.Point(498, 301);
            this.txtPorcAFP.Name = "txtPorcAFP";
            this.txtPorcAFP.Size = new System.Drawing.Size(43, 20);
            this.txtPorcAFP.TabIndex = 145;
            // 
            // lblPorDesc_salud
            // 
            this.lblPorDesc_salud.AutoSize = true;
            this.lblPorDesc_salud.Location = new System.Drawing.Point(407, 363);
            this.lblPorDesc_salud.Name = "lblPorDesc_salud";
            this.lblPorDesc_salud.Size = new System.Drawing.Size(45, 13);
            this.lblPorDesc_salud.TabIndex = 144;
            this.lblPorDesc_salud.Text = "% Salud";
            // 
            // lblPorDesc_afp
            // 
            this.lblPorDesc_afp.AutoSize = true;
            this.lblPorDesc_afp.Location = new System.Drawing.Point(407, 306);
            this.lblPorDesc_afp.Name = "lblPorDesc_afp";
            this.lblPorDesc_afp.Size = new System.Drawing.Size(38, 13);
            this.lblPorDesc_afp.TabIndex = 143;
            this.lblPorDesc_afp.Text = "% AFP";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(50, 219);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 140;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(50, 190);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 139;
            this.lblRegion.Text = "Región:";
            // 
            // lblComuna
            // 
            this.lblComuna.AutoSize = true;
            this.lblComuna.Location = new System.Drawing.Point(50, 244);
            this.lblComuna.Name = "lblComuna";
            this.lblComuna.Size = new System.Drawing.Size(49, 13);
            this.lblComuna.TabIndex = 135;
            this.lblComuna.Text = "Comuna:";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(410, 99);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(148, 20);
            this.txtApellidoM.TabIndex = 134;
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(311, 102);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(86, 13);
            this.lblApellidoM.TabIndex = 133;
            this.lblApellidoM.Text = "Apellido Materno";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(174, 99);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(131, 20);
            this.txtApellidoP.TabIndex = 132;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(50, 102);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoP.TabIndex = 131;
            this.lblApellidoP.Text = "Apellido Paterno:";
            // 
            // cmbOficioprofesion
            // 
            this.cmbOficioprofesion.FormattingEnabled = true;
            this.cmbOficioprofesion.Location = new System.Drawing.Point(175, 328);
            this.cmbOficioprofesion.Name = "cmbOficioprofesion";
            this.cmbOficioprofesion.Size = new System.Drawing.Size(121, 21);
            this.cmbOficioprofesion.TabIndex = 130;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(175, 268);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoCivil.TabIndex = 128;
            // 
            // cmbSalud
            // 
            this.cmbSalud.FormattingEnabled = true;
            this.cmbSalud.Location = new System.Drawing.Point(498, 328);
            this.cmbSalud.Name = "cmbSalud";
            this.cmbSalud.Size = new System.Drawing.Size(121, 21);
            this.cmbSalud.TabIndex = 127;
            // 
            // cmbAfp
            // 
            this.cmbAfp.FormattingEnabled = true;
            this.cmbAfp.Location = new System.Drawing.Point(498, 273);
            this.cmbAfp.Name = "cmbAfp";
            this.cmbAfp.Size = new System.Drawing.Size(121, 21);
            this.cmbAfp.TabIndex = 126;
            // 
            // cmbTipocontrato
            // 
            this.cmbTipocontrato.FormattingEnabled = true;
            this.cmbTipocontrato.Location = new System.Drawing.Point(498, 246);
            this.cmbTipocontrato.Name = "cmbTipocontrato";
            this.cmbTipocontrato.Size = new System.Drawing.Size(121, 21);
            this.cmbTipocontrato.TabIndex = 125;
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(174, 130);
            this.txtRun.Name = "txtRun";
            this.txtRun.ReadOnly = true;
            this.txtRun.Size = new System.Drawing.Size(205, 20);
            this.txtRun.TabIndex = 124;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(174, 157);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(457, 20);
            this.txtDireccion.TabIndex = 123;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(384, 20);
            this.txtNombre.TabIndex = 122;
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.Location = new System.Drawing.Point(408, 336);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(37, 13);
            this.lblSalud.TabIndex = 121;
            this.lblSalud.Text = "Salud:";
            // 
            // lvlAfp
            // 
            this.lvlAfp.AutoSize = true;
            this.lvlAfp.Location = new System.Drawing.Point(407, 276);
            this.lvlAfp.Name = "lvlAfp";
            this.lvlAfp.Size = new System.Drawing.Size(30, 13);
            this.lvlAfp.TabIndex = 120;
            this.lvlAfp.Text = "AFP:";
            // 
            // lblTipocontrato
            // 
            this.lblTipocontrato.AutoSize = true;
            this.lblTipocontrato.Location = new System.Drawing.Point(407, 249);
            this.lblTipocontrato.Name = "lblTipocontrato";
            this.lblTipocontrato.Size = new System.Drawing.Size(85, 13);
            this.lblTipocontrato.TabIndex = 119;
            this.lblTipocontrato.Text = "Tipo de contrato";
            // 
            // lblOficiopro
            // 
            this.lblOficiopro.AutoSize = true;
            this.lblOficiopro.Location = new System.Drawing.Point(50, 336);
            this.lblOficiopro.Name = "lblOficiopro";
            this.lblOficiopro.Size = new System.Drawing.Size(89, 13);
            this.lblOficiopro.TabIndex = 117;
            this.lblOficiopro.Text = "Oficio / Profesión";
            // 
            // lblEstadocivil
            // 
            this.lblEstadocivil.AutoSize = true;
            this.lblEstadocivil.Location = new System.Drawing.Point(50, 276);
            this.lblEstadocivil.Name = "lblEstadocivil";
            this.lblEstadocivil.Size = new System.Drawing.Size(62, 13);
            this.lblEstadocivil.TabIndex = 116;
            this.lblEstadocivil.Text = "Estado Civil";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(49, 157);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 115;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(49, 130);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(30, 13);
            this.lblRun.TabIndex = 114;
            this.lblRun.Text = "Run:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 113;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(174, 300);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 148;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(50, 308);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 147;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbProvidencia
            // 
            this.cmbProvidencia.DisplayMember = "id_provincia";
            this.cmbProvidencia.FormattingEnabled = true;
            this.cmbProvidencia.Location = new System.Drawing.Point(174, 214);
            this.cmbProvidencia.Name = "cmbProvidencia";
            this.cmbProvidencia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvidencia.TabIndex = 150;
            this.cmbProvidencia.ValueMember = "id_provincia";
            this.cmbProvidencia.SelectedIndexChanged += new System.EventHandler(this.cmbProvidencia_SelectedIndexChanged);
            // 
            // cmbComuna
            // 
            this.cmbComuna.FormattingEnabled = true;
            this.cmbComuna.Location = new System.Drawing.Point(174, 241);
            this.cmbComuna.Name = "cmbComuna";
            this.cmbComuna.Size = new System.Drawing.Size(121, 21);
            this.cmbComuna.TabIndex = 149;
            // 
            // cmbRegion_
            // 
            this.cmbRegion_.DisplayMember = "Id_region";
            this.cmbRegion_.FormattingEnabled = true;
            this.cmbRegion_.Location = new System.Drawing.Point(175, 187);
            this.cmbRegion_.Name = "cmbRegion_";
            this.cmbRegion_.Size = new System.Drawing.Size(121, 21);
            this.cmbRegion_.TabIndex = 152;
            this.cmbRegion_.ValueMember = "Id_region";
            this.cmbRegion_.SelectedIndexChanged += new System.EventHandler(this.cmbRegion__SelectedIndexChanged);
            this.cmbRegion_.Click += new System.EventHandler(this.cmb_region_click);
            // 
            // UCactualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbRegion_);
            this.Controls.Add(this.cmbProvidencia);
            this.Controls.Add(this.cmbComuna);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtPorcSalud);
            this.Controls.Add(this.txtPorcAFP);
            this.Controls.Add(this.lblPorDesc_salud);
            this.Controls.Add(this.lblPorDesc_afp);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblComuna);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.cmbOficioprofesion);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.cmbSalud);
            this.Controls.Add(this.cmbAfp);
            this.Controls.Add(this.cmbTipocontrato);
            this.Controls.Add(this.txtRun);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSalud);
            this.Controls.Add(this.lvlAfp);
            this.Controls.Add(this.lblTipocontrato);
            this.Controls.Add(this.lblOficiopro);
            this.Controls.Add(this.lblEstadocivil);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblRun);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtRunBusqueda);
            this.Controls.Add(this.btnActualizar);
            this.Name = "UCactualizar";
            this.Size = new System.Drawing.Size(680, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtRunBusqueda;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtPorcSalud;
        private System.Windows.Forms.TextBox txtPorcAFP;
        private System.Windows.Forms.Label lblPorDesc_salud;
        private System.Windows.Forms.Label lblPorDesc_afp;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblComuna;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.ComboBox cmbOficioprofesion;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.ComboBox cmbSalud;
        private System.Windows.Forms.ComboBox cmbAfp;
        private System.Windows.Forms.ComboBox cmbTipocontrato;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSalud;
        private System.Windows.Forms.Label lvlAfp;
        private System.Windows.Forms.Label lblTipocontrato;
        private System.Windows.Forms.Label lblOficiopro;
        private System.Windows.Forms.Label lblEstadocivil;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbProvidencia;
        private System.Windows.Forms.ComboBox cmbComuna;
        private System.Windows.Forms.ComboBox cmbRegion_;
    }
}
