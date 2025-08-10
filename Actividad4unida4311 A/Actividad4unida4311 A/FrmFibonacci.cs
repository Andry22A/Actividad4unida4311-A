using System;
using System.Text;
using System.Windows.Forms;

namespace PracticaFormularios
{
    public partial class FrmFibonacci : Form
    {
        public FrmFibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            if (!int.TryParse(txtLimite.Text, out int limite))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (limite < 0)
            {
                MessageBox.Show("El límite debe ser un número positivo o cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int a = 0;
            int b = 1;
            StringBuilder serie = new StringBuilder();

            serie.Append(a);

            while (b <= limite)
            {
                serie.Append(", " + b);
                int siguiente = a + b;
                a = b;
                b = siguiente;
            }

            txtResultado.Text = serie.ToString();
        }
    }
}