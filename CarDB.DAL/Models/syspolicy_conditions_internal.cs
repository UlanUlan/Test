namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_conditions_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_conditions_internal()
        {
            syspolicy_target_set_levels_internal = new HashSet<syspolicy_target_set_levels_internal>();
            syspolicy_policies_internal = new HashSet<syspolicy_policies_internal>();
            syspolicy_policies_internal1 = new HashSet<syspolicy_policies_internal>();
        }

        [Key]
        public int condition_id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public DateTime? date_created { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        [StringLength(128)]
        public string created_by { get; set; }

        [StringLength(128)]
        public string modified_by { get; set; }

        public DateTime? date_modified { get; set; }

        public int? facet_id { get; set; }

        public string expression { get; set; }

        public short? is_name_condition { get; set; }

        [StringLength(128)]
        public string obj_name { get; set; }

        public bool is_system { get; set; }

        public virtual syspolicy_management_facets syspolicy_management_facets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_target_set_levels_internal> syspolicy_target_set_levels_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_policies_internal> syspolicy_policies_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_policies_internal> syspolicy_policies_internal1 { get; set; }
    }
}
