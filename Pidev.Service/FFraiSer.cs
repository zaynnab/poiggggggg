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
   public class FFraiSer : Service<frais>, IFFraiSer
    {

        static IDataBaseFactory Factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(Factory);
        public FFraiSer() : base(utk)
        { }


      public  IEnumerable<frais> GetFraiByLib(string id)
        {
            return GetMany(f => f.libelle.Contains(id));

        }
    }

}