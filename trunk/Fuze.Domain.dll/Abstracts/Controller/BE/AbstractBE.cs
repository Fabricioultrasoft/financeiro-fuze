using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

namespace Fuze.Domain.dll.Abstracts.Controller.BE
{
    public abstract class AbstractBE<T>
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private SqlCommand sqlCommand;

        private void SetSqlCommand(SqlCommand sqlCommand)
        {
            this.sqlCommand = sqlCommand;
        }

        protected SqlCommand GetSqlCommand()
        {
            return sqlCommand;
        }

        private void SetSqlConnection(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        private SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }

        private void SetSqlTransaction(SqlTransaction sqlTransaction)
        {
            this.sqlTransaction = sqlTransaction;
        }

        private SqlTransaction GetSqlTransaction()
        {
            return sqlTransaction;
        }

        protected AbstractBE()
        {
            try
            {
                AbrirConexao();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        protected AbstractBE(SqlCommand sqlCommand)
        {
            try 
            {
                if (!sqlCommand.Connection.State.Equals(ConnectionState.Open))
                {
                    throw new Exception("A conexão com o banco de dados não esta aberta!");
                }
            }
            catch(Exception e)
            {
                throw new Exception("A conexão com o banco de dados não esta aberta!", e);
            }
            SetSqlCommand(sqlCommand);
        }

        private void AbrirConexao()
        {
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            try
            {
                if (sqlConnection == null)
                {
                    sqlConnection = new SqlConnection(GetArquivoConexaoBanco());
                    sqlConnection.Open();
                    SetSqlConnection(sqlConnection);
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandTimeout = 500;
                    sqlCommand.Parameters.Clear();
                    SetSqlCommand(sqlCommand);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possivel abrir conexão com o banco de dados!" , e);
            }
        }

        private string GetArquivoConexaoBanco()
        {
            XmlDocument xmlDocument = null;
            StringBuilder sb = null;
            try
            {
                xmlDocument = new XmlDocument();
                sb = new StringBuilder();
                xmlDocument.Load("D:/ConnectionString.xml");
                XmlNode xmlNode = xmlDocument.SelectSingleNode("Banco_Dados");
                XmlNode xmlNodeConexao = xmlNode.SelectSingleNode("ConDB");
                XmlNode xmlNodeServer = xmlNodeConexao.SelectSingleNode("Server");
                XmlNode xmlNodeUser = xmlNodeConexao.SelectSingleNode("User_Id");
                XmlNode xmlNodePassword = xmlNodeConexao.SelectSingleNode("Password");
                XmlNode xmlNodeDataBase = xmlNodeConexao.SelectSingleNode("Data_Base");

                sb.Append("Server=" + xmlNodeServer.InnerText + ";");
                sb.Append("User Id=" + xmlNodeUser.InnerText + ";");
                sb.Append("Password=" + xmlNodePassword.InnerText + ";");
                sb.Append("Database=" + xmlNodeDataBase.InnerText + ";");
                sb.Append("Persist Security Info=True");

                return sb.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (xmlDocument != null)
                    xmlDocument = null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                if (GetSqlConnection() != null && GetSqlCommand() != null)
                {
                    GetSqlConnection().Close();
                    SetSqlConnection(null);
                    GetSqlCommand().Dispose();
                    SetSqlCommand(null);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possivel fechar conexão com o banco de dados!", e);
            }
        }

        protected void BeginTransaction()
        {
            SqlTransaction sqlTransaction = null;
            try
            {
                if (GetSqlTransaction() == null)
                {
                    sqlTransaction = GetSqlConnection().BeginTransaction("AbreTransacao");
                    SetSqlTransaction(sqlTransaction);
                    GetSqlCommand().Transaction = GetSqlTransaction();
                }

            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível abrir a transação com o banco de dados!", e);
            }
        }

        protected void Commit()
        {
            try
            {
                if (GetSqlTransaction() != null)
                    GetSqlTransaction().Commit();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        protected void Rollback()
        {
            try
            {
                if (GetSqlTransaction() != null)
                    GetSqlTransaction().Rollback();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public abstract void Inserir(T obj);
        public abstract int Alterar(T obj);
        public abstract void Deletar(T obj);
        public abstract void Consultar(T obj);
        public abstract List<T> GetLista(T obj);
    }
}
