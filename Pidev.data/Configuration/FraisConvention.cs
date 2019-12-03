using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pidev.data.Configuration
{
    class FraisConvention : EntityTypeConfiguration<frais>
    {
        public FraisConvention()
        {
            HasOptional(f => f.expenses).
               WithMany(p => p.frais).
               HasForeignKey(f => f.uneExp_id_Exp).
               WillCascadeOnDelete(false);

        }

    }
}
