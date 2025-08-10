namespace Actividad4unida4311_A
{
    partial class FrmConversorDivisas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblAMoneda;
        private System.Windows.Forms.Label lblResultadoTexto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbDeMoneda;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cmbAMoneda;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblAMoneda = new System.Windows.Forms.Label();
            this.lblResultadoTexto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbDeMoneda = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbAMoneda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCantidad.Location = new System.Drawing.Point(20, 57);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 29);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMoneda.Location = new System.Drawing.Point(54, 123);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(44, 29);
            this.lblMoneda.TabIndex = 1;
            this.lblMoneda.Text = "De";
            // 
            // lblAMoneda
            // 
            this.lblAMoneda.AutoSize = true;
            this.lblAMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAMoneda.Location = new System.Drawing.Point(54, 187);
            this.lblAMoneda.Name = "lblAMoneda";
            this.lblAMoneda.Size = new System.Drawing.Size(28, 29);
            this.lblAMoneda.TabIndex = 2;
            this.lblAMoneda.Text = "A";
            // 
            // lblResultadoTexto
            // 
            this.lblResultadoTexto.AutoSize = true;
            this.lblResultadoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultadoTexto.Location = new System.Drawing.Point(20, 252);
            this.lblResultadoTexto.Name = "lblResultadoTexto";
            this.lblResultadoTexto.Size = new System.Drawing.Size(122, 29);
            this.lblResultadoTexto.TabIndex = 3;
            this.lblResultadoTexto.Text = "Resultado";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(150, 57);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(169, 35);
            this.txtCantidad.TabIndex = 4;
            // 
            // cmbDeMoneda
            // 
            this.cmbDeMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDeMoneda.FormattingEnabled = true;
            this.cmbDeMoneda.Location = new System.Drawing.Point(150, 120);
            this.cmbDeMoneda.Name = "cmbDeMoneda";
            this.cmbDeMoneda.Size = new System.Drawing.Size(185, 37);
            this.cmbDeMoneda.TabIndex = 5;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConvertir.Location = new System.Drawing.Point(274, 336);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(143, 55);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtResultado.Location = new System.Drawing.Point(150, 252);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(169, 35);
            this.txtResultado.TabIndex = 7;
            // 
            // cmbAMoneda
            // 
            this.cmbAMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbAMoneda.FormattingEnabled = true;
            this.cmbAMoneda.Location = new System.Drawing.Point(150, 184);
            this.cmbAMoneda.Name = "cmbAMoneda";
            this.cmbAMoneda.Size = new System.Drawing.Size(216, 37);
            this.cmbAMoneda.TabIndex = 8;
            // 
            // FrmConversorDivisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.cmbAMoneda);
            this.Controls.Add(this.txtResultado);
        }
    }
}