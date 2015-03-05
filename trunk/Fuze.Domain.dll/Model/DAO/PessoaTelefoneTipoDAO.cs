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
    public class PessoaTelefoneTipoDAO : AbstractDAO<PessoaTelefoneTipoVO>
    {
        public PessoaTelefoneTipoDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaTelefoneTipoVO> GetLista(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override string GetSQLConsulta(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
