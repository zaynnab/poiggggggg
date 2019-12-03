using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Models
{
    public class fraiVM
    {
       
    public int id_frais { get; set; }
        [MinLength(4)]
[Required]
        public string libelle { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date de rembourssement")]
        public DateTime? DTreat { get; set; }
        [Required]
        
        [Display(Name = "Montant à rembourser")]
        public float NetRemb { get; set; }

    public bool StatusFrais { get; set; }
        [Display(Name = "Pour la dépense")]
        public int? uneExp_id_Exp { get; set; }
    public virtual ICollection<SelectListItem> expenses { get; set; }
}
}
