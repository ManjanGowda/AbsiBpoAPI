using AbsiBpoAPI.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Business.Interface
{
    public interface IPerformanceCoachingManager
    {
        //coaching session
        IEnumerable<dynamic> GetCoachingSessions();
        Int64 InsertCoachingSessions(PerformanceCoachingEntity PerformanceCoachingEntity);
        IEnumerable<dynamic> GetCoachingSessionsByID(object filter);
        Int64 UpdateCoachingSessions(PerformanceCoachingEntity PerformanceCoachingEntity);
        Int64 DeleteCoachingSessions(object filter);

        // coaching template
        IEnumerable<dynamic> GetCoachingTemplate();
        Int64 InsertCoachingTemplate(PerformanceCoachingEntity PerformanceCoachingEntity);
        IEnumerable<dynamic> GetCoachingTemplateByID(object filter);
        Int64 UpdateCoachingTemplate(PerformanceCoachingEntity PerformanceCoachingEntity);
        Int64 DeleteCoachingTemplate(object filter);
       
    }
}



