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
    public class FeriadoTipoBE : AbstractBE<FeriadoTipoVO>
    {
        public FeriadoTipoBE()
            : base()
        {
        }

        public FeriadoTipoBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<FeriadoTipoVO> GetLista(FeriadoTipoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
