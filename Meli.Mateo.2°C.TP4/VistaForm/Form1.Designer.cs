namespace VistaForm
{
    partial class FarmaciaElPepe
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmaciaElPepe));
            this.textBoxPresentacion = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPresentacion
            // 
            this.textBoxPresentacion.BackColor = System.Drawing.Color.White;
            this.textBoxPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPresentacion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxPresentacion.Enabled = false;
            this.textBoxPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPresentacion.Location = new System.Drawing.Point(159, 32);
            this.textBoxPresentacion.Multiline = true;
            this.textBoxPresentacion.Name = "textBoxPresentacion";
            this.textBoxPresentacion.ReadOnly = true;
            this.textBoxPresentacion.Size = new System.Drawing.Size(494, 94);
            this.textBoxPresentacion.TabIndex = 0;
            this.textBoxPresentacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(250, 250);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(286, 95);
            this.buttonIngresar.TabIndex = 1;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.btnIngresar_OnClick);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(250, 377);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(286, 23);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.btnCerrar_OnClick);
            // 
            // FarmaciaElPepe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxPresentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FarmaciaElPepe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPresentacion;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonCerrar;
    }
}

