using MyFinance.Data;
using Pidev.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructure
{
    public class DataBaseFactory : Disposable,IDataBaseFactory
    {
        private MyContext dataContext;

        public MyContext DataContext 
        {
            get { return dataContext; }
            
        }

        public DataBaseFactory()
        {
            dataContext = new MyContext();
        }
        protected override void DisposeCore() //libérer l'espace mémoire occupé par le ctx
        {
            if(DataContext!=null)

           DataContext.Dispose();
            
        }


    }
}
