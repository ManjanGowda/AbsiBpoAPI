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

        //public IEnumerable<T> GetCoachingSessions<T>()
        //{
        //    try
        //    {
        //        db.Open();
        //        var res = db.Query<T>("SProc_GetCoachingSessions", commandType: CommandType.StoredProcedure);
        //        db.Close();
        //        return res;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public Int64 InsertCoachingSessions(object filter)
        //{
        //    try
        //    {
        //        db.Open();
        //        var res = db.Query<Int64>("SProc_InsertCoachingSessions", filter, commandType: CommandType.StoredProcedure);
        //        db.Close();
        //        return res;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

       // }
    }
}




