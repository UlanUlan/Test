namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_shipping_primary_databases
    {
        [Key]
        public Guid primary_id { get; set; }

        [Required]
        [StringLength(128)]
        public string primary_database { get; set; }

        [Required]
        [StringLength(500)]
        public string backup_directory { get; set; }

        [Required]
        [StringLength(500)]
        public string backup_share { get; set; }

        public int backup_retention_period { get; set; }

        public Guid backup_job_id { get; set; }

        [Required]
        [StringLength(128)]
        public string monitor_server { get; set; }

        public bool? user_specified_monitor { get; set; }

        public bool monitor_server_security_mode { get; set; }

        [StringLength(500)]
        public string last_backup_file { get; set; }

        public DateTime? last_backup_date { get; set; }

        public byte backup_compression { get; set; }
    }
}
