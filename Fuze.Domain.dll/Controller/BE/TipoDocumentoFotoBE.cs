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
    public class TipoDocumentoFotoBE : AbstractBE<TipoDocumentoFotoVO>
    {
        public TipoDocumentoFotoBE()
            : base()
        {
        }

        public TipoDocumentoFotoBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<TipoDocumentoFotoVO> GetLista(TipoDocumentoFotoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
