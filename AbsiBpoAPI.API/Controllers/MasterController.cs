using AbsiBpoAPI.Business.Interface;
using System.Net.Http;
using System.Net;
using System;
using System.Web.Http;
using log4net;
using System.Reflection;
using AbsiBpoAPI.Business.Entities;
using System.Configuration;
using System.Web.Configuration;
using System.Web;
using System.Net.Configuration;
using System.Net.Mail;
using System.Linq;
using System.IO;
using System.Web.Hosting;
using System.Drawing;
using System.Web.Http.Results;
using System.Collections.Generic;

namespace AbsiBpoAPI.API.Controllers
{
    public class MasterController : ApiController
    {
        public IMasterManager IMasterManager;

        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public MasterController(IMasterManager IMasterManager)
        {
            this.IMasterManager = IMasterManager;
        }



        [HttpGet]
        [Route("Master/GetStaff")]
        public HttpResponseMessage GetStaff()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetStaff();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetStaff in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/GetStaffByID")]
        public HttpResponseMessage GetStaffByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var j = new
                {
                    ID = ID
                };
                object res = IMasterManager.GetStaffByID(j);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetStaffByID in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/DeleteStaff")]
        public HttpResponseMessage DeleteStaff(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 Result = IMasterManager.DeleteStaff(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Users/DeleteStaff :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Users/DeleteStaff");
            }
            return response;
        }


        [HttpPost]
        [Route("Master/InsertStaff")]
        public HttpResponseMessage InsertStaff(MasterEntity MasterEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 result = IMasterManager.InsertStaff(MasterEntity);

                var entity = new
                {
                    StaffID = result,
                    PerformanceCoaching = MasterEntity.PerformanceCoaching,
                    ProgressionTracking = MasterEntity.ProgressionTracking,
                    Lms = MasterEntity.Lms,
                };

                object res = IMasterManager.InsertStaffModuleMapping(entity);

                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertStaff", ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + "Error:InsertStaff");
            }
            return response;
        }




        [HttpPost]
        [Route("Master/UpdateStaff")]
        public HttpResponseMessage UpdateStaff([FromBody] MasterEntity MasterEntity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateStaff(MasterEntity);

                var entity = new
                {
                    StaffID = MasterEntity.ID,
                    PerformanceCoaching = MasterEntity.PerformanceCoaching,
                    ProgressionTracking = MasterEntity.ProgressionTracking,
                    Lms = MasterEntity.Lms,
                };

                object resc = IMasterManager.InsertStaffModuleMapping(entity);

                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in UpdateStaff in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }





        [HttpGet]
        [Route("Master/GetIncidentMaster")]
        public HttpResponseMessage GetIncidentMaster()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetIncidentMaster();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetStaff in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetIncidentMasterByID")]
        public HttpResponseMessage GetIncidentMasterByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var j = new
                {
                    ID = ID
                };
                object res = IMasterManager.GetIncidentMasterByID(j);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetIncidentMasterByID in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/DeleteIncidentMaster")]
        public HttpResponseMessage DeleteIncidentMaster(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 Result = IMasterManager.DeleteIncidentMaster(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Users/DeleteIncidentMaster :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Users/DeleteIncidentMaster");
            }
            return response;
        }



        [HttpPost]
        [Route("Master/InsertIncidentMaster")]
        public HttpResponseMessage InsertIncidentMaster(MasterEntity MasterEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 result = IMasterManager.InsertIncidentMaster(MasterEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertIncidentMaster", ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + "Error:InsertIncidentMaster");
            }
            return response;
        }



        [HttpPost]
        [Route("Master/UpdateIncidentMaster")]
        public HttpResponseMessage UpdateIncidentMaster([FromBody] MasterEntity Entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateIncidentMaster(Entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in UpdateIncidentMaster in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }





        [HttpGet]
        [Route("Master/GetQuestionTypeMaster")]
        public HttpResponseMessage GetQuestionTypeMaster()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetQuestionTypeMaster();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetQuestionTypeMaster in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetRoasterMaster")]
        public HttpResponseMessage GetRoasterMaster()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetRoasterMaster();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetRoasterMaster in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetRoleMaster")]
        public HttpResponseMessage GetRoleMaster()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetRoleMaster();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetRoleMaster in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetModuleMaster")]
        public HttpResponseMessage GetModuleMaster()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetModuleMaster();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetModuleMaster in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }




        [HttpGet]
        [Route("Master/GetIncidents")]
        public HttpResponseMessage GetIncidents()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetIncidents();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetIncidents in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetIncidentsByID")]
        public HttpResponseMessage GetIncidentsByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var j = new
                {
                    ID = ID
                };
                object res = IMasterManager.GetIncidentsByID(j);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetIncidentsByID in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpPost]
        [Route("Master/InsertIncidents")]
        public HttpResponseMessage InsertIncidents(IncidentEntity IncidentEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 result = IMasterManager.InsertIncidents(IncidentEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertIncidents", ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + "Error:InsertIncidents");
            }
            return response;
        }




        [HttpPost]
        [Route("Master/UpdateIncidents")]
        public HttpResponseMessage UpdateIncidents([FromBody] IncidentEntity IncidentEntity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateIncidents(IncidentEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in UpdateIncidents in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }




        [HttpGet]
        [Route("Master/DeleteIncidents")]
        public HttpResponseMessage DeleteIncidents(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 Result = IMasterManager.DeleteIncidents(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Users/DeleteIncidents :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Users/DeleteIncidents");
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetIncidentStatusMaster")]
        public HttpResponseMessage GetIncidentStatusMaster()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetIncidentStatusMaster();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetIncidentStatusMaster in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpPost]
        [Route("Master/ValidateStaffLogin")]
        public HttpResponseMessage ValidateStaffLogin(MasterEntity MasterEntity)
        {
            HttpResponseMessage response;
            try
            {
                //string EmailID, string Password
                var j = new
                {
                    EmailID = MasterEntity.EmailID,
                    Password = MasterEntity.Password
                };
                object res = IMasterManager.ValidateStaffLogin(j);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in ValidateStaffLogin in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetRoasterMasterByID")]
        public HttpResponseMessage GetRoasterMasterByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var j = new
                {
                    ID = ID
                };
                object res = IMasterManager.GetRoasterMasterByID(j);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetRoasterMasterByID in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }




        [HttpPost]
        [Route("Master/InsertRoasterMaster")]
        public HttpResponseMessage InsertRoasterMaster(IncidentEntity IncidentEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 result = IMasterManager.InsertRoasterMaster(IncidentEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertRoasterMaster", ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + "Error:InsertRoasterMaster");
            }
            return response;
        }



        [HttpPost]
        [Route("Master/UpdateRoasterMaster")]
        public HttpResponseMessage UpdateRoasterMaster([FromBody] IncidentEntity IncidentEntity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateRoasterMaster(IncidentEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in UpdateRoasterMaster in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }




        [HttpGet]
        [Route("Master/DeleteRoasterMaster")]
        public HttpResponseMessage DeleteRoasterMaster(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 Result = IMasterManager.DeleteRoasterMaster(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Users/DeleteRoasterMaster :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Users/DeleteRoasterMaster");
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetAssessment")]
        public HttpResponseMessage GetAssessment()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetAssessment();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetIncidents in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/InsertAssessment")]
        public HttpResponseMessage InsertAssessment(AssessmentEntity AssessmentEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 result = IMasterManager.InsertAssessment(AssessmentEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertAssessment", ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + "Error:InsertAssessment");
            }
            return response;
        }




        [HttpPost]
        [Route("Master/UpdateAssessment")]
        public HttpResponseMessage UpdateAssessment([FromBody] AssessmentEntity AssessmentEntity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateAssessment(AssessmentEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in UpdateAssessment in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }




        [HttpGet]
        [Route("Master/DeleteAssessment")]
        public HttpResponseMessage DeleteAssessment(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 Result = IMasterManager.DeleteIncidents(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Users/DeleteAssessment :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Users/DeleteAssessment");
            }
            return response;
        }





        [HttpGet]
        [Route("Master/GetAssessmentQuestion")]
        public HttpResponseMessage GetAssessmentQuestion()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetAssessmentQuestion();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetAssessmentQuestion in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/InsertAssessmentQuestion")]
        public HttpResponseMessage InsertAssessmentQuestion(AssessmentEntity AssessmentEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 result = IMasterManager.InsertAssessmentQuestion(AssessmentEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertAssessmentQuestion", ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + "Error:InsertAssessmentQuestion");
            }
            return response;
        }




        [HttpPost]
        [Route("Master/UpdateAssessmentQuestion")]
        public HttpResponseMessage UpdateAssessmentQuestion([FromBody] AssessmentEntity AssessmentEntity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateAssessmentQuestion(AssessmentEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in UpdateAssessmentQuestion in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }




        [HttpGet]
        [Route("Master/DeleteAssessmentQuestion")]
        public HttpResponseMessage DeleteAssessmentQuestion(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 Result = IMasterManager.DeleteAssessmentQuestion(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Users/DeleteAssessmentQuestion :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Users/DeleteAssessmentQuestion");
            }
            return response;
        }




        [HttpGet]
        [Route("Master/GetAssessmentMaterial")]
        public HttpResponseMessage GetAssessmentMaterial()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetAssessmentMaterial();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetAssessmentMaterial in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetAssessmentMaterialByID")]
        public HttpResponseMessage GetAssessmentMaterialByID(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var j = new
                {
                    ID = ID
                };
                object res = IMasterManager.GetAssessmentMaterialByID(j);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in GetAssessmentMaterialByID in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }





        [HttpPost]
        [Route("Master/InsertAssessmentMaterial")]
        public HttpResponseMessage InsertAssessmentMaterial(AssessmentEntity AssessmentEntity)
        {
            HttpResponseMessage response;
            try
            {
                Int64 result = IMasterManager.InsertAssessmentMaterial(AssessmentEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertAssessmentMaterial", ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + "Error:InsertAssessmentMaterial");
            }
            return response;
        }




        [HttpPost]
        [Route("Master/UpdateAssessmentMaterial")]
        public HttpResponseMessage UpdateAssessmentMaterial([FromBody] AssessmentEntity AssessmentEntity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateAssessmentMaterial(AssessmentEntity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error(" Error in UpdateAssessmentMaterial in Master Controller" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }




        [HttpGet]
        [Route("Master/DeleteAssessmentMaterial")]
        public HttpResponseMessage DeleteAssessmentMaterial(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 Result = IMasterManager.DeleteAssessmentMaterial(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, Result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in Users/DeleteAssessmentMaterial :" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message + " Users/DeleteAssessmentMaterial");
            }
            return response;
        }



    }
}

