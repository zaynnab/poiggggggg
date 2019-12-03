using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.CustomConvertions
{
    public class DatetTime2Convention:Convention
    {
        public DatetTime2Convention()
        {
            Properties<DateTime>().Configure(prop=>prop.HasColumnType("datetime"));
        }
    }
}
