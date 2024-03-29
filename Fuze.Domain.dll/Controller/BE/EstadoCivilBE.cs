﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Controller.BE;
using System.Data.SqlClient;
using Fuze.Domain.dll.Model.VO;
using Fuze.Domain.dll.Model.DAO;

namespace Fuze.Domain.dll.Controller.BE
{
    public class EstadoCivilBE : AbstractBE<EstadoCivilVO>
    {
        public EstadoCivilBE()
            : base()
        {
        }

        public EstadoCivilBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(EstadoCivilVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(EstadoCivilVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(EstadoCivilVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(EstadoCivilVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<EstadoCivilVO> GetLista(EstadoCivilVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
