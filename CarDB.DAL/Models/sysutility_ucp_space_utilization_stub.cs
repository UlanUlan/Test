namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_space_utilization_stub
    {
        [Key]
        [Column(Order = 0)]
        public DateTimeOffset processing_time { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte aggregation_type { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte object_type { get; set; }

        [Key]
        [Column(Order = 3)]
        public string virtual_server_name { get; set; }

        [Key]
        [Column(Order = 4)]
        public string server_instance_name { get; set; }

        [Key]
        [Column(Order = 5)]
        public string volume_device_id { get; set; }

        [Key]
        [Column(Order = 6)]
        public string database_name { get; set; }

        [Key]
        [Column(Order = 7)]
        public string filegroup_name { get; set; }

        [Key]
        [Column(Order = 8)]
        public string dbfile_name { get; set; }

        public float? used_space_bytes { get; set; }

        public float? allocated_space_bytes { get; set; }

        public float? total_space_bytes { get; set; }

        public float? available_space_bytes { get; set; }
    }
}
