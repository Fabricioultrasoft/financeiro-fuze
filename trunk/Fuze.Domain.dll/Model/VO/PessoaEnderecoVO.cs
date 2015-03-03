using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;

namespace Fuze.Domain.dll.Model.VO
{
    public class PessoaEnderecoVO : AbstractVO
    {
        public PessoaVO Pessoa { get; set; }
        public PessoaEnderecoTipoVO PessoaEnderecoTipo { get; set; }
        public CidadeVO Cidade { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public bool? EnderecoPrincipal { get; set; }
        public string Complemento { get; set; }

        public PessoaEnderecoVO()
        {

        }
    }
}
