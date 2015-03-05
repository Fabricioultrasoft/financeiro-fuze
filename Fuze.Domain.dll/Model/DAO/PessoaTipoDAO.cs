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
    public class PessoaTipoDAO : AbstractDAO<PessoaTipoVO>
    {
        public PessoaTipoDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaTipoVO> GetLista(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override string GetSQLConsulta(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
