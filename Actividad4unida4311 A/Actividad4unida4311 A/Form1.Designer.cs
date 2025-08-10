namespace Actividad4unida4311_A
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuRegistroPersona = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConversorDivisas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFibonacci = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegistroPersona});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuRegistroPersona
            // 
            this.menuRegistroPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuRegistroPersona.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConversorDivisas,
            this.menuFibonacci,
            this.menuSalir});
            this.menuRegistroPersona.Name = "menuRegistroPersona";
            this.menuRegistroPersona.Size = new System.Drawing.Size(195, 29);
            this.menuRegistroPersona.Text = "Registro de personas";
            this.menuRegistroPersona.Click += new System.EventHandler(this.menuRegistroPersona_Click);
            // 
            // menuConversorDivisas
            // 
            this.menuConversorDivisas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuConversorDivisas.Name = "menuConversorDivisas";
            this.menuConversorDivisas.Size = new System.Drawing.Size(270, 34);
            this.menuConversorDivisas.Text = "Conversor Divisas";
            this.menuConversorDivisas.Click += new System.EventHandler(this.menuConversorDivisas_Click);
            // 
            // menuFibonacci
            // 
            this.menuFibonacci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuFibonacci.Name = "menuFibonacci";
            this.menuFibonacci.Size = new System.Drawing.Size(270, 34);
            this.menuFibonacci.Text = "Fibonacci";
            this.menuFibonacci.Click += new System.EventHandler(this.menuFibonacci_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(270, 34);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuRegistroPersona;
        private System.Windows.Forms.ToolStripMenuItem menuConversorDivisas;
        private System.Windows.Forms.ToolStripMenuItem menuFibonacci;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
    }
}

