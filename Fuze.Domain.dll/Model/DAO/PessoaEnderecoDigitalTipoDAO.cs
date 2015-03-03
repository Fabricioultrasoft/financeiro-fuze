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
    public class PessoaEnderecoDigitalTipoDAO : AbstractDAO<PessoaEnderecoDigitalTipoVO>
    {
        public PessoaEnderecoDigitalTipoDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaEnderecoDigitalTipoVO> GetLista(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override string GetSQLConsulta(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(PessoaEnderecoDigitalTipoVO clero)
        {
            throw new NotImplementedException();
        }
    }
}
