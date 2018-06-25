namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_cpu_utilization_stub
    {
        public DateTimeOffset? processing_time { get; set; }

        [Key]
        [Column(Order = 0)]
        public byte aggregation_type { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte object_type { get; set; }

        [Key]
        [Column(Order = 2)]
        public string physical_server_name { get; set; }

        [Key]
        [Column(Order = 3)]
        public string server_instance_name { get; set; }

        [Key]
        [Column(Order = 4)]
        public string database_name { get; set; }

        public float? percent_total_cpu_utilization { get; set; }
    }
}
