namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
public class formationcomment
    {
        [Key]
        public int id_comment { get; set; }

        [StringLength(255)]
        public string contenu { get; set; }

        public DateTime? dateComment { get; set; }

        public int? formation_id_formation { get; set; }

        public int? user_id_user { get; set; }

        public virtual formation formation { get; set; }

        public virtual user user { get; set; }
    }
}
