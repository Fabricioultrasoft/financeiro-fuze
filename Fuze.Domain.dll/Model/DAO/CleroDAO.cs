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
    public class CleroDAO : AbstractDAO
    {
        public CleroDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public void Inserir(CleroVO clero)
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
                clero.Id = GetIdSequence("DBFuze.dbo.SeqClero");

                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = sb.ToString();
                GetSqlCommand().Parameters.Clear();
                GetSqlCommand().Parameters.Add("IdClero", SqlDbType.Int).Value = clero.Id;
                GetSqlCommand().Parameters.Add("Descricao", SqlDbType.VarChar).Value = clero.Descricao;

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

        public int Alterar(CleroVO clero)
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
                GetSqlCommand().Parameters.Add("IdClero", SqlDbType.Int).Value = clero.Id;
                GetSqlCommand().Parameters.Add("Descricao", SqlDbType.VarChar).Value = clero.Descricao;

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

        public void Deletar(CleroVO clero)
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
                GetSqlCommand().Parameters.Add("IdClero", SqlDbType.Int).Value = clero.Id;

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

        private string GetSQLConsulta(CleroVO clero)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(@"SELECT DBFuze.dbo.Clero.IdClero  ");
                sb.AppendLine(@"     , DBFuze.dbo.Clero.Descricao");
                sb.AppendLine(@"  FROM DBFuze.dbo.Clero          ");
                sb.AppendLine(@" WHERE 1 = 1                     ");

                if (clero.Id > 0)
                    sb.AppendLine(@" AND DBFuze.dbo.Clero.IdClero = @IdClero ");

                if (string.IsNullOrEmpty(clero.Descricao))
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

        private void CarregarParametro(CleroVO clero)
        {
            try
            {
                GetSqlCommand().Parameters.Clear();
                
                if (clero.Id > 0)
                    GetSqlCommand().Parameters.Add("IdClero", SqlDbType.Int).Value = clero.Id;

                if (string.IsNullOrEmpty(clero.Descricao))
                    GetSqlCommand().Parameters.Add("Descricao", SqlDbType.VarChar).Value = clero.Descricao;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void CarregarObjetoConsulta(CleroVO clero)
        {
            try
            {
                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("IdClero"))))
                    clero.Id = Convert.ToInt32(GetSqlDataReader()["CodigoIbge"]);

                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("Descricao"))))
                    clero.Descricao = Convert.ToString(GetSqlDataReader()["Descricao"]);
            }
            catch (Exception e)
            {   
                throw e;
            }
        }
        
        public void Consultar(CleroVO clero)
        {
            try
            {
                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = GetSQLConsulta(clero);
                CarregarParametro(clero);

                if (GetSqlDataReader().Read())
                    CarregarObjetoConsulta(clero);

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

        public List<CleroVO> GetLista(CleroVO clero)
        {
            List<CleroVO> lista = null;
            CleroVO objeto = null;
            try
            {
                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = GetSQLConsulta(clero);
                CarregarParametro(clero);

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
