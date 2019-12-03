using Pidev.data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class Miss
    {
        public int id_mission { get; set; }
        [DisplayFormat(DataFormatString = "{ yyyy - MM - dd}")]

        public DateTime? dateDu { get; set; }
        [DisplayFormat(DataFormatString = "{ yyyy - MM - dd}")]

        public DateTime? dateFin { get; set; }
        public bool etat { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
       
      
        public string libelle { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string lieuMission { get; set; }

        public double? montantAlloue { get; set; }
        public string motifMission { get; set; }


        public virtual ICollection<exp> expenses { get; set; }
        public virtual ICollection<user> user { get; set; }
    }
}
