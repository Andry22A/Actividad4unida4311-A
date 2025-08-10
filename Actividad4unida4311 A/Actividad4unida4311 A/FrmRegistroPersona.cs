using System;
using System.Windows.Forms;

namespace Actividad4unida4311_A
{
    public partial class FrmRegistroPersona : Form
    {
        public FrmRegistroPersona()
        {
            InitializeComponent();
            this.Load += FrmRegistroPersona_Load; // Conectar evento Load
        }

        private void FrmRegistroPersona_Load(object sender, EventArgs e)
        {
            // Configurar columnas del DataGridView
            dgvPersonas.ColumnCount = 12;
            dgvPersonas.Columns[0].Name = "Nombre";
            dgvPersonas.Columns[1].Name = "Apellido";
            dgvPersonas.Columns[2].Name = "Edad";
            dgvPersonas.Columns[3].Name = "Dirección";
            dgvPersonas.Columns[4].Name = "Teléfono";
            dgvPersonas.Columns[5].Name = "Email";
            dgvPersonas.Columns[6].Name = "Género";
            dgvPersonas.Columns[7].Name = "Fecha Nacimiento";
            dgvPersonas.Columns[8].Name = "Nacionalidad";
            dgvPersonas.Columns[9].Name = "Estado Civil";
            dgvPersonas.Columns[10].Name = "Ocupación";
            dgvPersonas.Columns[11].Name = "Comentarios";

            // Ajustar tamaño de columnas
            dgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("Por favor, complete Nombre, Apellido y Edad.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que edad sea número válido
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Edad debe ser un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar datos al DataGridView
            string[] fila = new string[]
            {
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                edad.ToString(),
                txtDireccion.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtEmail.Text.Trim(),
                txtGenero.Text.Trim(),
                txtFechaNacimiento.Text.Trim(),
                txtNacionalidad.Text.Trim(),
                txtEstadoCivil.Text.Trim(),
                txtOcupacion.Text.Trim(),
                txtComentarios.Text.Trim()
            };

            dgvPersonas.Rows.Add(fila);

            // Limpiar campos para el próximo registro
            LimpiarCampos();

            MessageBox.Show("Registro agregado con éxito.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtGenero.Clear();
            txtFechaNacimiento.Clear();
            txtNacionalidad.Clear();
            txtEstadoCivil.Clear();
            txtOcupacion.Clear();
            txtComentarios.Clear();

            txtNombre.Focus();
        }

        // Los demás métodos de eventos vacíos pueden quedar así o eliminarse si no se usan
    }
}
