using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;

namespace Fuze.Domain.dll.Model.VO
{
    [Serializable]
    public class CidadeVO : AbstractVO
    {
        public string Nome { get; set; }
        public EstadoVO Estado { get; set; }

        public CidadeVO()
        {
            Estado = new EstadoVO();
        }
    }
}
