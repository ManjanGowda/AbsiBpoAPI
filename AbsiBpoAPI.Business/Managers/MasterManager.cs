using AbsiBpoAPI.Business.Entities;
using AbsiBpoAPI.Business.Interface;
using AbsiBpoAPI.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Resources;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Business.Managers
{
    public class MasterManager : IMasterManager
    {
        public IMasterRrepository IMasterRrepository;
        public MasterManager(IMasterRrepository IMasterRrepository)
        {
            this.IMasterRrepository = IMasterRrepository;
        }

        public IEnumerable<dynamic> GetStaff()
        {
            try
            {
                return IMasterRrepository.GetStaff<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetStaffByID(object filter)
        {
            try
            {
                return IMasterRrepository.GetStaffByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 DeleteStaff(object filter)
        {
            try
            {
                return IMasterRrepository.DeleteStaff(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 InsertStaff(MasterEntity MasterEntity)
        {
            try
            {
                var filter = new
                {

                    FirstName = MasterEntity.FirstName,
                    LastName = MasterEntity.LastName,
                    PhoneNumber = MasterEntity.PhoneNumber,
                    EmailID = MasterEntity.EmailID,
                    Password = MasterEntity.Password,
                    RoleID = MasterEntity.RoleID,
                    ModuleID = MasterEntity.ModuleID,
                    RoasterID = MasterEntity.RoasterID,
                    ManagerID = MasterEntity.ManagerID,
                    TeamLeadID = MasterEntity.TeamLeadID


                };
                return IMasterRrepository.InsertStaff(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateStaff(MasterEntity Entity)
        {
            try
            {
                var filter = new
                {
                    ID = Entity.ID,
                    FirstName = Entity.FirstName,
                    LastName = Entity.LastName,
                    PhoneNumber = Entity.PhoneNumber,
                    EmailID = Entity.EmailID,
                    Password = Entity.Password,
                    RoleID = Entity.RoleID,
                    ModuleID = Entity.ModuleID,
                    RoasterID = Entity.RoasterID,
                    ManagerID = Entity.ManagerID,
                    TeamLeadID = Entity.TeamLeadID


                };
                return IMasterRrepository.UpdateStaff(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        public IEnumerable<dynamic> GetIncidentMaster()
        {
            try
            {
                return IMasterRrepository.GetIncidentMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetIncidentMasterByID(object filter)
        {
            try
            {
                return IMasterRrepository.GetIncidentMasterByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 DeleteIncidentMaster(object filter)
        {
            try
            {
                return IMasterRrepository.DeleteIncidentMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 InsertIncidentMaster(MasterEntity MasterEntity)
        {
            try
            {
                var filter = new
                {

                    Incident = MasterEntity.Incident,
                    Description = MasterEntity.Description

                };
                return IMasterRrepository.InsertIncidentMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateIncidentMaster(MasterEntity Entity)
        {
            try
            {
                var filter = new
                {
                    ID = Entity.ID,
                    Incident = Entity.Incident,
                    Description = Entity.Description
                 


                };
                return IMasterRrepository.UpdateIncidentMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        public IEnumerable<dynamic> GetRoasterMaster()
        {
            try
            {
                return IMasterRrepository.GetRoasterMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<dynamic> GetModuleMaster()
        {
            try
            {
                return IMasterRrepository.GetModuleMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetQuestionTypeMaster()
        {
            try
            {
                return IMasterRrepository.GetQuestionTypeMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetRoleMaster()
        {
            try
            {
                return IMasterRrepository.GetRoleMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        public IEnumerable<dynamic> GetIncidents()
        {
            try
            {
                return IMasterRrepository.GetIncidents<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetIncidentsByID(object filter)
        {
            try
            {
                return IMasterRrepository.GetIncidentsByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Int64 InsertIncidents(IncidentEntity IncidentEntity)
        {
            try
            {
                var filter = new
                {

                    
                    EmployeeID = IncidentEntity.EmployeeID,
                    ManagerID = IncidentEntity.ManagerID,
                    IncidentDate = IncidentEntity.IncidentDate,
                    Description = IncidentEntity.Description,
                    StatusID = IncidentEntity.StatusID,
                    RoleID = IncidentEntity.RoleID,
                    Location = IncidentEntity.Location,
                    SpecificArea = IncidentEntity.SpecificArea,
                    IncidentTime = IncidentEntity.IncidentTime,
                    IncidentMasterID = IncidentEntity.IncidentMasterID

                }; 
                return IMasterRrepository.InsertIncidents(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateIncidents(IncidentEntity IncidentEntity)
        {
            try
            {
                var filter = new
                {
                    ID = IncidentEntity.ID,
                    IncidentID = IncidentEntity.IncidentID,
                    EmployeeID = IncidentEntity.EmployeeID,
                    ManagerID = IncidentEntity.ManagerID,
                    IncidentDate = IncidentEntity.IncidentDate,
                    Description = IncidentEntity.Description,
                    StatusID = IncidentEntity.StatusID,
                    RoleID = IncidentEntity.RoleID,
                    Location = IncidentEntity.Location,
                    SpecificArea = IncidentEntity.SpecificArea,
                    IncidentTime = IncidentEntity.IncidentTime



                };
                return IMasterRrepository.UpdateIncidents(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 DeleteIncidents(object filter)
        {
            try
            {
                return IMasterRrepository.DeleteIncidents(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetIncidentStatusMaster()
        {
            try
            {
                return IMasterRrepository.GetIncidentStatusMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> ValidateStaffLogin(object filter)
        {
            try
            {
                return IMasterRrepository.ValidateStaffLogin<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> InsertStaffModuleMapping(object filter)
        {
            try
            {
                return IMasterRrepository.InsertStaffModuleMapping<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public IEnumerable<dynamic> GetRoasterMasterByID(object filter)
        {
            try
            {
                return IMasterRrepository.GetRoasterMasterByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Int64 InsertRoasterMaster(IncidentEntity IncidentEntity)
        {
            try
            {
                var filter = new
                {

                    Short = IncidentEntity.Short,
                    ShiftTypeMasterID= IncidentEntity.ShiftTypeMasterID,
                    StartTime= IncidentEntity.StartTime,
                    EndTime = IncidentEntity.EndTime,



                };
                return IMasterRrepository.InsertRoasterMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateRoasterMaster(IncidentEntity IncidentEntity)
        {
            try
            {
                var filter = new
                {
                    ID = IncidentEntity.ID,
                    Short = IncidentEntity.Short,
                    ShiftTypeMasterID = IncidentEntity.ShiftTypeMasterID,
                    StartTime = IncidentEntity.StartTime,
                    EndTime = IncidentEntity.EndTime




                };
                return IMasterRrepository.UpdateRoasterMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 DeleteRoasterMaster(object filter)
        {
            try
            {
                return IMasterRrepository.DeleteRoasterMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetAssessment()
        {
            try
            {
                return IMasterRrepository.GetAssessment<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 InsertAssessment(AssessmentEntity AssessmentEntity)
        {
            try
            {
                var filter = new
                {

                    AssessmentName = AssessmentEntity.AssessmentName,
                    AssessmentDescription = AssessmentEntity.AssessmentDescription,
                    Duration = AssessmentEntity.Duration,
                    PassedPercentage = AssessmentEntity.PassedPercentage,
                    NumberOfQuestion = AssessmentEntity.NumberOfQuestion,
                    NumberOfMaterials = AssessmentEntity.NumberOfMaterials,

                };
                return IMasterRrepository.InsertAssessment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateAssessment(AssessmentEntity AssessmentEntity)
        {
            try
            {
                var filter = new
                {
                    ID = AssessmentEntity.ID,
                    AssessmentName = AssessmentEntity.AssessmentName,
                    AssessmentDescription = AssessmentEntity.AssessmentDescription,
                    Duration = AssessmentEntity.Duration,
                    PassedPercentage = AssessmentEntity.PassedPercentage,
                    NumberOfQuestion = AssessmentEntity.NumberOfQuestion,
                    NumberOfMaterials = AssessmentEntity.NumberOfMaterials,



                };
                return IMasterRrepository.UpdateAssessment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 DeleteAssessment(object filter)
        {
            try
            {
                return IMasterRrepository.DeleteAssessment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<dynamic> GetAssessmentQuestion()
        {
            try
            {
                return IMasterRrepository.GetAssessmentQuestion<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 InsertAssessmentQuestion(AssessmentEntity AssessmentEntity)
        {
            try
            {
                var filter = new
                {

                    AssessmentID = AssessmentEntity.AssessmentID,
                    QuestionTypeID = AssessmentEntity.QuestionTypeID,
                    Question = AssessmentEntity.Question,
                    OptionOne = AssessmentEntity.OptionOne,
                    OptionTwo = AssessmentEntity.OptionTwo,
                    OptionThree = AssessmentEntity.OptionThree,
                    OptionFour = AssessmentEntity.OptionFour,
                    CorrectOption = AssessmentEntity.CorrectOption

                };
                return IMasterRrepository.InsertAssessmentQuestion(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateAssessmentQuestion(AssessmentEntity AssessmentEntity)
        {
            try
            {
                var filter = new
                {
                    ID = AssessmentEntity.ID,
                    AssessmentID = AssessmentEntity.AssessmentID,
                    QuestionTypeID = AssessmentEntity.QuestionTypeID,
                    Question = AssessmentEntity.Question,
                    OptionOne = AssessmentEntity.OptionOne,
                    OptionTwo = AssessmentEntity.OptionTwo,
                    OptionThree = AssessmentEntity.OptionThree,
                    OptionFour = AssessmentEntity.OptionFour,
                    CorrectOption = AssessmentEntity.CorrectOption



                };
                return IMasterRrepository.UpdateAssessmentQuestion(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 DeleteAssessmentQuestion(object filter)
        {
            try
            {
                return IMasterRrepository.DeleteAssessmentQuestion(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public IEnumerable<dynamic> GetAssessmentMaterial()
        {
            try
            {
                return IMasterRrepository.GetAssessmentMaterial<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetAssessmentMaterialByID(object filter)
        {
            try
            {
                return IMasterRrepository.GetAssessmentMaterialByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 InsertAssessmentMaterial(AssessmentEntity AssessmentEntity)
        {
            try
            {
                var filter = new
                {
                    Name = AssessmentEntity.Name,
                    MaterialType = AssessmentEntity.MaterialType,
                    Size = AssessmentEntity.Size,
                    AttachmentURL = AssessmentEntity.AttachmentURL,
                    


                };
                return IMasterRrepository.InsertAssessmentMaterial(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Int64 UpdateAssessmentMaterial(AssessmentEntity AssessmentEntity)
        {
            try
            {
                var filter = new
                {
                    ID = AssessmentEntity.ID,
                    MaterialType = AssessmentEntity.MaterialType,
                    Size = AssessmentEntity.Size,
                    AttachmentURL = AssessmentEntity.AttachmentURL,


                };
                return IMasterRrepository.UpdateAssessmentMaterial(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 DeleteAssessmentMaterial(object filter)
        {
            try
            {
                return IMasterRrepository.DeleteAssessmentMaterial(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetShiftTypeMaster()
        {
            try
            {
                return IMasterRrepository.GetShiftTypeMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetShiftTypeMasterByID(object filter)
        {
            try
            {
                return IMasterRrepository.GetShiftTypeMasterByID<dynamic>(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
