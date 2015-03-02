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
        public int MyProperty { get; set; }
    }
}
