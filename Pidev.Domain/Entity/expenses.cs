namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public enum Moyene { Voiture, Bateau, Avion, Train, Taxi }
    public enum Nature { Visa, Logement, Hotel, Repas, Voyage }
    [Table("depenses")]
    public  class expenses
    {
        [Key]
        public int id_Exp { get; set; }

        public DateTime? DateExpense { get; set; }

        public float MontantTotal { get; set; }

      
        public Nature NatureDepense { get; set; }

        [StringLength(255)]
        public string commentaire { get; set; }

        public float distance { get; set; }

        public Moyene moyTransport { get; set; }

        public int nbNuitete { get; set; }
        public string Justificatif { get; set; }

        public int? Frexp_id_frais { get; set; }

        public int? mm_id_mission { get; set; }

        public virtual ICollection<frais> frais { get; set; }
        [ForeignKey("id_mission")]

        public virtual mission mission { get; set; }
    }
}
