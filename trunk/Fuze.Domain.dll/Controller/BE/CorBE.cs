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
    public class CorBE : AbstractBE<CorVO>
    {
        public CorBE()
            : base()
        {
        }

        public CorBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(CorVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(CorVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(CorVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(CorVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<CorVO> GetLista(CorVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
