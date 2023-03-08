using AbsiBpoAPI.Data.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Data.Repositories
{
    public class MasterRepository : Repository, IMasterRrepository
    {


        public IEnumerable<T> GetStaff<T>()
        {
            try
            {
                db.Open();
                var res= db.Query<T>("SProc_GetStaff", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetStaffByID<T>(object filter)
        {
            try
            {
                db.Open();
                var res= db.Query<T>("SProc_GetStaffByID", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;

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
                db.Open();
                var res= db.Execute("[SProc_DeleteStaff]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 InsertStaff(object filter)
        {
            try
            {
                db.Open();
                var res= db.Query<Int64>("[dbo].[SProc_InsertStaff]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res; 

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateStaff(object filter)
        {
            try
            {
                db.Open();
                var res= db.Query<Int64>("SProc_UpdateStaff", filter, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<T> GetIncidentMaster<T>()
        {
            try
               
            {
                db.Open();
                var res= db.Query<T>("SProc_GetIncidentMaster", commandType: CommandType.StoredProcedure);
                db.Close();
                return res; 

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetIncidentMasterByID<T>(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_GetIncidentMasterByID", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
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
                db.Open();  
                var res = db.Execute("[SProc_DeleteIncidentMaster]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 InsertIncidentMaster(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_InsertIncidentMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateIncidentMaster(object filter)
        {
            try
            {
                db.Open();
                var res= db.Query<Int64>("SProc_UpdateIncidentMaster", filter, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        public IEnumerable<T> GetRoleMaster<T>()
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_GetRoleMaster", commandType: CommandType.StoredProcedure);
                db.Close();
                return res; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetRoasterMaster<T>()
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_GetRoasterMaster", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetQuestionTypeMaster<T>()
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_GetQuestionTypeMaster", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetModuleMaster<T>()
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_GetModuleMaster", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        public IEnumerable<T> GetIncidents<T>()
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_GetIncidents", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<T> GetIncidentsByID<T>(object filter)
        {
            try
            {
                db.Open();
                var res= db.Query<T>("SProc_GetIncidentsByID", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Int64 InsertIncidents(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_InsertIncidents]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateIncidents(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<Int64>("SProc_UpdateIncidents", filter, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
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
                db.Open();
                var res = db.Execute("[SProc_DeleteIncidents]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetIncidentStatusMaster<T>()
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_GetIncidentStatusMaster", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<T> ValidateStaffLogin<T>(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_ValidateStaffLogin", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> InsertStaffModuleMapping<T>(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_InsertStaffModuleMapping", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public IEnumerable<T> GetRoasterMasterByID<T>(object filter)
        {
            try
            {
                db.Open();
                var res= db.Query<T>("SProc_GetRoasterMasterByID", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Int64 InsertRoasterMaster(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_InsertRoasterMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateRoasterMaster(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<Int64>("SProc_UpdateRoasterMaster", filter, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;
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
                db.Open();
                var res = db.Execute("[SProc_DeleteRoasterMaster]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<T> GetAssessment<T>()
        {
            try
            {
                db.Open();
                var res= db.Query<T>("SProc_GetAssessment", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 InsertAssessment(object filter)
        {
            try
            {
                db.Open();
                var res= db.Query<Int64>("[dbo].[SProc_InsertAssessment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateAssessment(object filter)
        {
            try
            {
                db.Open();
                var res= db.Query<Int64>("SProc_UpdateAssessment", filter, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;

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
                db.Open();
                var res= db.Execute("[SProc_DeleteAssessment]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<T> GetAssessmentQuestion<T>()
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_GetAssessmentQuestion", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Int64 InsertAssessmentQuestion(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_InsertAssessmentQuestion]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateAssessmentQuestion(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<Int64>("SProc_UpdateAssessmentQuestion", filter, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;

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
                db.Open();
                var res = db.Execute("[SProc_DeleteAssessmentQuestion]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        public IEnumerable<T> GetAssessmentMaterial<T>()
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_GetAssessmentMaterial", commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<T> GetAssessmentMaterialByID<T>(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<T>("SProc_GetAssessmentMaterialByID", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Int64 InsertAssessmentMaterial(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<Int64>("[dbo].[SProc_InsertAssessmentMaterial]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int64 UpdateAssessmentMaterial(object filter)
        {
            try
            {
                db.Open();
                var res = db.Query<Int64>("SProc_UpdateAssessmentMaterial", filter, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
                db.Close();
                return res;

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
                db.Open();
                var res = db.Execute("[SProc_DeleteAssessmentMaterial]", filter, commandType: CommandType.StoredProcedure);
                db.Close();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }

}
