namespace Actividad4unida4311_A
{
    partial class FrmMenuprincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroDePersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversorDeDivisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDePersonasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroDePersonasToolStripMenuItem
            // 
            this.registroDePersonasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversorDeDivisasToolStripMenuItem,
            this.serieFibonacciToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.registroDePersonasToolStripMenuItem.Name = "registroDePersonasToolStripMenuItem";
            this.registroDePersonasToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.registroDePersonasToolStripMenuItem.Text = "Registro de personas";
            // 
            // conversorDeDivisasToolStripMenuItem
            // 
            this.conversorDeDivisasToolStripMenuItem.Name = "conversorDeDivisasToolStripMenuItem";
            this.conversorDeDivisasToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.conversorDeDivisasToolStripMenuItem.Text = "Conversor de Divisas";
            // 
            // serieFibonacciToolStripMenuItem
            // 
            this.serieFibonacciToolStripMenuItem.Name = "serieFibonacciToolStripMenuItem";
            this.serieFibonacciToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.serieFibonacciToolStripMenuItem.Text = "Serie Fibonacci";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // FrmMenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuprincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroDePersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversorDeDivisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieFibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}