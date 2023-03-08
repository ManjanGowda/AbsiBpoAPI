using AbsiBpoAPI.Business.Interface;
using AbsiBpoAPI.Data.Interface;
using System.Collections.Generic;
using System;
using AbsiBpoAPI.Business.Entities;

namespace AbsiBpoAPI.Business.Managers
{
    public class PerformanceCoachingManager : IPerformanceCoachingManager
    {
        public IPerformanceCoachingManager IPerformanceCoachingRrepository;
        public PerformanceCoachingManager(IPerformanceCoachingManager PerformanceCoachingManager)
        {
            this.IPerformanceCoachingRrepository = PerformanceCoachingManager;
        }





        //public IEnumerable<dynamic> GetCoachingSessions()
        //{
        //    try
        //    {
        //        return IPerformanceCoachingRrepository.GetCoachingSessions<dynamic>();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        //public Int64 InsertCoachingSessions(PerformanceCoachingEntity PerformanceCoachingEntity)
        //{
        //    try
        //    {
        //        var filter = new
        //        {

        //            EmployeeID = PerformanceCoachingEntity.EmployeeID,
        //            Date = PerformanceCoachingEntity.Date,
        //            Time = PerformanceCoachingEntity.Time,
        //            CoachingTemplate = PerformanceCoachingEntity.CoachingTemplate,

        //        };



        //        return IPerformanceCoachingRrepository.InsertCoachingSessions(filter);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

    }
}







