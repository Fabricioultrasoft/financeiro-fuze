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
    public class PessoaJuridicaDAO : AbstractDAO<PessoaJuridicaVO>
    {
        public PessoaJuridicaDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(PessoaJuridicaVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaJuridicaVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaJuridicaVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaJuridicaVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaJuridicaVO> GetLista(PessoaJuridicaVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
