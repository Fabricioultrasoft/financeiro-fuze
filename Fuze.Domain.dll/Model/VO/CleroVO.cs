using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;

namespace Fuze.Domain.dll.Model.VO
{
    [Serializable]
    public class CleroVO : AbstractVO
    {
        [CampoRequerido]
        public string Descricao { get; set; }

        public CleroVO()
        {

        }
    }
}
