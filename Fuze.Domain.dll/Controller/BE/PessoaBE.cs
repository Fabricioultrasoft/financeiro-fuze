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
    public class PessoaBE : AbstractBE<PessoaVO>
    {
        public PessoaBE()
            : base()
        {
        }

        public PessoaBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(PessoaVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaVO> GetLista(PessoaVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
