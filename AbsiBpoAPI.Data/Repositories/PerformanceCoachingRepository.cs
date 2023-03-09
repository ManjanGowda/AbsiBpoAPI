using AbsiBpoAPI.Data.Interface;
using AbsiBpoAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Collections;

namespace AbsiBpoAPI.Data.Repositories
{
    public class PerformanceCoachingRepository : Repository, IPerformanceCoachingRepository
    {
        // Coaching sessions
        public IEnumerable<T> GetCoachingSessions<T>()
        {
            try
            {
                return db.Query<T>("SProc_GetCoachingSessions", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 InsertCoachingSessions(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertCoachingSessions]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> GetCoachingSessionsByID<T>(object filter)
        {
            try
            {
                return db.Query<T>("SProc_GetCoachingSessionsByID", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateCoachingSessions(object filter)
        {
            try
            {
                return db.Query<Int64>("SProc_UpdateCoachingSessions", filter, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 DeleteCoachingSessions(object filter)
        {
            try
            {
                return db.Execute("[SProc_DeleteCoachingSessions]", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // coaching template
        public IEnumerable<T> GetCoachingTemplate<T>()
        {
            try
            {
                return db.Query<T>("SProc_GetCoachingTemplate", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 InsertCoachingTemplate(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertCoachingTemplate]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> GetCoachingTemplateByID<T>(object filter)
        {
            try
            {
                return db.Query<T>("SProc_GetCoachingTemplateByID", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateCoachingTemplate(object filter)
        {
            try
            {
                return db.Query<Int64>("SProc_UpdateCoachingTemplate", filter, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 DeleteCoachingTemplate(object filter)
        {
            try
            {
                return db.Execute("[SProc_DeleteCoachingTemplate]", filter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}




