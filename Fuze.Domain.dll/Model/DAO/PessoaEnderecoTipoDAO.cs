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
    public class PessoaEnderecoTipoDAO : AbstractDAO<PessoaEnderecoTipoVO>
    {
        public PessoaEnderecoTipoDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(PessoaEnderecoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaEnderecoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaEnderecoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaEnderecoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaEnderecoTipoVO> GetLista(PessoaEnderecoTipoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
