using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;
using System.Data.SqlClient;
using Fuze.Domain.dll.Abstracts.Model.DAO;
using Fuze.Domain.dll.Model.VO;

namespace Fuze.Domain.dll.Model.DAO
{
    public class CidadeDAO : AbstractDAO<CidadeVO>
    {
        public CidadeDAO(SqlCommand sqlCommand)
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
