namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   public class formationnote
    {
        [Key]
        public int id_note { get; set; }

        public double? noteF { get; set; }

        public int? formation_id_formation { get; set; }

        public virtual formation formation { get; set; }
    }
}
