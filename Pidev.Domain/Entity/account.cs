namespace Pidev.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public  class account
    {

        public int id { get; set; }

        public double amount { get; set; }

        public int numAccount { get; set; }

     public virtual ICollection<user> user { get; set; }
    }
}
