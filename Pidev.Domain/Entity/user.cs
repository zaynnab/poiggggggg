namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
public class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            formationcomment = new HashSet<formationcomment>();
            formation = new HashSet<formation>();
        }

        [Key]
        public int id_user { get; set; }

        [StringLength(255)]
        public string address_user { get; set; }

        [StringLength(255)]
        public string cin_user { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_de_naissance_user { get; set; }

        [StringLength(255)]
        public string email_user { get; set; }

        [Column(TypeName = "bit")]
        public bool isActif_user { get; set; }

        [StringLength(255)]
        public string nom_user { get; set; }

        [StringLength(255)]
        public string password_user { get; set; }

        [StringLength(255)]
        public string prenom_user { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        [StringLength(255)]
        public string sexe { get; set; }

        public int? account_id { get; set; }

        public int? mis_id_mission { get; set; }

        public virtual account account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formationcomment> formationcomment { get; set; }

        public virtual mission mission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formation> formation { get; set; }
    }
}
