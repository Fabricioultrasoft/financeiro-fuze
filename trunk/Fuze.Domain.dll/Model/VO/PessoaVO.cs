using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;

namespace Fuze.Domain.dll.Model.VO
{
    public class PessoaVO : AbstractVO
    {
        public PessoaTipoVO PessoaTipo { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }

        public PessoaVO()
        {
            PessoaTipo = new PessoaTipoVO();
        }
    }
}
