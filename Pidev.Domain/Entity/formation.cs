namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public class formation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public formation()
        {
            formationcomment = new HashSet<formationcomment>();
            formationnote = new HashSet<formationnote>();
            user = new HashSet<user>();
        }

        [Key]
        public int id_formation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateDeb_formation { get; set; }

        [StringLength(255)]
        public string description_formation { get; set; }

        [StringLength(255)]
        public string duree_formation { get; set; }

        [StringLength(255)]
        public string niveau_formation { get; set; }

        [StringLength(255)]
        public string nom_formation { get; set; }

        public float prix_formation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formationcomment> formationcomment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formationnote> formationnote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> user { get; set; }
    }
}
