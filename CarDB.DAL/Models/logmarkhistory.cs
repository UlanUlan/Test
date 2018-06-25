namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logmarkhistory")]
    public partial class logmarkhistory
    {
        [Key]
        [Column(Order = 0)]
        public string database_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public string mark_name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Key]
        [Column(Order = 2)]
        public string user_name { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal lsn { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime mark_time { get; set; }
    }
}
