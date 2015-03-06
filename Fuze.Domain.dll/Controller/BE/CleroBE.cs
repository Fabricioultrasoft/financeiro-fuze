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
    public class CleroBE : AbstractBE<CleroVO>
    {
        public CleroBE()
            : base()
        {
        }

        public CleroBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(CleroVO obj)
        {
            CleroDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new CleroDAO(GetSqlCommand());

                    BeginTransaction();
                    dao.Inserir(obj);
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

        public override int Alterar(CleroVO obj)
        {
            CleroDAO dao = null;
            int id = 0;
            try
            {
                if (obj != null)
                {
                    dao = new CleroDAO(GetSqlCommand());

                    BeginTransaction();
                    id = dao.Alterar(obj);
                    Commit();

                    return id;
                }

                return 0;
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

        public override void Deletar(CleroVO obj)
        {
            CleroDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new CleroDAO(GetSqlCommand());

                    BeginTransaction();
                    dao.Deletar(obj);
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

        public override void Consultar(CleroVO obj)
        {
            CleroDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new CleroDAO(GetSqlCommand());
                    dao.Consultar(obj);
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

        public override List<CleroVO> GetLista(CleroVO obj)
        {
            CleroDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new CleroDAO(GetSqlCommand());
                    return dao.GetLista(obj);
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
