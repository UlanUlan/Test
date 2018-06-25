namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_management_facets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_management_facets()
        {
            syspolicy_conditions_internal = new HashSet<syspolicy_conditions_internal>();
            syspolicy_facet_events = new HashSet<syspolicy_facet_events>();
            syspolicy_object_sets_internal = new HashSet<syspolicy_object_sets_internal>();
        }

        [Key]
        public int management_facet_id { get; set; }

        [Required]
        public string name { get; set; }

        public int execution_mode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_conditions_internal> syspolicy_conditions_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_facet_events> syspolicy_facet_events { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_object_sets_internal> syspolicy_object_sets_internal { get; set; }
    }
}
