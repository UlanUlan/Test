namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sqlagent_info
    {
        [Key]
        [Column(Order = 0)]
        public string attribute { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(512)]
        public string value { get; set; }
    }
}
