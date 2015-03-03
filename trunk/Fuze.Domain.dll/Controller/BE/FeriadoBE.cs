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
    public class FeriadoBE : AbstractBE<FeriadoVO>
    {
        public FeriadoBE()
            : base()
        {
        }

        public FeriadoBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(FeriadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(FeriadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(FeriadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(FeriadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<FeriadoVO> GetLista(FeriadoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
