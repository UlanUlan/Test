namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_shipping_monitor_primary
    {
        [Key]
        public Guid primary_id { get; set; }

        [Required]
        [StringLength(128)]
        public string primary_server { get; set; }

        [Required]
        [StringLength(128)]
        public string primary_database { get; set; }

        public int backup_threshold { get; set; }

        public int threshold_alert { get; set; }

        public bool threshold_alert_enabled { get; set; }

        [StringLength(500)]
        public string last_backup_file { get; set; }

        public DateTime? last_backup_date { get; set; }

        public DateTime? last_backup_date_utc { get; set; }

        public int history_retention_period { get; set; }
    }
}
