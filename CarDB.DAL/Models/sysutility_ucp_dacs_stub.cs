namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_dacs_stub
    {
        [Key]
        [Column(Order = 0)]
        public int dac_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string physical_server_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string server_instance_name { get; set; }

        [Key]
        [Column(Order = 3)]
        public string dac_name { get; set; }

        public DateTime? dac_deploy_date { get; set; }

        [StringLength(4000)]
        public string dac_description { get; set; }

        [StringLength(4000)]
        public string urn { get; set; }

        [StringLength(4000)]
        public string powershell_path { get; set; }

        public DateTimeOffset? processing_time { get; set; }

        public DateTimeOffset? batch_time { get; set; }

        public float? dac_percent_total_cpu_utilization { get; set; }
    }
}
