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
    public class FeriadoTipoDAO : AbstractDAO<FeriadoTipoVO>
    {
        public FeriadoTipoDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<FeriadoTipoVO> GetLista(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override string GetSQLConsulta(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
