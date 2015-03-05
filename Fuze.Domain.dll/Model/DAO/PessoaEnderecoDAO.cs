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
    public class PessoaEnderecoDAO : AbstractDAO<PessoaEnderecoVO>
    {
        public PessoaEnderecoDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(PessoaEnderecoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaEnderecoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaEnderecoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaEnderecoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaEnderecoVO> GetLista(PessoaEnderecoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override string GetSQLConsulta(PessoaEnderecoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(PessoaEnderecoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(PessoaEnderecoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
