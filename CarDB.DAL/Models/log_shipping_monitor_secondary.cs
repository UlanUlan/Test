namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_shipping_monitor_secondary
    {
        [Required]
        [StringLength(128)]
        public string secondary_server { get; set; }

        [Key]
        [Column(Order = 0)]
        public string secondary_database { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid secondary_id { get; set; }

        [Required]
        [StringLength(128)]
        public string primary_server { get; set; }

        [Required]
        [StringLength(128)]
        public string primary_database { get; set; }

        public int restore_threshold { get; set; }

        public int threshold_alert { get; set; }

        public bool threshold_alert_enabled { get; set; }

        [StringLength(500)]
        public string last_copied_file { get; set; }

        public DateTime? last_copied_date { get; set; }

        public DateTime? last_copied_date_utc { get; set; }

        [StringLength(500)]
        public string last_restored_file { get; set; }

        public DateTime? last_restored_date { get; set; }

        public DateTime? last_restored_date_utc { get; set; }

        public int? last_restored_latency { get; set; }

        public int history_retention_period { get; set; }
    }
}
