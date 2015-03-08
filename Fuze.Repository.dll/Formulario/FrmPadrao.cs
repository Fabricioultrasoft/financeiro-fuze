using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public void btnIncluir_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HabilitaCadastro();
        }

        

        #region Funcionalidades & Controles

        private void HabilitaConsulta()
        {
            PageFormulario.SelectedTabPage = TabConsulta;
            TabCadastro.PageEnabled = false;
            TabCadastro.PageVisible = false;
            TabConsulta.PageEnabled = true;
            TabConsulta.PageVisible = true;
        }

        private void HabilitaCadastro()
        {
            PageFormulario.SelectedTabPage = TabCadastro;
            TabCadastro.PageEnabled = true;
            TabCadastro.PageVisible = true;
            TabConsulta.PageEnabled = false;
            TabConsulta.PageVisible = false;
        }

        private void AtivarAgrupamento()
        {
            GradeView.OptionsView.ShowGroupPanel = !GradeView.OptionsView.ShowGroupPanel;
        }

        private void AtivarFiltro()
        {
            pnlFiltro.Visible = !pnlFiltro.Visible;
        }

        private void SairFormulario()
        {
            Dispose();
        }

        public void Incluir()
        {
            HabilitaCadastro(); 
            
        }
        public void Alterar()
        {
            HabilitaCadastro();

        }
        public void Gravar()
        {
            HabilitaConsulta();

        }
        public void Cancelar()
        {
            HabilitaConsulta();

        }
        #endregion

        #region Açoes do Formulário
        
        private void btnAgrupar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AtivarAgrupamento();
        }

        private void btnFiltro_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AtivarFiltro();
        }

        private void btnSair_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SairFormulario();
        }
        private void btnAlterar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Alterar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        #endregion

        private void BarraNavegacao_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}