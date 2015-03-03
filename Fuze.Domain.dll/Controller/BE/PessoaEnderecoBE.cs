using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Controller.BE;
using System.Data.SqlClient;
using Fuze.Domain.dll.Model.VO;
using Fuze.Domain.dll.Model.DAO;

namespace Fuze.Domain.dll.Controller.BE
{
    public class PessoaEnderecoBE : AbstractBE<PessoaEnderecoVO>
    {
        public PessoaEnderecoBE()
            : base()
        {
        }

        public PessoaEnderecoBE(SqlCommand sqlCommand)
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
    }
}
