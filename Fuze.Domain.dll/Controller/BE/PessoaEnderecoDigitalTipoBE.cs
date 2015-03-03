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
    public class PessoaEnderecoDigitalTipoBE : AbstractBE<PessoaEnderecoDigitalTipoVO>
    {
        public PessoaEnderecoDigitalTipoBE()
            : base()
        {
        }

        public PessoaEnderecoDigitalTipoBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaEnderecoDigitalTipoVO> GetLista(PessoaEnderecoDigitalTipoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
