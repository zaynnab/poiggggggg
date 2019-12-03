using Pidev.data;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public interface IExpensesService : IService<expenses>
    {
        IEnumerable<expenses> GetexpByDate(DateTime id);
        IEnumerable<expenses> GetexpByType(string id);

     IEnumerable<expenses> GetexpMt(float id);
    }
}
