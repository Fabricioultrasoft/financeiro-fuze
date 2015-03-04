using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Fuze.Repository.dll.Formulario
{
    public partial class FrmPadrao : DevExpress.XtraEditors.XtraForm
    {
        public FrmPadrao()
        {
            InitializeComponent();
        }

        private void btnIncluir_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PageFormulario.SelectedTabPage = TabCadastro;
        }
    }
}