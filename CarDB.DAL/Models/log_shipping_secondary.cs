namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_shipping_secondary
    {
        [Key]
        public Guid secondary_id { get; set; }

        [Required]
        [StringLength(128)]
        public string primary_server { get; set; }

        [Required]
        [StringLength(128)]
        public string primary_database { get; set; }

        [Required]
        [StringLength(500)]
        public string backup_source_directory { get; set; }

        [Required]
        [StringLength(500)]
        public string backup_destination_directory { get; set; }

        public int file_retention_period { get; set; }

        public Guid copy_job_id { get; set; }

        public Guid restore_job_id { get; set; }

        [Required]
        [StringLength(128)]
        public string monitor_server { get; set; }

        public bool monitor_server_security_mode { get; set; }

        public bool? user_specified_monitor { get; set; }

        [StringLength(500)]
        public string last_copied_file { get; set; }

        public DateTime? last_copied_date { get; set; }
    }
}
