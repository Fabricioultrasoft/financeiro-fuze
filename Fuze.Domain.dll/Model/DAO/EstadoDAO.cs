﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;
using Fuze.Domain.dll.Abstracts.Model.DAO;
using System.Data.SqlClient;
using Fuze.Domain.dll.Model.VO;

namespace Fuze.Domain.dll.Model.DAO
{
    public class EstadoDAO : AbstractDAO<EstadoVO>
    {
        public EstadoDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<EstadoVO> GetLista(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override string GetSQLConsulta(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarParametro(EstadoVO obj)
        {
            throw new NotImplementedException();
        }

        protected override void CarregarObjetoConsulta(EstadoVO obj)
        {
            throw new NotImplementedException();
        }
    }
}
