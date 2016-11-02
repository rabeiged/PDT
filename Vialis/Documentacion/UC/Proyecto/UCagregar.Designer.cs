namespace Vialis.Documentacion.UC.Proyecto
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
            this.btnTrabajador = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrabajador
            // 
            this.btnTrabajador.Location = new System.Drawing.Point(42, 30);
            this.btnTrabajador.Name = "btnTrabajador";
            this.btnTrabajador.Size = new System.Drawing.Size(75, 23);
            this.btnTrabajador.TabIndex = 0;
            this.btnTrabajador.Text = "Trabajador";
            this.btnTrabajador.UseVisualStyleBackColor = true;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(156, 30);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnMaterial.TabIndex = 1;
            this.btnMaterial.Text = "Material";
            this.btnMaterial.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // UCagregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnTrabajador);
            this.Name = "UCagregar";
            this.Size = new System.Drawing.Size(680, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrabajador;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
