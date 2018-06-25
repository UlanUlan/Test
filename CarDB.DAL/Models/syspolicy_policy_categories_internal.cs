namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_policy_categories_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_policy_categories_internal()
        {
            syspolicy_policies_internal = new HashSet<syspolicy_policies_internal>();
            syspolicy_policy_category_subscriptions_internal = new HashSet<syspolicy_policy_category_subscriptions_internal>();
        }

        [Key]
        public int policy_category_id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public bool mandate_database_subscriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_policies_internal> syspolicy_policies_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_policy_category_subscriptions_internal> syspolicy_policy_category_subscriptions_internal { get; set; }
    }
}
