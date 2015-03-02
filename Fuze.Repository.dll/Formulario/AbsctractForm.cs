using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fuze.Repository.dll.Formulario
{
    public abstract class AbsctractForm : Form
    {
        public AbsctractForm()
        {
            
        }

        protected void ValidarCampos(Object obj)
        {
            Mensagem ms = new Mensagem("tttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt");

            var erros = Validacao.Validacao.getErroValidacao(obj);

            foreach (var erro in erros)
                MessageBox.Show(erro.ErrorMessage);
        }
    }
}
