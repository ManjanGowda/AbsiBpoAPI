using AbsiBpoAPI.Business.Interface;
using AbsiBpoAPI.Data.Interface;
using StaticWebAPI.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsiBpoAPI.Business.Managers
{
    public class LmsManager : ILmsManager
    {
        public ILmsRepository ILmsRepository;
        public LmsManager(ILmsRepository ILmsRepository)
        {
            this.ILmsRepository = ILmsRepository;
        }
    }
}




