using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;
using System.ComponentModel.DataAnnotations;

namespace Fuze.Domain.dll.Model.VO
{
    [Serializable]
    public class CleroVO : AbstractVO
    {
        [Required(ErrorMessage="Por favor informe o campo descrição", AllowEmptyStrings=false)]
        [Display(Name="Descrição", Description="Descrição do Clero")]
        [StringLength(250, MinimumLength=5, ErrorMessage="Tamanho invalido")]
        public string Descricao { get; set; }

        public CleroVO()
        {

        }
    }
}
