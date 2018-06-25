namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_object_sets_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_object_sets_internal()
        {
            syspolicy_policies_internal = new HashSet<syspolicy_policies_internal>();
            syspolicy_target_sets_internal = new HashSet<syspolicy_target_sets_internal>();
        }

        [Key]
        public int object_set_id { get; set; }

        [Required]
        [StringLength(128)]
        public string object_set_name { get; set; }

        public int? facet_id { get; set; }

        public bool is_system { get; set; }

        public virtual syspolicy_management_facets syspolicy_management_facets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_policies_internal> syspolicy_policies_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_target_sets_internal> syspolicy_target_sets_internal { get; set; }
    }
}
