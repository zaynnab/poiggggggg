namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  public class mission
    {
     
        [Key]
        public int id_mission { get; set; }

        public DateTime? dateDu { get; set; }

        public DateTime? dateFin { get; set; }

        [Column(TypeName = "bit")]
        public bool etat { get; set; }

        [StringLength(255)]
        public string libelle { get; set; }

        [StringLength(255)]
        public string lieuMission { get; set; }

        public double? montantAlloue { get; set; }

        [StringLength(255)]
        public string motifMission { get; set; }

        public virtual ICollection<expenses> expenses { get; set; }

       public virtual ICollection<user> user { get; set; }
    }
}
