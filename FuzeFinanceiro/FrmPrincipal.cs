using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using System.Reflection;

namespace FuzeFinanceiro
{
    public partial class FrmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        #region CONTRUTOR
        public FrmPrincipal()
        {
            
            InitializeComponent();
            Text = "FUZE - Sistema de Gestão Financeira";
            txtVersao.Caption = string.Format("Versão {0}", Assembly.GetExecutingAssembly().GetName().Version);
            InitSkinGallery();

        }
        
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbSkin, true);
        }
        #endregion

        #region EVENTOS 
        private void AbrirForm(Form frm, Boolean modal = false)
        {
            foreach (XtraTabPage p in tbcPrincipal.TabPages) 
            {
                if (p.Text.Equals(frm.Text)) 
                { 
                    tbcPrincipal.SelectedTabPage = p; 
                    return; 
                } 
            }
            if (Modal)
            {
                frm.ShowDialog();
            }
            else
            {
                XtraTabPage t = new XtraTabPage();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                t.Text = frm.Text;
                t.Controls.Add(frm); 
                tbcPrincipal.TabPages.Add(t); 
                tbcPrincipal.SelectedTabPage = t;
            }
        }

        private void tbcPrincipal_CloseButtonClick(object sender, EventArgs e)
        {
            tbcPrincipal.SelectedTabPage.Dispose();
        }

        private void barCidade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AbrirForm(new FrmCidade());
        }
        private void barEstado_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirForm(new FrmEstado());
        }

        private void barPais_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirForm(new FrmTeste());
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Metodo que faz a vericação se a aba encontra-se aberta
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool IsOpened(Type type)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].GetType() == type)
                {
                    Application.OpenForms[i].Focus();
                    return true;
                }
            }
            return false;
        }
        #endregion

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        
    }
}