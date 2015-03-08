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
    public class TipoDocumentoFotoBE : AbstractBE<TipoDocumentoFotoVO>
    {
        public TipoDocumentoFotoBE()
            : base()
        {
        }

        public TipoDocumentoFotoBE(SqlCommand sqlCommand)
            : base(sqlCommand)
        {
        }

        public override void Inserir(TipoDocumentoFotoVO obj)
        {
            TipoDocumentoFotoDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new TipoDocumentoFotoDAO(GetSqlCommand());

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

        public override int Alterar(TipoDocumentoFotoVO obj)
        {
            TipoDocumentoFotoDAO dao = null;
            int id = 0;
            try
            {
                if (obj != null)
                {
                    dao = new TipoDocumentoFotoDAO(GetSqlCommand());

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

        public override void Deletar(TipoDocumentoFotoVO obj)
        {
            TipoDocumentoFotoDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new TipoDocumentoFotoDAO(GetSqlCommand());

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

        public override void Consultar(TipoDocumentoFotoVO obj)
        {
            TipoDocumentoFotoDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new TipoDocumentoFotoDAO(GetSqlCommand());
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

        public override List<TipoDocumentoFotoVO> GetLista(TipoDocumentoFotoVO obj)
        {
            TipoDocumentoFotoDAO dao = null;
            try
            {
                if (obj != null)
                {
                    dao = new TipoDocumentoFotoDAO(GetSqlCommand());
                    return dao.GetLista(obj);
                }
                return new List<TipoDocumentoFotoVO>();
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
