using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;
using Fuze.Domain.dll.Abstracts.Model.DAO;
using Fuze.Domain.dll.Model.VO;
using System.Data.SqlClient;

namespace Fuze.Domain.dll.Model.DAO
{
    public class EstadoCivilDAO : AbstractDAO<EstadoCivilVO>
    {
        public EstadoCivilDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(EstadoCivilVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(EstadoCivilVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(EstadoCivilVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(EstadoCivilVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<EstadoCivilVO> GetLista(EstadoCivilVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
