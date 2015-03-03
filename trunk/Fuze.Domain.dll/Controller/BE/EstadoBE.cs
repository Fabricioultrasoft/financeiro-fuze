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
    public class EstadoBE : AbstractBE<EstadoVO>
    {
        public EstadoBE()
            : base()
        {
        }

        public EstadoBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<EstadoVO> GetLista(EstadoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
