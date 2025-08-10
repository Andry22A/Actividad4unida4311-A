using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Actividad4unida4311_A
{
    public partial class FrmConversorDivisas : Form
    {
        // Diccionario con tasas de cambio fijas respecto a USD
        private readonly Dictionary<string, double> tasasCambio = new Dictionary<string, double>()
        {
            { "USD", 1.0 },
            { "EUR", 0.91 },
            { "DOP", 54.50 },
            { "MXN", 17.80 }
        };

        public FrmConversorDivisas()
        {
            InitializeComponent();
        }

        private void FrmConversorDivisas_Load(object sender, EventArgs e)
        {
            // Cargar monedas en ComboBoxes
            cmbDeMoneda.Items.AddRange(new object[] { "USD", "EUR", "DOP", "MXN" });
            cmbAMoneda.Items.AddRange(new object[] { "USD", "EUR", "DOP", "MXN" });

            // Seleccionar por defecto la primera opción
            cmbDeMoneda.SelectedIndex = 0;
            cmbAMoneda.SelectedIndex = 0;

            // Dejar txtResultado solo lectura
            txtResultado.ReadOnly = true;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCantidad.Text, out double cantidad) || cantidad < 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida mayor o igual a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
                return;
            }

            string monedaOrigen = cmbDeMoneda.SelectedItem?.ToString();
            string monedaDestino = cmbAMoneda.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(monedaOrigen) || string.IsNullOrEmpty(monedaDestino))
            {
                MessageBox.Show("Por favor, selecciona las monedas de origen y destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir a USD, luego a moneda destino
            double cantidadEnUSD = cantidad / tasasCambio[monedaOrigen];
            double resultado = cantidadEnUSD * tasasCambio[monedaDestino];

            txtResultado.Text = $"{resultado:F2} {monedaDestino}";
        }
    }
}