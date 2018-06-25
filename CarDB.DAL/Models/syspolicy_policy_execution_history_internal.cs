namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_policy_execution_history_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_policy_execution_history_internal()
        {
            syspolicy_policy_execution_history_details_internal = new HashSet<syspolicy_policy_execution_history_details_internal>();
        }

        [Key]
        public long history_id { get; set; }

        public int policy_id { get; set; }

        public DateTime start_date { get; set; }

        public DateTime? end_date { get; set; }

        public bool result { get; set; }

        public bool is_full_run { get; set; }

        public string exception_message { get; set; }

        public string exception { get; set; }

        public virtual syspolicy_policies_internal syspolicy_policies_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_policy_execution_history_details_internal> syspolicy_policy_execution_history_details_internal { get; set; }
    }
}
