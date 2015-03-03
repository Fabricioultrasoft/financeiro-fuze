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
    public class SexoBE : AbstractBE<SexoVO>
    {
        public SexoBE()
            : base()
        {
        }

        public SexoBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(SexoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(SexoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(SexoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(SexoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<SexoVO> GetLista(SexoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
