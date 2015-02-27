using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fuze.Domain.dll.Model.VO;
using Fuze.Domain.dll.Controller.BE;

namespace FuzeFinanceiro
{
    public partial class Teste : Form
    {
        private CleroVO Clero { get; set; }

        public Teste()
        {
            InitializeComponent();
            if (Clero == null) Clero = new CleroVO();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CleroBE be = null;
            try
            {
                Clero.Descricao = txtDescricao.Text;

                be = new CleroBE();
                be.Inserir(Clero);

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (be != null)
                    be.FecharConexao();
            }

        }
    }
}
