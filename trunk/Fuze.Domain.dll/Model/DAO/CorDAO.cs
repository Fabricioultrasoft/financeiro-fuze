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
    public class CorDAO : AbstractDAO<CorVO>
    {
        public CorDAO(SqlCommand sqlCommand)
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

        protected override string GetSQLConsulta(CorVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(CorVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(CorVO clero)
        {
            throw new NotImplementedException();
        }
    }
}
