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
    public class TipoDocumentoFotoDAO : AbstractDAO<TipoDocumentoFotoVO>
    {
        public TipoDocumentoFotoDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<TipoDocumentoFotoVO> GetLista(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override string GetSQLConsulta(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(TipoDocumentoFotoVO clero)
        {
            throw new NotImplementedException();
        }
    }
}
