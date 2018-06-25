namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syscategories
    {
        [Key]
        [Column(Order = 0)]
        public int category_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int category_class { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte category_type { get; set; }

        [Key]
        [Column(Order = 3)]
        public string name { get; set; }
    }
}
