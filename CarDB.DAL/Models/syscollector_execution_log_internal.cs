namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syscollector_execution_log_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syscollector_execution_log_internal()
        {
            syscollector_execution_stats_internal = new HashSet<syscollector_execution_stats_internal>();
        }

        [Key]
        public long log_id { get; set; }

        public long? parent_log_id { get; set; }

        public int collection_set_id { get; set; }

        public int? collection_item_id { get; set; }

        public DateTime start_time { get; set; }

        public DateTime? last_iteration_time { get; set; }

        public DateTime? finish_time { get; set; }

        public short? runtime_execution_mode { get; set; }

        public short status { get; set; }

        [Column("operator")]
        [Required]
        [StringLength(128)]
        public string _operator { get; set; }

        public Guid? package_id { get; set; }

        public Guid? package_execution_id { get; set; }

        [StringLength(2048)]
        public string failure_message { get; set; }

        public virtual syscollector_collection_sets_internal syscollector_collection_sets_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syscollector_execution_stats_internal> syscollector_execution_stats_internal { get; set; }
    }
}
