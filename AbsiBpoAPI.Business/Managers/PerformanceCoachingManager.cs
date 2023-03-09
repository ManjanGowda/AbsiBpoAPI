using AbsiBpoAPI.Business.Interface;
using AbsiBpoAPI.Data.Interface;
using System.Collections.Generic;
using System;
using AbsiBpoAPI.Business.Entities;

namespace AbsiBpoAPI.Business.Managers
{
    public class PerformanceCoachingManager : IPerformanceCoachingManager
    {
        public IPerformanceCoachingRepository IPerformanceCoachingRepository;
        public PerformanceCoachingManager(IPerformanceCoachingRepository IPerformanceCoachingRepository)
        {
            this.IPerformanceCoachingRepository = IPerformanceCoachingRepository;
        }
        //coaching sessions
        public IEnumerable<dynamic> GetCoachingSessions()
        {
            try
            {
                return IPerformanceCoachingRepository.GetCoachingSessions<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetCoachingSessionsByID(object filter)
        {
            try
            {
                return IPerformanceCoachingRepository.GetCoachingSessionsByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 InsertCoachingSessions(PerformanceCoachingEntity PerformanceCoachingEntity)
        {
            try
            {
                var filter = new
                {
                    EmployeeID = PerformanceCoachingEntity.EmployeeID,
                    CoachingDate = PerformanceCoachingEntity.CoachingDate,
                    CoachingTime = PerformanceCoachingEntity.CoachingTime,
                    CoachingTemplateID = PerformanceCoachingEntity.CoachingTemplateID,
                    Status = PerformanceCoachingEntity.Status
                };
                return IPerformanceCoachingRepository.InsertCoachingSessions(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateCoachingSessions(PerformanceCoachingEntity PerformanceCoachingEntity)
        {
            try
            {
                var filter = new
                {
                    ID = PerformanceCoachingEntity.ID,
                    EmployeeID = PerformanceCoachingEntity.EmployeeID,
                    CoachingDate = PerformanceCoachingEntity.CoachingDate,
                    CoachingTime = PerformanceCoachingEntity.CoachingTime,
                    CoachingTemplateID = PerformanceCoachingEntity.CoachingTemplateID,
                    Status = PerformanceCoachingEntity.Status

                };
                return IPerformanceCoachingRepository.UpdateCoachingSessions(filter);
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
                return IPerformanceCoachingRepository.DeleteCoachingSessions(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //coaching template
        public IEnumerable<dynamic> GetCoachingTemplate()
        {
            try
            {
                return IPerformanceCoachingRepository.GetCoachingTemplate<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetCoachingTemplateByID(object filter)
        {
            try
            {
                return IPerformanceCoachingRepository.GetCoachingTemplateByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 InsertCoachingTemplate(PerformanceCoachingEntity PerformanceCoachingEntity)
        {
            try
            {
                var filter = new
                {
                    TemplateID = PerformanceCoachingEntity.TemplateID,
                    TemplateLogs = PerformanceCoachingEntity.TemplateLogs
                };
                return IPerformanceCoachingRepository.InsertCoachingTemplate(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateCoachingTemplate(PerformanceCoachingEntity PerformanceCoachingEntity)
        {
            try
            {
                var filter = new
                {
                    ID = PerformanceCoachingEntity.ID,
                    TemplateID = PerformanceCoachingEntity.TemplateID,
                    TemplateLogs = PerformanceCoachingEntity.TemplateLogs

                };
                return IPerformanceCoachingRepository.UpdateCoachingTemplate(filter);
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
                return IPerformanceCoachingRepository.DeleteCoachingTemplate(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}







