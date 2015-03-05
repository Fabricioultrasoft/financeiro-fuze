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
    public class PesssoaEnderecoDigitalDAO : AbstractDAO<PessoaEnderecoDigitalVO>
    {
        public PesssoaEnderecoDigitalDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaEnderecoDigitalVO> GetLista(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        protected override string GetSQLConsulta(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
