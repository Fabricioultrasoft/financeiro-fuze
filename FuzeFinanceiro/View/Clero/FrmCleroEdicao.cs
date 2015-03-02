using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fuze.Repository.dll.Formulario;
using Fuze.Domain.dll.Model.VO;

namespace FuzeFinanceiro.View.Clero
{
    public partial class FrmCleroEdicao : AbsctractForm
    {
        public FrmCleroEdicao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleroVO clero = new CleroVO();
            clero.Descricao = textBox1.Text;
            ValidarCampos(clero);
        }
    }
}
