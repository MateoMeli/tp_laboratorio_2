namespace VistaForm
{
    partial class VentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaForm));
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.listBoxProducto = new System.Windows.Forms.ListBox();
            this.listBoxTipoPago = new System.Windows.Forms.ListBox();
            this.richTextBoxVentas = new System.Windows.Forms.RichTextBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
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
            this.buttonAceptar.Click += new System.EventHandler(this.BtnAceptar_OnClick);
            // 
            // listBoxProducto
            // 
            resources.ApplyResources(this.listBoxProducto, "listBoxProducto");
            this.listBoxProducto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxProducto.FormattingEnabled = true;
            this.listBoxProducto.Items.AddRange(new object[] {
            resources.GetString("listBoxProducto.Items"),
            resources.GetString("listBoxProducto.Items1"),
            resources.GetString("listBoxProducto.Items2")});
            this.listBoxProducto.Name = "listBoxProducto";
            // 
            // listBoxTipoPago
            // 
            resources.ApplyResources(this.listBoxTipoPago, "listBoxTipoPago");
            this.listBoxTipoPago.FormattingEnabled = true;
            this.listBoxTipoPago.Items.AddRange(new object[] {
            resources.GetString("listBoxTipoPago.Items"),
            resources.GetString("listBoxTipoPago.Items1"),
            resources.GetString("listBoxTipoPago.Items2")});
            this.listBoxTipoPago.Name = "listBoxTipoPago";
            // 
            // richTextBoxVentas
            // 
            this.richTextBoxVentas.BackColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.richTextBoxVentas, "richTextBoxVentas");
            this.richTextBoxVentas.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxVentas.Name = "richTextBoxVentas";
            this.richTextBoxVentas.ReadOnly = true;
            // 
            // btnTicket
            // 
            resources.ApplyResources(this.btnTicket, "btnTicket");
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.BtnTicket_Click);
            // 
            // btnInforme
            // 
            resources.ApplyResources(this.btnInforme, "btnInforme");
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // Venta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.richTextBoxVentas);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Venta_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ListBox listBoxProducto;
        private System.Windows.Forms.ListBox listBoxTipoPago;
        private System.Windows.Forms.RichTextBox richTextBoxVentas;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnInforme;
    }
}