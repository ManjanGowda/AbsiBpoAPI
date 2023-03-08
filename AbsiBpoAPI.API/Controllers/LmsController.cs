using log4net;
using StaticWebAPI.Business.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;

namespace AbsiBpoAPI.API.Controllers
{
    public class LmsController : ApiController
    {
        public ILmsManager ILmsManager;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public LmsController(ILmsManager ILmsManager)
        {
            this.ILmsManager = ILmsManager;
        }



        [HttpPost]
        [Route("Master/UploadAssessmentMaterials")]
        public HttpResponseMessage UploadAssessmentMaterials()
        {
            HttpResponseMessage response;
            try
            {
                string result = string.Empty;
                var httpRequest = HttpContext.Current.Request;
                if (httpRequest.Files.Count > 0)
                {
                    foreach (string file in httpRequest.Files)
                    {
                        var postedFile = httpRequest.Files[file];
                        //var type = postedFile.ContentType;
                        var Name = postedFile.FileName.Split('\\').LastOrDefault().Split('/').LastOrDefault().Replace(" ", null);
                        var time = DateTime.Now.ToString("yyyyMMddHHmmss");
                        var fileName = time + Name;
                        Directory.CreateDirectory(HostingEnvironment.MapPath("~/Assets/AssessmentMaterials"));
                        string filePath = HostingEnvironment.MapPath("~/Assets/AssessmentMaterials/" + fileName);
                        postedFile.SaveAs(filePath);
                        result = filePath;
                    }
                }
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Master/AssessmentMaterials/:" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Master Error " + ex.Message);
            }
            return response;
        }


    }
}




