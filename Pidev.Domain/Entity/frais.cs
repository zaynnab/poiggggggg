namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("rapports")]
    public  class frais
    {
      
        [Key]
        public int id_frais { get; set; }
        public string libelle { get; set; }
        public DateTime? DTreat { get; set; }

        public float NetRemb { get; set; }

        [Column(TypeName = "bit")]
        public bool StatusFrais { get; set; }
        public int? uneExp_id_Exp { get; set; }

        public virtual expenses expenses { get; set; }
    }
}
