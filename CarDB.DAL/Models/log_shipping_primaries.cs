namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_shipping_primaries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public log_shipping_primaries()
        {
            log_shipping_secondaries = new HashSet<log_shipping_secondaries>();
        }

        [Key]
        public int primary_id { get; set; }

        [Required]
        [StringLength(128)]
        public string primary_server_name { get; set; }

        [Required]
        [StringLength(128)]
        public string primary_database_name { get; set; }

        public Guid? maintenance_plan_id { get; set; }

        public int backup_threshold { get; set; }

        public int threshold_alert { get; set; }

        public bool threshold_alert_enabled { get; set; }

        [StringLength(500)]
        public string last_backup_filename { get; set; }

        public DateTime? last_updated { get; set; }

        public int planned_outage_start_time { get; set; }

        public int planned_outage_end_time { get; set; }

        public int planned_outage_weekday_mask { get; set; }

        [StringLength(500)]
        public string source_directory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<log_shipping_secondaries> log_shipping_secondaries { get; set; }
    }
}
