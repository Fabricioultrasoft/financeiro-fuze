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
    public class TipoDocumentoFotoDAO : AbstractDAO<TipoDocumentoFotoVO>
    {
        public TipoDocumentoFotoDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }
        //                                                                                                 
        // MÉTODO RESPONSÁVEL POR INCLUIR [ TipoDocumentoFoto ]                           
        //                                                                                                 
        public override void Inserir(TipoDocumentoFotoVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(@"INSERT INTO DBFuze.dbo.TipoDocumentoFoto                ");
                sb.AppendLine(@"(                     ");
                sb.AppendLine(@"            IdTipoDocumentoFoto      ");
                sb.AppendLine(@"          , Descricao               ");
                sb.AppendLine(@")");
                sb.AppendLine(@"VALUES ");
                sb.AppendLine(@"(");
                sb.AppendLine(@"             @IdTipoDocumentoFoto     ");
                sb.AppendLine(@"          ,  @Descricao              ");
                sb.AppendLine(@")");


                // Solicitando Sequence 
                obj.Id = GetIdSequence("DBFuze.dbo.SeqTipoDocumentoFoto");

                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = sb.ToString();
                GetSqlCommand().Parameters.Clear();
                GetSqlCommand().Parameters.Add("IdTipoDocumentoFoto", SqlDbType.Int).Value = obj.Id;
                GetSqlCommand().Parameters.Add("Descricao", SqlDbType.VarChar).Value = obj.Descricao;

                GetSqlCommand().ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível INCLUIR as informações na Tabela TipoDocumentoFoto", e);
            }
            finally
            {
                sb = null;
            }
        }

        //                                                                                                 
        // MÉTODO RESPONSÁVEL POR ALTERAR UM(A) [ TipoDocumentoFoto ] SELECIONADO         
        //                                                                                                 
        public override int Alterar(TipoDocumentoFotoVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine("UPDATE DBFuze.dbo.TipoDocumentoFoto ");
                sb.AppendLine("   SET Descricao = @Descricao ");

                sb.AppendLine("  WHERE IdTipoDocumentoFoto = @IdTipoDocumentoFoto");

                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = sb.ToString();
                GetSqlCommand().Parameters.Clear();
                GetSqlCommand().Parameters.Add("IdTipoDocumentoFoto", SqlDbType.Int).Value = obj.Id;
                GetSqlCommand().Parameters.Add("Descricao", SqlDbType.VarChar).Value = obj.Descricao;
                return GetSqlCommand().ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível ALTERAR as informações na Tabela TipoDocumentoFoto", e);
            }
            finally
            {
                sb = null;
            }
        }


        //                                                                                              
        // MÉTODO RESPONSÁVEL POR DELETAR UM(A) [ TipoDocumentoFoto ] SELECIONADO      
        //                                                                                              
        public override void Deletar(TipoDocumentoFotoVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine("DELETE FROM DBFuze.dbo.TipoDocumentoFoto ");
                sb.AppendLine(" WHERE IdTipoDocumentoFoto = @IdTipoDocumentoFoto");

                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = sb.ToString();
                GetSqlCommand().Parameters.Clear();
                GetSqlCommand().Parameters.Add("IdTipoDocumentoFoto", SqlDbType.Int).Value = obj.Id;

                GetSqlCommand().ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível EXCLUIR as informações na Tabela TipoDocumentoFoto", e);
            }
            finally
            {
                sb = null;
            }
        }

        //                                                                                                         
        // MÉTODO RESPONSÁVEL POR CONSULTAR [ TipoDocumentoFoto ]                                
        //                                                                                                         
        protected override string GetSQLConsulta(TipoDocumentoFotoVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(@"SELECT ");
                sb.AppendLine(@"       DBFuze.dbo.TipoDocumentoFoto.IdTipoDocumentoFoto");
                sb.AppendLine(@"      ,DBFuze.dbo.TipoDocumentoFoto.Descricao");
                sb.AppendLine(@"  FROM DBFuze.dbo.TipoDocumentoFoto");
                sb.AppendLine(@" WHERE 1 = 1");

                if (obj.Id > 0)
                    sb.AppendLine(@" AND DBFuze.dbo.TipoDocumentoFoto.IdTipoDocumentoFoto = @IdTipoDocumentoFoto");

                if (!string.IsNullOrEmpty(obj.Descricao))
                    sb.AppendLine(@" AND DBFuze.dbo.TipoDocumentoFoto.Descricao = @Descricao");

                
                return sb.ToString();
            }
            
            catch (Exception e)
            {
                throw new Exception("Não foi possível CONSULTAR as informações na Tabela TipoDocumentoFoto", e);
            }
            finally
            {
                sb = null;
            }
        }

        //                                                                                                         
        // MÉTODO RESPONSÁVEL POR CARREGAR PARAMETRO DA  [ TipoDocumentoFoto ]                    
        //                                                                                                         
        protected override void CarregarParametro(TipoDocumentoFotoVO obj)
        {
            try
            {
                GetSqlCommand().Parameters.Clear();

                if (obj.Id > 0)
                    GetSqlCommand().Parameters.Add("IdTipoDocumentoFoto", SqlDbType.Int).Value = obj.Id;

                if (!string.IsNullOrEmpty(obj.Descricao))
                    GetSqlCommand().Parameters.Add("Descricao", SqlDbType.VarChar).Value = obj.Descricao;


            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível CARREGAR as informações na Tabela TipoDocumentoFoto", e);
            }
        }
        //                                                                                                         
        // MÉTODO RESPONSÁVEL POR CARREGAR OBJETO PARA CONSULTA DA  [ TipoDocumentoFoto ]                    
        //                                                                                                         
        protected override void CarregarObjetoConsulta(TipoDocumentoFotoVO obj)
        {
            try
            {
                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("IdTipoDocumentoFoto"))))
                    obj.Id = Convert.ToInt64(GetSqlDataReader()["IdTipoDocumentoFoto"]);

                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("Descricao"))))
                    obj.Descricao = Convert.ToString(GetSqlDataReader()["Descricao"]);


            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível Carregar o Objeto para a Consulta.", e);
            }
        }
        public override void Consultar(TipoDocumentoFotoVO obj)                   
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
                  throw new Exception("Não foi possível Consultar os Dados na Tabela TipoDocumentoFoto.",e);    
             }                                                                                     
             finally                                                                               
             {                                                                                     
                  Close();                                                                         
             }                                                                                     
         }
        //                                                                                                          
        // MÉTODO RESPONSÁVEL POR LISTAR [ TipoDocumentoFoto ]                                     
        //                                                                                                          
        public override List<TipoDocumentoFotoVO> GetLista(TipoDocumentoFotoVO obj)
         {                                                                                                          
             List<TipoDocumentoFotoVO> lista = null;                                                
             TipoDocumentoFotoVO objeto = null;                                                     
             try                                                                                                    
             {
                 GetSqlCommand().CommandText = "";                                                                  
                 GetSqlCommand().CommandText = GetSQLConsulta(obj);                                                 
                 CarregarParametro(obj);                                                                            
                                                                                                                    
                 lista = new List<TipoDocumentoFotoVO>();                                           
                                                                                                                    
                 while (GetSqlDataReader().Read())                                                                  
                 {                                                                                                  
                      objeto = new TipoDocumentoFotoVO();                                            
                      CarregarObjetoConsulta(objeto);                                                               
                      lista.Add(objeto);                                                                            
                 }
                 return lista;                                                                 
             }                                                                                                      
             catch (Exception e)                                                                                   
             {                                                                                                      
                  throw new Exception("Não foi possível Consultar os Dados na Tabela TipoDocumentoFoto.",e); 
             }                                                                                                       
             finally                                                                                                 
             {                                                                                                       
                  Close();                                                                                           
             }                                                                                                       
         }    
    }
}
