using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Controller.BE;
using System.Data.SqlClient;
using Fuze.Domain.dll.Model.VO;
using Fuze.Domain.dll.Model.DAO;

namespace Fuze.Domain.dll.Controller.BE
{
    public class CidadeBE : AbstractBE<CidadeVO>
    {
        public CidadeBE()
            : base()
        {
        }

        public CidadeBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(CidadeVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(CidadeVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(CidadeVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(CidadeVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<CidadeVO> GetLista(CidadeVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
