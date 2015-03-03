using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;

namespace Fuze.Domain.dll.Model.VO
{
    [Serializable]
    public class PessoaJuridicaVO : PessoaVO
    {   
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string IncricaoMunicipal { get; set; }
        public string RazaoSocial { get; set; }

        public PessoaJuridicaVO()
        {

        }
    }
}
