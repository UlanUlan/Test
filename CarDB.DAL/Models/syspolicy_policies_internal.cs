namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_policies_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_policies_internal()
        {
            syspolicy_system_health_state_internal = new HashSet<syspolicy_system_health_state_internal>();
            syspolicy_policy_execution_history_internal = new HashSet<syspolicy_policy_execution_history_internal>();
        }

        [Key]
        public int policy_id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public int condition_id { get; set; }

        public int? root_condition_id { get; set; }

        public DateTime date_created { get; set; }

        public int execution_mode { get; set; }

        public int? policy_category_id { get; set; }

        public Guid? schedule_uid { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        [StringLength(4000)]
        public string help_text { get; set; }

        [Required]
        [StringLength(2083)]
        public string help_link { get; set; }

        public int? object_set_id { get; set; }

        public bool is_enabled { get; set; }

        public Guid? job_id { get; set; }

        [Required]
        [StringLength(128)]
        public string created_by { get; set; }

        [StringLength(128)]
        public string modified_by { get; set; }

        public DateTime? date_modified { get; set; }

        public bool is_system { get; set; }

        public virtual syspolicy_conditions_internal syspolicy_conditions_internal { get; set; }

        public virtual syspolicy_conditions_internal syspolicy_conditions_internal1 { get; set; }

        public virtual syspolicy_object_sets_internal syspolicy_object_sets_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_system_health_state_internal> syspolicy_system_health_state_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_policy_execution_history_internal> syspolicy_policy_execution_history_internal { get; set; }

        public virtual syspolicy_policy_categories_internal syspolicy_policy_categories_internal { get; set; }
    }
}
