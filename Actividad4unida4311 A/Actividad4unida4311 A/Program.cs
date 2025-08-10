using System;
using System.Windows.Forms;

namespace Actividad4unida4311_A
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());  // Cambia aquí al nombre real de tu formulario menú principal
        }
    }
}