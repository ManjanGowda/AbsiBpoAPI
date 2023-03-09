using AbsiBpoAPI.Business.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Http;
using AbsiBpoAPI.Business.Entities;

namespace AbsiBpoAPI.API.Controllers
{
    public class PerformanceCoachingController : ApiController
    {
        public IPerformanceCoachingManager IPerformanceCoachingManager;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public PerformanceCoachingController(IPerformanceCoachingManager IPerformanceCoachingManager)
        {
            this.IPerformanceCoachingManager = IPerformanceCoachingManager;
        }
        //coaching sessions
        [HttpGet]
        [Route("PerformanceCoaching/GetCoachingSessions")]
        public HttpResponseMessage GetCoachingSessions()
        {
            HttpResponseMessage response;
            try
            {
                object res = IPerformanceCoachingManager.GetCoachingSessions();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetCoachingSessions in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
        [HttpGet]
        [Route("PerformanceCoaching/GetCoachingSessionsByID")]
        public HttpResponseMessage GetCoachingSessionsByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var j = new
                {
                    ID = ID
                };
                object res = IPerformanceCoachingManager.GetCoachingSessionsByID(j);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetCoachingSessionsByID in performance Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
        [HttpPost]
        [Route("PerformanceCoaching/InsertCoachingSessions")]
        public HttpResponseMessage InsertCoachingSessions(PerformanceCoachingEntity PerformanceCoachingEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 result = IPerformanceCoachingManager.InsertCoachingSessions(PerformanceCoachingEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertCoachingSessions", ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + "Error:InsertCoachingSessions");
            }
            return response;
        }
        [HttpPost]
        [Route("PerformanceCoaching/UpdateCoachingSessions")]
        public HttpResponseMessage UpdateCoachingSessions(PerformanceCoachingEntity PerformanceCoachingEntity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IPerformanceCoachingManager.UpdateCoachingSessions(PerformanceCoachingEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in UpdateCoachingSessions in Performance Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
        [HttpGet]
        [Route("PerformanceCoaching/DeleteCoachingSessions")]
        public HttpResponseMessage DeleteCoachingSessions(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 Result = IPerformanceCoachingManager.DeleteCoachingSessions(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Users/DeleteCoachingSessions :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Users/DeleteCoachingSessions");
            }
            return response;
        }
        //coaching template

        [HttpGet]
        [Route("PerformanceCoaching/GetCoachingTemplate")]
        public HttpResponseMessage GetCoachingTemplate()
        {
            HttpResponseMessage response;
            try
            {
                object res = IPerformanceCoachingManager.GetCoachingTemplate();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetCoachingTemplate in PerformanceCoaching Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
        [HttpGet]
        [Route("PerformanceCoaching/GetCoachingTemplateByID")]
        public HttpResponseMessage GetCoachingTemplateByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var j = new
                {
                    ID = ID
                };
                object res = IPerformanceCoachingManager.GetCoachingTemplateByID(j);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetCoachingTemplateByID in PerformanceCoaching Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
        [HttpPost]
        [Route("PerformanceCoaching/InsertCoachingTemplate")]
        public HttpResponseMessage InsertCoachingTemplate(PerformanceCoachingEntity PerformanceCoachingEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 result = IPerformanceCoachingManager.InsertCoachingTemplate(PerformanceCoachingEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertCoachingTemplate", ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + "Error:InsertCoachingTemplate");
            }
            return response;
        }
        [HttpPost]
        [Route("PerformanceCoaching/UpdateCoachingTemplate")]
        public HttpResponseMessage UpdateCoachingTemplate(PerformanceCoachingEntity PerformanceCoachingEntity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IPerformanceCoachingManager.UpdateCoachingTemplate(PerformanceCoachingEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in UpdateCoachingTemplate in Performance Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
        [HttpGet]
        [Route("PerformanceCoaching/DeleteCoachingTemplate")]
        public HttpResponseMessage DeleteCoachingTemplate(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 Result = IPerformanceCoachingManager.DeleteCoachingTemplate(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Users/DeleteCoachingTemplate :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Users/DeleteCoachingTemplate");
            }
            return response;
        }







    }
}
