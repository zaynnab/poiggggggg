using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Models
{

    public enum MoyeneVM { Voiture, Bateau, Avion, Train, Taxi }
    public enum NatureVM { Visa, Logement, Hotel, Repas, Voyage }
    public partial class exp
    {
       
        public int id_Exp { get; set; }
        [Required]

      
        [DataType(DataType.DateTime)]
        public DateTime? DateExpense { get; set; }
        public NatureVM NatureDepense { get; set; }
     

        [Display(Name = "Les jours")]

        public int nbNuitete { get; set; }



        public MoyeneVM moyTransport { get; set; }
        public float distance { get; set; }
        [Required]

       
    
        public float MontantTotal { get; set; }
        [StringLength(255)]
        public string commentaire { get; set; }

        public string Justificatif { get; set; }
        public virtual ICollection<fraiVM> frais { get; set; }

        [Display(Name = "mission")]
        public int? mm_id_mission
        {
            get; set;
        }
       
        public virtual ICollection<SelectListItem> missions { get; set; }
    }

    }

