using MyFinance.Data.Infrastructure;
using Pidev.data;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
 public   class MissionService : Service<mission>, IMissionService
    {
        static IDataBaseFactory factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(factory);
        public MissionService() : base(utk)
        {

        }
    }
}

