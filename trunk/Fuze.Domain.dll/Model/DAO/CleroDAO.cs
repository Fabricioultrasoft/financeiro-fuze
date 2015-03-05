using System;
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
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(@"INSERT INTO DBFuze.dbo.Clero");
                sb.AppendLine(@"(                           ");
                sb.AppendLine(@"	  IdClero               ");
                sb.AppendLine(@"	, Descricao             ");
                sb.AppendLine(@")                           ");
                sb.AppendLine(@"VALUES                      ");
                sb.AppendLine(@"(                           ");
                sb.AppendLine(@"	  @IdClero              ");
                sb.AppendLine(@"	, @Descricao            ");
                sb.AppendLine(@")                           ");

                // Solicitando Sequence
                obj.Id = GetIdSequence("DBFuze.dbo.SeqClero");

                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = sb.ToString();
                GetSqlCommand().Parameters.Clear();
                GetSqlCommand().Parameters.Add("IdClero", SqlDbType.Int).Value = obj.Id;
                GetSqlCommand().Parameters.Add("Descricao", SqlDbType.VarChar).Value = obj.Descricao;

                GetSqlCommand().ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível inserir dados na Tabela Clero", e);
            }
            finally
            {
                sb = null;
            }
        }

        public override int Alterar(CleroVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(@"UPDATE DBFuze.dbo.Clero       ");
                sb.AppendLine(@"   SET Descricao = @Descricao ");
                sb.AppendLine(@" WHERE IdClero   = @IdClero   ");

                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = sb.ToString();
                GetSqlCommand().Parameters.Clear();
                GetSqlCommand().Parameters.Add("IdClero", SqlDbType.Int).Value = obj.Id;
                GetSqlCommand().Parameters.Add("Descricao", SqlDbType.VarChar).Value = obj.Descricao;

                return GetSqlCommand().ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível Alterar dados na Tabela Clero", e);
            }
            finally
            {
                sb = null;
            }
        }

        public override void Deletar(CleroVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(@"DELETE FROM DBFuze.dbo.Clero ");
                sb.AppendLine(@" WHERE IdClero = @IdClero    ");

                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = sb.ToString();
                GetSqlCommand().Parameters.Clear();
                GetSqlCommand().Parameters.Add("IdClero", SqlDbType.Int).Value = obj.Id;

                GetSqlCommand().ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível Deletar dados na Tabela Clero", e);
            }
            finally
            {
                sb = null;
            }
        }

        protected override string GetSQLConsulta(CleroVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(@"SELECT DBFuze.dbo.Clero.IdClero  ");
                sb.AppendLine(@"     , DBFuze.dbo.Clero.Descricao");
                sb.AppendLine(@"  FROM DBFuze.dbo.Clero          ");
                sb.AppendLine(@" WHERE 1 = 1                     ");

                if (obj.Id > 0)
                    sb.AppendLine(@" AND DBFuze.dbo.Clero.IdClero = @IdClero ");

                if (string.IsNullOrEmpty(obj.Descricao))
                    sb.AppendLine(@" AND DBFuze.dbo.Clero.Descricao = @Descricao ");

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

        protected override void CarregarParametro(CleroVO obj)
        {
            try
            {
                GetSqlCommand().Parameters.Clear();

                if (obj.Id > 0)
                    GetSqlCommand().Parameters.Add("IdClero", SqlDbType.Int).Value = obj.Id;

                if (string.IsNullOrEmpty(obj.Descricao))
                    GetSqlCommand().Parameters.Add("Descricao", SqlDbType.VarChar).Value = obj.Descricao;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        protected override void CarregarObjetoConsulta(CleroVO obj)
        {
            try
            {
                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("IdClero"))))
                    obj.Id = Convert.ToInt64(GetSqlDataReader()["IdClero"]);

                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("Descricao"))))
                    obj.Descricao = Convert.ToString(GetSqlDataReader()["Descricao"]);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override void Consultar(CleroVO obj)
        {
            try
            {
                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = GetSQLConsulta(obj);
                CarregarParametro(obj);

                if (GetSqlDataReader().Read())
                    CarregarObjetoConsulta(obj);

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível Consultar dados na Tabela Clero", e);
            }
            finally
            {
                Close();
            }
        }

        public override List<CleroVO> GetLista(CleroVO obj)
        {
            List<CleroVO> lista = null;
            CleroVO objeto = null;
            try
            {
                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = GetSQLConsulta(obj);
                CarregarParametro(obj);

                lista = new List<CleroVO>();

                while (GetSqlDataReader().Read())
                {
                    objeto = new CleroVO();
                    CarregarObjetoConsulta(objeto);
                    lista.Add(objeto);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível Consultar dados na Tabela Clero", e);
            }
            finally
            {
                Close();
            }
        }
    }
}
