using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FuzeFinanceiro.View;
using FuzeFinanceiro.View.Tabela;
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
<<<<<<< .mine
            Application.Run(new FrmTipoDocumentoFoto());
=======
            //Application.Run(new FrmLogin());
            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
                Application.Run(new FrmPrincipal());



>>>>>>> .r24
        }
    }
}
