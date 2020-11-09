namespace VistaForm
{
    partial class Venta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelProducto = new System.Windows.Forms.Label();
            this.tipoProdctoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPrecio = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.listBoxProducto = new System.Windows.Forms.ListBox();
            this.listBoxTipoPago = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdctoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            resources.ApplyResources(this.labelNombre, "labelNombre");
            this.labelNombre.Name = "labelNombre";
            // 
            // textBoxNombre
            // 
            resources.ApplyResources(this.textBoxNombre, "textBoxNombre");
            this.textBoxNombre.Name = "textBoxNombre";
            // 
            // labelApellido
            // 
            resources.ApplyResources(this.labelApellido, "labelApellido");
            this.labelApellido.Name = "labelApellido";
            // 
            // textBoxApellido
            // 
            resources.ApplyResources(this.textBoxApellido, "textBoxApellido");
            this.textBoxApellido.Name = "textBoxApellido";
            // 
            // labelProducto
            // 
            resources.ApplyResources(this.labelProducto, "labelProducto");
            this.labelProducto.Name = "labelProducto";
            // 
            // tipoProdctoBindingSource
            // 
            this.tipoProdctoBindingSource.DataSource = typeof(Productos.Articulo.TipoProducto);
            // 
            // labelPrecio
            // 
            resources.ApplyResources(this.labelPrecio, "labelPrecio");
            this.labelPrecio.Name = "labelPrecio";
            // 
            // buttonAceptar
            // 
            resources.ApplyResources(this.buttonAceptar, "buttonAceptar");
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.btnAceptar_OnClick);
            // 
            // listBoxProducto
            // 
            this.listBoxProducto.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxProducto, "listBoxProducto");
            this.listBoxProducto.Name = "listBoxProducto";
            // 
            // listBoxTipoPago
            // 
            this.listBoxTipoPago.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxTipoPago, "listBoxTipoPago");
            this.listBoxTipoPago.Name = "listBoxTipoPago";
            // 
            // Venta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxTipoPago);
            this.Controls.Add(this.listBoxProducto);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Venta";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdctoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.BindingSource tipoProdctoBindingSource;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ListBox listBoxProducto;
        private System.Windows.Forms.ListBox listBoxTipoPago;
    }
}