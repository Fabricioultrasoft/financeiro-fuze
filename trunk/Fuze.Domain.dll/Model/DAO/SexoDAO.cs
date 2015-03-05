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
    public class SexoDAO : AbstractDAO<SexoVO>
    {
        public SexoDAO(SqlCommand sqlCommand)
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

        protected override string GetSQLConsulta(SexoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(SexoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(SexoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
