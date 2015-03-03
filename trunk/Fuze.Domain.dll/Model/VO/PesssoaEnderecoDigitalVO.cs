using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;

namespace Fuze.Domain.dll.Model.VO
{
    [Serializable]
    public class PesssoaEnderecoDigitalVO : AbstractVO
    {
        public PessoaEnderecoDigitalTipoVO PessoaEnderecoDigitalTipo { get; set; }
        public PessoaVO Pessoa { get; set; }
        public string Descricao { get; set; }

        public PesssoaEnderecoDigitalVO()
        {

        }
    }
}
