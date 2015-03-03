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
    public class PessoaJuridicaBE : AbstractBE<PessoaJuridicaVO>
    {
        public PessoaJuridicaBE()
            : base()
        {
        }

        public PessoaJuridicaBE(SqlCommand sqlCommand)
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
