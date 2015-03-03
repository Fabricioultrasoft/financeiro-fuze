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
    public class CleroBE : AbstractBE<CleroVO>
    {
        public CleroBE()
            : base()
        {
        }

        public CleroBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(CleroVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(CleroVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(CleroVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(CleroVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<CleroVO> GetLista(CleroVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
