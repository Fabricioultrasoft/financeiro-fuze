using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Fuze.Domain.dll.Abstracts.Model.VO;

namespace Fuze.Domain.dll.Abstracts.Model.DAO
{
    public abstract class AbstractDAO<T>
    {
        private SqlCommand sqlCommand;
        private SqlDataReader sqlDataReader;

        public AbstractDAO(SqlCommand sqlCommand)
        {
            SetSqlCommand(sqlCommand);
        }

        private void SetSqlCommand(SqlCommand sqlCommand)
        {
            this.sqlCommand = sqlCommand;
        }

        protected SqlCommand GetSqlCommand()
        {
            if (sqlCommand == null) sqlCommand = new SqlCommand();

            return sqlCommand;
        }

        private void SetSqlDataReader(SqlDataReader sqlDataReader)
        {
            this.sqlDataReader = sqlDataReader;
        }

        protected SqlDataReader GetSqlDataReader()
        {
            if (sqlDataReader == null)
                sqlDataReader = GetSqlCommand().ExecuteReader();

            return sqlDataReader;
        }

        protected long GetIdSequence(string sequence)
        {
            long id = 0;
            try
            {
                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = "DECLARE @NextID int;"
                                             + "SET @NextID = NEXT VALUE FOR " + sequence + ";"
                                             + "SELECT @NextID as Incremento";
                GetSqlCommand().Parameters.Clear();

                if (GetSqlDataReader().Read())
                {
                    if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("Incremento"))))
                        id = Convert.ToInt64(GetSqlDataReader()["Incremento"]);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gerar o Incremento da sequence " + sequence, ex);
            }
            finally
            {
                Close();
            }
            return id;
        }

        protected void Close()
        {
            try
            {
                if (GetSqlDataReader() != null)
                    GetSqlDataReader().Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                SetSqlDataReader(null);
            }
        }

        public abstract void Inserir(T obj);
        public abstract int Alterar(T obj);
        public abstract void Deletar(T obj);
        protected abstract string GetSQLConsulta(T obj);
        protected abstract void CarregarParametro(T obj);
        protected abstract void CarregarObjetoConsulta(T obj);
        public abstract void Consultar(T obj);
        public abstract List<T> GetLista(T obj);
    }
}
