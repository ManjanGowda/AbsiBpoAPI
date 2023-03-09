using AbsiBpoAPI.Data.Interface;
using AbsiBpoAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Data.Interface
{
    public interface IPerformanceCoachingRepository
    {
        // Coaching sessions
        IEnumerable<T> GetCoachingSessions<T>();
        Int64 InsertCoachingSessions(object filter);
        IEnumerable<T> GetCoachingSessionsByID<T>(object filter);
        Int64 UpdateCoachingSessions(object filter);
        Int64 DeleteCoachingSessions(object filter);

        //coaching template
        IEnumerable<T> GetCoachingTemplate<T>();
        Int64 InsertCoachingTemplate(object filter);
        IEnumerable<T> GetCoachingTemplateByID<T>(object filter);
        Int64 UpdateCoachingTemplate(object filter);
        Int64 DeleteCoachingTemplate(object filter);


    }
}
