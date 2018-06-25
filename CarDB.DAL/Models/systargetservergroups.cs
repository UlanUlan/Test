namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class systargetservergroups
    {
        [Key]
        [Column(Order = 0)]
        public int servergroup_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string name { get; set; }
    }
}
