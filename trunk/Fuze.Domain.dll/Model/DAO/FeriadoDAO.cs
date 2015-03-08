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
    public class FeriadoDAO : AbstractDAO<FeriadoVO>
    {
        public FeriadoDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }
        //                                                                                                 
        // MÉTODO RESPONSÁVEL POR INCLUIR [ Feriado ]                           
        //                                                                                                 
        public override void Inserir(FeriadoVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(@"INSERT INTO DBFuze.dbo.Feriado              ");
                sb.AppendLine(@"(                     ");
                sb.AppendLine(@"            IdFeriado          ");
                sb.AppendLine(@"          , IdFeriadoTipo      ");
                sb.AppendLine(@"          , Nome               ");
                sb.AppendLine(@"          , Data               ");
                sb.AppendLine(@"          , Motivacao         ");
                sb.AppendLine(@")");
                sb.AppendLine(@"VALUES ");
                sb.AppendLine(@"(");
                sb.AppendLine(@"          ,  @IdFeriado         ");
                sb.AppendLine(@"          ,  @IdFeriadoTipo     ");
                sb.AppendLine(@"          ,  @Nome              ");
                sb.AppendLine(@"          ,  @Data              ");
                sb.AppendLine(@"          ,  @Motivacao        ");
                sb.AppendLine(@")");


                // Solicitando Sequence 
                obj.Id = GetIdSequence("DBFuze.dbo.SeqFeriado");

                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = sb.ToString();
                GetSqlCommand().Parameters.Clear();
                GetSqlCommand().Parameters.Add("IdFeriado", SqlDbType.Int).Value = obj.Id;
                GetSqlCommand().Parameters.Add("IdFeriadoTipo", SqlDbType.Int).Value = obj.FeriadoTipo.Id;
                GetSqlCommand().Parameters.Add("Nome", SqlDbType.VarChar).Value = obj.Nome;
                GetSqlCommand().Parameters.Add("Data", SqlDbType.DateTime).Value = obj.Data;
                GetSqlCommand().Parameters.Add("Motivacao", SqlDbType.VarChar).Value = obj.Motivacao;

                GetSqlCommand().ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível INCLUIR as informações na Tabela Feriado", e);
            }
            finally
            {
                sb = null;
            }
        }

        //                                                                                                 
        // MÉTODO RESPONSÁVEL POR ALTERAR UM(A) [ Feriado ] SELECIONADO         
        //                                                                                                 
        public override int Alterar(FeriadoVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine("UPDATE DBFuze.dbo.Feriado ");
                sb.AppendLine("   SET IdFeriadoTipo = @IdFeriadoTipo ");
                sb.AppendLine("     , Nome = @Nome");
                sb.AppendLine("     , Data = @Data");
                sb.AppendLine("     , Motivacao = @Motivacao");

                sb.AppendLine("  WHERE IdFeriado = @IdFeriado");

                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = sb.ToString();
                GetSqlCommand().Parameters.Clear();
                GetSqlCommand().Parameters.Add("IdFeriado", SqlDbType.Int).Value = obj.Id;
                GetSqlCommand().Parameters.Add("IdFeriadoTipo", SqlDbType.Int).Value = obj.FeriadoTipo.Id;
                GetSqlCommand().Parameters.Add("Nome", SqlDbType.VarChar).Value = obj.Nome;
                GetSqlCommand().Parameters.Add("Data", SqlDbType.DateTime).Value = obj.Data;
                GetSqlCommand().Parameters.Add("Motivacao", SqlDbType.VarChar).Value = obj.Motivacao;
                return GetSqlCommand().ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível ALTERAR as informações na Tabela Feriado", e);
            }
            finally
            {
                sb = null;
            }
        }


        //                                                                                              
        // MÉTODO RESPONSÁVEL POR DELETAR UM(A) [ Feriado ] SELECIONADO      
        //                                                                                              
        public override void Deletar(FeriadoVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine("DELETE FROM DBFuze.dbo.Feriado ");
                sb.AppendLine(" WHERE IdFeriado = @IdFeriado");

                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = sb.ToString();
                GetSqlCommand().Parameters.Clear();
                GetSqlCommand().Parameters.Add("IdFeriado", SqlDbType.Int).Value = obj.Id;

                GetSqlCommand().ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível EXCLUIR as informações na Tabela Feriado", e);
            }
            finally
            {
                sb = null;
            }
        }

        //                                                                                                         
        // MÉTODO RESPONSÁVEL POR CONSULTAR [ Feriado ]                                
        //                                                                                                         
        protected override string GetSQLConsulta(FeriadoVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(@"SELECT ");
                sb.AppendLine(@"       DBFuze.dbo.Feriado.IdFeriado");
                sb.AppendLine(@"      ,DBFuze.dbo.Feriado.IdFeriadoTipo");
                sb.AppendLine(@"      ,DBFuze.dbo.Feriado.Nome");
                sb.AppendLine(@"      ,DBFuze.dbo.Feriado.Data");
                sb.AppendLine(@"      ,DBFuze.dbo.Feriado.Motivacao");
                sb.AppendLine(@"  FROM DBFuze.dbo.Feriado");
                sb.AppendLine(@" WHERE 1 = 1");

                if (obj.Id > 0)
                    sb.AppendLine(@" AND DBFuze.dbo.Feriado.IdFeriado = @IdFeriado");

                if (obj.FeriadoTipo.Id > 0)
                    sb.AppendLine(@" AND DBFuze.dbo.Feriado.IdFeriadoTipo = @IdFeriadoTipo");

                if (!string.IsNullOrEmpty(obj.Nome))
                    sb.AppendLine(@" AND DBFuze.dbo.Feriado.Nome = @Nome");

                if (obj.Data != null)
                    sb.AppendLine(@" AND DBFuze.dbo.Feriado.Data = @Data");

                if (!string.IsNullOrEmpty(obj.Motivacao))
                    sb.AppendLine(@" AND DBFuze.dbo.Feriado.Motivacao = @Motivacao");


                return sb.ToString();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível CONSULTAR as informações na Tabela Feriado", e);
            }
            finally
            {
                sb = null;
            }
        }
        //                                                                                                         
        // MÉTODO RESPONSÁVEL POR CARREGAR PARAMETRO DA  [ Feriado ]                    
        //                                                                                                         
        protected override void CarregarParametro(FeriadoVO obj)
        {
            try
            {
                GetSqlCommand().Parameters.Clear();

                if (obj.Id > 0)
                    GetSqlCommand().Parameters.Add("IdFeriado", SqlDbType.Int).Value = obj.Id;

                if (obj.FeriadoTipo.Id > 0)
                    GetSqlCommand().Parameters.Add("IdFeriadoTipo", SqlDbType.Int).Value = obj.FeriadoTipo.Id;

                if (!string.IsNullOrEmpty(obj.Nome))
                    GetSqlCommand().Parameters.Add("Nome", SqlDbType.VarChar).Value = obj.Nome;

                if (obj.Data != null)
                    GetSqlCommand().Parameters.Add("Data", SqlDbType.DateTime).Value = obj.Data;

                if (!string.IsNullOrEmpty(obj.Motivacao))
                    GetSqlCommand().Parameters.Add("Motivacao", SqlDbType.VarChar).Value = obj.Motivacao;


            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível CARREGAR as informações na Tabela Feriado", e);
            }
        }
        //                                                                                                         
        // MÉTODO RESPONSÁVEL POR CARREGAR OBJETO PARA CONSULTA DA  [ Feriado ]                    
        //                                                                                                         
        protected override void CarregarObjetoConsulta(FeriadoVO obj)
        {
            try
            {
                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("IdFeriado"))))
                    obj.Id = Convert.ToInt64(GetSqlDataReader()["IdFeriado"]);


                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("Nome"))))
                    obj.Nome = Convert.ToString(GetSqlDataReader()["Nome"]);

                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("Data"))))
                    obj.Data = Convert.ToDateTime(GetSqlDataReader()["Data"]);

                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("Motivacao"))))
                    obj.Motivacao = Convert.ToString(GetSqlDataReader()["Motivacao"]);


            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível Carregar o Objeto para a Consulta.", e);
            }
        }
        public override void Consultar(FeriadoVO obj)
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
                throw new Exception("Não foi possível Consultar os Dados na Tabela Feriado.", e);
            }
            finally
            {
                Close();
            }
        }
        //                                                                                                          
        // MÉTODO RESPONSÁVEL POR LISTAR [ Feriado ]                                     
        //                                                                                                          
        public override List<FeriadoVO> GetLista(FeriadoVO obj)
        {
            List<FeriadoVO> lista = null;
            FeriadoVO objeto = null;
            try
            {
                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = GetSQLConsulta(obj);
                CarregarParametro(obj);

                lista = new List<FeriadoVO>();

                while (GetSqlDataReader().Read())
                {
                    objeto = new FeriadoVO();
                    CarregarObjetoConsulta(objeto);
                    lista.Add(objeto);
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível Consultar os Dados na Tabela Feriado.", e);
            }
            finally
            {
                Close();
            }
        }
    }
}
