namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_shipping_primary_secondaries
    {
        [Key]
        [Column(Order = 0)]
        public Guid primary_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string secondary_server { get; set; }

        [Key]
        [Column(Order = 2)]
        public string secondary_database { get; set; }
    }
}
