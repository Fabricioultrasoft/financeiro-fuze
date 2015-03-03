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
    public class PessoaTipoBE : AbstractBE<PessoaTipoVO>
    {
        public PessoaTipoBE()
            : base()
        {
        }

        public PessoaTipoBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaTipoVO> GetLista(PessoaTipoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
