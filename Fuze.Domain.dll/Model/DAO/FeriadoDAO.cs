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
    public class FeriadoDAO : AbstractDAO<FeriadoVO>
    {
        public FeriadoDAO(SqlCommand sqlCommand)
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

        protected override string GetSQLConsulta(FeriadoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(FeriadoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(FeriadoVO clero)
        {
            throw new NotImplementedException();
        }
    }
}
