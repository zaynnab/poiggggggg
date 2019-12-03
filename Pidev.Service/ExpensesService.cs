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
    public class ExpensesService : Service<expenses>, IExpensesService
    {

        static IDataBaseFactory Factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(Factory);
        public ExpensesService() : base(utk)
        { }

        public IEnumerable<expenses> GetexpByDate(DateTime id)
        {

            return GetMany(f => f.DateExpense == (id));
        }
        public IEnumerable<expenses> GetexpByType(string id)
        {
            return GetMany(f => f.NatureDepense.ToString().Contains(id));

        }
        public IEnumerable<expenses> GetexpMt(float id)
        {
            return GetMany(f => f.MontantTotal>id);

        }
    }
    
    }

