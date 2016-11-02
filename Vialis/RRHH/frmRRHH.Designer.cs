namespace Vialis.RRHH
{
    partial class frmRRHH
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLiquidacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrrolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabpage1);
            this.tabMain.Location = new System.Drawing.Point(12, 39);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(650, 480);
            this.tabMain.TabIndex = 5;
            // 
            // tabpage1
            // 
            this.tabpage1.Location = new System.Drawing.Point(4, 22);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(642, 454);
            this.tabpage1.TabIndex = 1;
            this.tabpage1.Text = "Inicio";
            this.tabpage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajadoresToolStripMenuItem,
            this.liquidacionesToolStripMenuItem,
            this.enrrolarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTrabajadorToolStripMenuItem,
            this.buscarTrabajadorToolStripMenuItem,
            this.actualizarTrabajadorToolStripMenuItem,
            this.eliminarTrabajadorToolStripMenuItem});
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            // 
            // agregarTrabajadorToolStripMenuItem
            // 
            this.agregarTrabajadorToolStripMenuItem.Name = "agregarTrabajadorToolStripMenuItem";
            this.agregarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarTrabajadorToolStripMenuItem.Text = "Agregar";
            this.agregarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.agregarTrabajadorToolStripMenuItem_Click);
            // 
            // buscarTrabajadorToolStripMenuItem
            // 
            this.buscarTrabajadorToolStripMenuItem.Name = "buscarTrabajadorToolStripMenuItem";
            this.buscarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarTrabajadorToolStripMenuItem.Text = "Buscar";
            this.buscarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.buscarTrabajadorToolStripMenuItem_Click);
            // 
            // actualizarTrabajadorToolStripMenuItem
            // 
            this.actualizarTrabajadorToolStripMenuItem.Name = "actualizarTrabajadorToolStripMenuItem";
            this.actualizarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.actualizarTrabajadorToolStripMenuItem.Text = "Actualizar";
            this.actualizarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.actualizarTrabajadorToolStripMenuItem_Click);
            // 
            // eliminarTrabajadorToolStripMenuItem
            // 
            this.eliminarTrabajadorToolStripMenuItem.Name = "eliminarTrabajadorToolStripMenuItem";
            this.eliminarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarTrabajadorToolStripMenuItem.Text = "Eliminar";
            this.eliminarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.eliminarTrabajadorToolStripMenuItem_Click);
            // 
            // liquidacionesToolStripMenuItem
            // 
            this.liquidacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarLiquidacionToolStripMenuItem});
            this.liquidacionesToolStripMenuItem.Name = "liquidacionesToolStripMenuItem";
            this.liquidacionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.liquidacionesToolStripMenuItem.Text = "Liquidaciones";
            // 
            // buscarLiquidacionToolStripMenuItem
            // 
            this.buscarLiquidacionToolStripMenuItem.Name = "buscarLiquidacionToolStripMenuItem";
            this.buscarLiquidacionToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.buscarLiquidacionToolStripMenuItem.Text = "Buscar";
            this.buscarLiquidacionToolStripMenuItem.Click += new System.EventHandler(this.buscarLiquidacionToolStripMenuItem_Click);
            // 
            // enrrolarToolStripMenuItem
            // 
            this.enrrolarToolStripMenuItem.Name = "enrrolarToolStripMenuItem";
            this.enrrolarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.enrrolarToolStripMenuItem.Text = "Enrrolar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(668, 61);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 531);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmRRHH";
            this.Text = "Vialis - RRHH";
            this.tabMain.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liquidacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrrolarToolStripMenuItem;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolStripMenuItem buscarLiquidacionToolStripMenuItem;
    }
}