namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_volumes_stub
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string virtual_server_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string physical_server_name { get; set; }

        [Key]
        [Column(Order = 3)]
        public string volume_device_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public string volume_name { get; set; }

        public float? total_space_available { get; set; }

        public float? free_space { get; set; }

        public float? total_space_utilized { get; set; }

        public float? percent_total_space_utilization { get; set; }

        public DateTimeOffset? processing_time { get; set; }

        public DateTimeOffset? batch_time { get; set; }

        [StringLength(4000)]
        public string powershell_path { get; set; }
    }
}
