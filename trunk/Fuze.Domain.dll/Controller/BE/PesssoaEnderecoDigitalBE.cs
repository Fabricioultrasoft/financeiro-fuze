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
    public class PesssoaEnderecoDigitalBE : AbstractBE<PessoaEnderecoDigitalVO>
    {
        public PesssoaEnderecoDigitalBE()
            : base()
        {
        }

        public PesssoaEnderecoDigitalBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PessoaEnderecoDigitalVO> GetLista(PessoaEnderecoDigitalVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
