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
    public class PaisDAO : AbstractDAO<PaisVO>
    {
        public PaisDAO(SqlCommand sqlCommand)
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
