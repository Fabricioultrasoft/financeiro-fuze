using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;
using Fuze.Domain.dll.Abstracts.Model.DAO;
using Fuze.Domain.dll.Model.VO;
using System.Data.SqlClient;
using System.Data;

namespace Fuze.Domain.dll.Model.DAO
{
    public class CorDAO : AbstractDAO<CorVO>
    {
        public CorDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(CorVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(CorVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(CorVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(CorVO obj)
        {
            throw new NotImplementedException();
        }

        public override List<CorVO> GetLista(CorVO obj)
        {
            throw new NotImplementedException();
        }

        protected override string GetSQLConsulta(CorVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(@"SELECT DBFuze.dbo.Cor.IdCor      ");
                sb.AppendLine(@"     , DBFuze.dbo.Cor.Descricao  ");
                sb.AppendLine(@"  FROM DBFuze.dbo.Cor            ");
                sb.AppendLine(@" WHERE 1 = 1                     ");

                if (obj.Id > 0)
                    sb.AppendLine(@" AND DBFuze.dbo.Cor.IdCor = @IdCor ");

                if (string.IsNullOrEmpty(obj.Descricao))
                    sb.AppendLine(@" AND DBFuze.dbo.Cor.Descricao = @Descricao ");

                return sb.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sb = null;
            }
        }

        protected override void CarregarParametro(CorVO obj)
        {
            try
            {
                GetSqlCommand().Parameters.Clear();

                if (obj.Id > 0)
                    GetSqlCommand().Parameters.Add("IdCor", SqlDbType.Int).Value = obj.Id;

                if (string.IsNullOrEmpty(obj.Descricao))
                    GetSqlCommand().Parameters.Add("Descricao", SqlDbType.VarChar).Value = obj.Descricao;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        protected override void CarregarObjetoConsulta(CorVO obj)
        {
            try
            {
                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("IdCor"))))
                    obj.Id = Convert.ToInt64(GetSqlDataReader()["IdCor"]);

                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("Descricao"))))
                    obj.Descricao = Convert.ToString(GetSqlDataReader()["Descricao"]);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
