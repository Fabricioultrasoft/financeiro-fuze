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
    public class FeriadoBE : AbstractBE<FeriadoVO>
    {
        public FeriadoBE()
            : base()
        {
        }

        public FeriadoBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(FeriadoVO obj)
        {
            FeriadoDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new FeriadoDAO(GetSqlCommand());

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

        public override int Alterar(FeriadoVO obj)
        {
            FeriadoDAO dao = null;
            int id = 0;
            try
            {
                if (obj != null)
                {
                    dao = new FeriadoDAO(GetSqlCommand());

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

        public override void Deletar(FeriadoVO obj)
        {
            FeriadoDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new FeriadoDAO(GetSqlCommand());

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

        public override void Consultar(FeriadoVO obj)
        {
            FeriadoDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new FeriadoDAO(GetSqlCommand());
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

        public override List<FeriadoVO> GetLista(FeriadoVO obj)
        {
            FeriadoDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new FeriadoDAO(GetSqlCommand());
                    return dao.GetLista(obj);
                }
                return new List<FeriadoVO>();
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
