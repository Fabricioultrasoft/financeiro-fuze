using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fuze.Domain.dll.Abstracts.Controller.BE;
using System.Data.SqlClient;
using Fuze.Domain.dll.Model.VO;
using Fuze.Domain.dll.Model.DAO;

namespace Fuze.Domain.dll.Controller.BE
{
    public class CleroBE : AbstractBE
    {
        public CleroBE()
            : base()
        {
        }

        public CleroBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        private void CampoObrigatorio(CleroVO clero)
        {
            if (string.IsNullOrEmpty(clero.Descricao))
                throw new Exception("Por favor preencha o campo Descrição");
        }

        public void Inserir(CleroVO clero)
        {
            CleroDAO dao = null;
            try
            {
                if (clero != null)
                {
                    CampoObrigatorio(clero);

                    dao = new CleroDAO(GetSqlCommand());

                    BeginTransaction();
                    dao.Inserir(clero);
                    Commit();
                }
            }
            catch (Exception e)
            {
                Rollback();
                throw e;
            }
            finally
            {
                dao = null;
            }
        }

        public void Alterar(CleroVO clero)
        {
            CleroDAO dao = null;
            try
            {
                if (clero != null)
                {
                    CampoObrigatorio(clero);

                    dao = new CleroDAO(GetSqlCommand());

                    BeginTransaction();
                    dao.Alterar(clero);
                    Commit();
                }
            }
            catch (Exception e)
            {
                Rollback();
                throw e;
            }
            finally
            {
                dao = null;
            }
        }

        public void Deletar(CleroVO clero)
        {
            CleroDAO dao = null;
            try
            {
                if (clero != null)
                {   
                    dao = new CleroDAO(GetSqlCommand());

                    BeginTransaction();
                    dao.Deletar(clero);
                    Commit();
                }
            }
            catch (Exception e)
            {
                Rollback();
                throw e;
            }
            finally
            {
                dao = null;
            }
        }

        public void Consultar(CleroVO clero)
        {
            CleroDAO dao = null;
            try
            {
                if (clero != null)
                {
                    dao = new CleroDAO(GetSqlCommand());
                    dao.Consultar(clero);
                }
            }
            catch (Exception e)
            {   
                throw e;
            }
            finally
            {
                dao = null;
            }
        }

        public List<CleroVO> GetLista(CleroVO clero)
        {
            CleroDAO dao = null;
            try
            {
                if (clero != null)
                {
                    dao = new CleroDAO(GetSqlCommand());
                    return dao.GetLista(clero);
                }
                return new List<CleroVO>();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dao = null;
            }
        }
    }
}
