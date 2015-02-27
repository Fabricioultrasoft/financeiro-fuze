using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;

namespace Fuze.Domain.dll.Model.VO
{
    public class EstadoVO : AbstractVO
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public PaisVO Pais { get; set; }

        public EstadoVO()
        {
            Pais = new PaisVO();
        }
    }
}
