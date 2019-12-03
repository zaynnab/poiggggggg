namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("mails")]
    public  class mail
    {  public int id { get; set; }

        [StringLength(255)]
        public string header { get; set; }

        [StringLength(255)]
        public string mailAdresse { get; set; }

        [StringLength(255)]
        public string name { get; set; }
    }
}
