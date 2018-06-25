namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_databases_stub
    {
        [StringLength(512)]
        public string urn { get; set; }

        public string powershell_path { get; set; }

        public DateTimeOffset? processing_time { get; set; }

        public DateTimeOffset? batch_time { get; set; }

        [Key]
        public string server_instance_name { get; set; }

        [StringLength(320)]
        public string parent_urn { get; set; }

        [StringLength(128)]
        public string Collation { get; set; }

        public short? CompatibilityLevel { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? EncryptionEnabled { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        public short? RecoveryModel { get; set; }

        public bool? Trustworthy { get; set; }

        public byte? state { get; set; }
    }
}
