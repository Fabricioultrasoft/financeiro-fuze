﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.DAO;
using System.Data.SqlClient;
using Fuze.Domain.dll.Model.VO;
using System.Data;

namespace Fuze.Domain.dll.Model.DAO
{
    public class CleroDAO : AbstractDAO<CleroVO>
    {
        public CleroDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(CleroVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(CleroVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(CleroVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(CleroVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<CleroVO> GetLista(CleroVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
