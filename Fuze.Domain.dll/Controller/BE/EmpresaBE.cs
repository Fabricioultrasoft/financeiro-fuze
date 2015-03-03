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
    public class EmpresaBE : AbstractBE<EmpresaVO>
    {
        public EmpresaBE()
            : base()
        {
        }

        public EmpresaBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(EmpresaVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(EmpresaVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(EmpresaVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(EmpresaVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<EmpresaVO> GetLista(EmpresaVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
