using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Fuze.Repository.dll.Formulario;

namespace FuzeFinanceiro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
                Application.Run(new FrmPrincipal());
        }
    }
}
