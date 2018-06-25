namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_filegroups_stub
    {
        [StringLength(780)]
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

        [StringLength(512)]
        public string parent_urn { get; set; }

        [StringLength(128)]
        public string Name { get; set; }
    }
}
