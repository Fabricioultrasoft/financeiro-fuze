using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fuze.Repository.dll.Formulario
{
    public partial class Mensagem : Form
    {
        public Mensagem()
        {
            InitializeComponent();
        }

        public Mensagem(string texto)
        {
            InitializeComponent();
            label1.Text = texto;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
