using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Model.VO;
using System.Data.SqlClient;
using Fuze.Domain.dll.Abstracts.Model.DAO;
using Fuze.Domain.dll.Model.VO;
using System.Data;

namespace Fuze.Domain.dll.Model.DAO
{
    public class CidadeDAO : AbstractDAO<CidadeVO>
    {
        public CidadeDAO(SqlCommand sqlCommand)
            : base(sqlCommand)
        {

        }

        public override void Inserir(CidadeVO obj)
        {
            throw new NotImplementedException();
        }

        public override int Alterar(CidadeVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletar(CidadeVO obj)
        {
            throw new NotImplementedException();
        }

        public override void Consultar(CidadeVO obj)
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
                throw new Exception("Não foi possível Consultar dados na Tabela Cidade", e);
            }
            finally
            {
                Close();
            }
        }

        public override List<CidadeVO> GetLista(CidadeVO obj)
        {
            List<CidadeVO> lista = null;
            CidadeVO objeto = null;
            try
            {
                GetSqlCommand().CommandText = "";
                GetSqlCommand().CommandText = GetSQLConsulta(obj);
                CarregarParametro(obj);

                lista = new List<CidadeVO>();

                while (GetSqlDataReader().Read())
                {
                    objeto = new CidadeVO();
                    CarregarObjetoConsulta(objeto);
                    lista.Add(objeto);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível Consultar dados na Tabela Cidade", e);
            }
            finally
            {
                Close();
            }
        }

        protected override string GetSQLConsulta(CidadeVO obj)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                sb.AppendLine(" SELECT DBFuze.dbo.Cidade.CodigoIbge ");
                sb.AppendLine(" 	 , DBFuze.dbo.Cidade.IdEstado   ");
                sb.AppendLine(" 	 , DBFuze.dbo.Cidade.Nome       ");
                sb.AppendLine("   FROM DBFuze.dbo.Cidade            ");
                sb.AppendLine("  WHERE 1 = 1                        ");

                if (obj.Id > 0)
                    sb.AppendLine(@" AND DBFuze.dbo.Cidade.CodigoIbge = @CodigoIbge ");

                if (obj.Estado.Id > 0)
                    sb.AppendLine(@" AND DBFuze.dbo.Clero.DescricaoDBFuze.dbo.Cidade.IdEstado = @IdEstado ");

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

        protected override void CarregarParametro(CidadeVO obj)
        {
            try
            {
                GetSqlCommand().Parameters.Clear();

                if (obj.Id > 0)
                    GetSqlCommand().Parameters.Add("CodigoIbge", SqlDbType.Int).Value = obj.Id;

                if (obj.Estado.Id > 0)
                    GetSqlCommand().Parameters.Add("IdEstado", SqlDbType.Int).Value = obj.Estado.Id;
            }
            catch (Exception e)
            {   
                throw e;
            }
            
        }

        protected override void CarregarObjetoConsulta(CidadeVO obj)
        {
            try
            {
                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("CodigoIbge"))))
                    obj.Id = Convert.ToInt64(GetSqlDataReader()["CodigoIbge"]);

                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("IdEstado"))))
                    obj.Estado.Id = Convert.ToInt64(GetSqlDataReader()["IdEstado"]);

                if (!(GetSqlDataReader().IsDBNull(GetSqlDataReader().GetOrdinal("Nome"))))
                    obj.Nome = Convert.ToString(GetSqlDataReader()["Nome"]);
            }
            catch (Exception e)
            {   
                throw e;
            }
        }
    }
}
