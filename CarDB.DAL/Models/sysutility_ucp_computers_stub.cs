namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_computers_stub
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string virtual_server_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string physical_server_name { get; set; }

        public int? is_clustered_server { get; set; }

        public int? num_processors { get; set; }

        [StringLength(128)]
        public string cpu_name { get; set; }

        [StringLength(128)]
        public string cpu_caption { get; set; }

        [StringLength(128)]
        public string cpu_family { get; set; }

        [StringLength(64)]
        public string cpu_architecture { get; set; }

        public decimal? cpu_max_clock_speed { get; set; }

        public decimal? cpu_clock_speed { get; set; }

        public decimal? l2_cache_size { get; set; }

        public decimal? l3_cache_size { get; set; }

        [StringLength(4000)]
        public string urn { get; set; }

        [StringLength(4000)]
        public string powershell_path { get; set; }

        public DateTimeOffset? processing_time { get; set; }

        public DateTimeOffset? batch_time { get; set; }

        public float? percent_total_cpu_utilization { get; set; }
    }
}
