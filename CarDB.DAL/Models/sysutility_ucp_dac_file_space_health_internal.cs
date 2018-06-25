namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_dac_file_space_health_internal
    {
        [Key]
        [Column(Order = 0)]
        public string dac_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public string dac_server_instance_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string fg_name { get; set; }

        public int over_utilized_count { get; set; }

        public int under_utilized_count { get; set; }

        public int file_type { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int set_number { get; set; }

        public DateTimeOffset processing_time { get; set; }
    }
}
