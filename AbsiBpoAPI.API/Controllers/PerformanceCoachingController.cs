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



        //[HttpGet]
        //[Route("PerformanceCoaching/GetCoachingSessions")]
        //public HttpResponseMessage GetCoachingSessions()
        //{
        //    HttpResponseMessage response;
        //    try
        //    {
        //        object res = IPerformanceCoachingManager.GetCoachingSessions();
        //        response = Request.CreateResponse(HttpStatusCode.OK, res);
        //    }
        //    catch (Exception ex)
        //    {
        //        if (log.IsErrorEnabled)
        //        {
        //            log.Error(" Error in GetCoachingSessions in Master Controller" + ex);
        //        }
        //        response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //    return response;
        //}


        //[HttpPost]
        //[Route("PerformanceCoaching/InsertCoachingSessions")]
        //public HttpResponseMessage InsertCoachingSessions(PerformanceCoachingEntity PerformanceCoachingEntity)
        //{
        //    HttpResponseMessage response;
        //    try
        //    {
        //        Int64 result = IPerformanceCoachingManager.InsertCoachingSessions(PerformanceCoachingEntity);
        //        response = Request.CreateResponse(HttpStatusCode.OK, result);
        //    }
        //    catch (Exception ex)
        //    {
        //        if (log.IsErrorEnabled)
        //        {
        //            log.Error("Error in InsertCoachingSessions", ex);
        //        }
        //        response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + "Error:InsertCoachingSessions");
        //    }
        //    return response;
        //}




        //[HttpGet]
        //[Route("Master/GetCityMaster")]
        //public HttpResponseMessage GetCityMaster()
        //{
        //    HttpResponseMessage response;
        //    try
        //    {
        //        object res = IMasterManager.GetCityMaster();
        //        response = Request.CreateResponse(HttpStatusCode.OK, res);
        //    }
        //    catch (Exception ex)
        //    {
        //        if (log.IsErrorEnabled)
        //        {
        //            log.Error(" Error in GetCityMaster in Master Controller" + ex);
        //        }
        //        response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //    return response;
        //}





    }
}
