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
    public class PessoaDAO : AbstractDAO<PessoaVO>
    {
        public PessoaDAO(SqlCommand sqlCommand)
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
