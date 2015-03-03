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
    public class PessoaEnderecoTipoBE : AbstractBE<PessoaEnderecoTipoVO>
    {
        public PessoaEnderecoTipoBE()
            : base()
        {
        }

        public PessoaEnderecoTipoBE(SqlCommand sqlCommand)
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
