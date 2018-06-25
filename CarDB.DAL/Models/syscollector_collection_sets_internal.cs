namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syscollector_collection_sets_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syscollector_collection_sets_internal()
        {
            syscollector_collection_items_internal = new HashSet<syscollector_collection_items_internal>();
            syscollector_execution_log_internal = new HashSet<syscollector_execution_log_internal>();
        }

        [Key]
        public int collection_set_id { get; set; }

        public Guid collection_set_uid { get; set; }

        public Guid? schedule_uid { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public int? name_id { get; set; }

        public string target { get; set; }

        public bool is_running { get; set; }

        public int? proxy_id { get; set; }

        public bool is_system { get; set; }

        public Guid? collection_job_id { get; set; }

        public Guid? upload_job_id { get; set; }

        public short collection_mode { get; set; }

        public short logging_level { get; set; }

        [StringLength(4000)]
        public string description { get; set; }

        public int? description_id { get; set; }

        public short days_until_expiration { get; set; }

        public bool dump_on_any_error { get; set; }

        public string dump_on_codes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syscollector_collection_items_internal> syscollector_collection_items_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syscollector_execution_log_internal> syscollector_execution_log_internal { get; set; }
    }
}
