using AbsiBpoAPI.Business.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace AbsiBpoAPI.API.Controllers
{
    public class ProgressionTrackingController : ApiController
    {
        public IProgressionTrackingManager IProgressionTrackingManager;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public ProgressionTrackingController(IProgressionTrackingManager IProgressionTrackingManager)
        {
            this.IProgressionTrackingManager = IProgressionTrackingManager;
        }

    }
}












