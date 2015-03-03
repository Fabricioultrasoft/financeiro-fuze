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
    public class PessoaTelefoneTipoBE : AbstractBE<PessoaTelefoneTipoVO>
    {
        public PessoaTelefoneTipoBE()
            : base()
        {
        }

        public PessoaTelefoneTipoBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaTelefoneTipoVO> GetLista(PessoaTelefoneTipoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
