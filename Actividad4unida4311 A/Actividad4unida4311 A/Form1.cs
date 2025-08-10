using PracticaFormularios;
using System;
using System.Windows.Forms;

namespace Actividad4unida4311_A
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Asegura que el formulario sea MDI container
        }
        private void serieFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFibonacci fibo = new FrmFibonacci();
            fibo.MdiParent = this;
            fibo.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Opcional: Código para ejecutar al cargar el formulario principal
        }

        private void menuRegistroPersona_Click(object sender, EventArgs e)
        {
            // Abrir formulario Registro Persona como hijo MDI
            FrmRegistroPersona frm = new FrmRegistroPersona();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuConversorDivisas_Click(object sender, EventArgs e)
        {
            // Abrir formulario Conversor Divisas como hijo MDI
            FrmConversorDivisas frm = new FrmConversorDivisas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuFibonacci_Click(object sender, EventArgs e)
        {
            // Abrir formulario Fibonacci como hijo MDI
            FrmFibonacci frm = new FrmFibonacci();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}
