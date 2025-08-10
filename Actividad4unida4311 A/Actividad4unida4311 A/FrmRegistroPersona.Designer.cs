namespace Actividad4unida4311_A
{
    partial class FrmRegistroPersona
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.Label lblComentarios;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtComentarios;

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvPersonas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();

            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();

            // Labels

            int lblWidth = 100;
            int lblHeight = 20;
            int startX = 10;
            int startY = 10;
            int gapY = 28;

            this.lblNombre.Location = new System.Drawing.Point(startX, startY);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblNombre.Text = "Nombre:";

           

            this.lblEdad.Location = new System.Drawing.Point(startX, startY + gapY * 2);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblEdad.Text = "Edad:";

            this.lblDireccion.Location = new System.Drawing.Point(startX, startY + gapY * 3);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblDireccion.Text = "Dirección:";

            this.lblTelefono.Location = new System.Drawing.Point(startX, startY + gapY * 4);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblTelefono.Text = "Teléfono:";

            this.lblEmail.Location = new System.Drawing.Point(startX, startY + gapY * 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblEmail.Text = "Email:";

            this.lblGenero.Location = new System.Drawing.Point(startX, startY + gapY * 6);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblGenero.Text = "Género:";

            this.lblFechaNacimiento.Location = new System.Drawing.Point(startX, startY + gapY * 7);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblFechaNacimiento.Text = "Fecha Nac.:";

            this.lblNacionalidad.Location = new System.Drawing.Point(startX, startY + gapY * 8);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblNacionalidad.Text = "Nacionalidad:";

            this.lblEstadoCivil.Location = new System.Drawing.Point(startX, startY + gapY * 9);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblEstadoCivil.Text = "Estado Civil:";

            this.lblOcupacion.Location = new System.Drawing.Point(startX, startY + gapY * 10);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblOcupacion.Text = "Ocupación:";

            this.lblComentarios.Location = new System.Drawing.Point(startX, startY + gapY * 11);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(lblWidth, lblHeight);
            this.lblComentarios.Text = "Comentarios:";

            // TextBoxes

            int txtWidth = 150;
            int txtHeight = 22;
            int txtX = startX + lblWidth + 5;

            this.txtNombre.Location = new System.Drawing.Point(txtX, startY);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtApellido.Location = new System.Drawing.Point(txtX, startY + gapY * 1);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtEdad.Location = new System.Drawing.Point(txtX, startY + gapY * 2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtDireccion.Location = new System.Drawing.Point(txtX, startY + gapY * 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtTelefono.Location = new System.Drawing.Point(txtX, startY + gapY * 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtEmail.Location = new System.Drawing.Point(txtX, startY + gapY * 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtGenero.Location = new System.Drawing.Point(txtX, startY + gapY * 6);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtFechaNacimiento.Location = new System.Drawing.Point(txtX, startY + gapY * 7);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtNacionalidad.Location = new System.Drawing.Point(txtX, startY + gapY * 8);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtEstadoCivil.Location = new System.Drawing.Point(txtX, startY + gapY * 9);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtOcupacion.Location = new System.Drawing.Point(txtX, startY + gapY * 10);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(txtWidth, txtHeight);

            this.txtComentarios.Location = new System.Drawing.Point(txtX, startY + gapY * 11);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(txtWidth, txtHeight);

            // Button Registrar

            this.btnRegistrar.Location = new System.Drawing.Point(startX, startY + gapY * 13);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(lblWidth + txtWidth + 5, 30);
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // DataGridView

            this.dgvPersonas.Location = new System.Drawing.Point(txtX + txtWidth + 40, startY);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(700, 350);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Form

            this.ClientSize = new System.Drawing.Size(1150, 400);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.lblComentarios);

            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtEstadoCivil);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.txtComentarios);

            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvPersonas);

            this.Name = "FrmRegistroPersona";
            this.Text = "Registro de Personas";

            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}