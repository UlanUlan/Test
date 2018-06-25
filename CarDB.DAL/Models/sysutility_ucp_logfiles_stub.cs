namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_logfiles_stub
    {
        [StringLength(1500)]
        public string urn { get; set; }

        public string powershell_path { get; set; }

        public DateTimeOffset? processing_time { get; set; }

        public DateTimeOffset? batch_time { get; set; }

        [Key]
        [Column(Order = 0)]
        public string server_instance_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public string database_name { get; set; }

        [StringLength(780)]
        public string parent_urn { get; set; }

        [Key]
        [Column(Order = 2)]
        public string physical_server_name { get; set; }

        [Key]
        [Column(Order = 3)]
        public string volume_name { get; set; }

        [Key]
        [Column(Order = 4)]
        public string volume_device_id { get; set; }

        public float? Growth { get; set; }

        public short? GrowthType { get; set; }

        public float? MaxSize { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        public float? Size { get; set; }

        public float? UsedSpace { get; set; }

        [StringLength(260)]
        public string FileName { get; set; }

        public long? VolumeFreeSpace { get; set; }

        public float? available_space { get; set; }
    }
}
