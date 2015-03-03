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
    public class PaisBE : AbstractBE<PaisVO>
    {
        public PaisBE()
            : base()
        {
        }

        public PaisBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(PaisVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PaisVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PaisVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PaisVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PaisVO> GetLista(PaisVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
