namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_target_sets_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syspolicy_target_sets_internal()
        {
            syspolicy_target_set_levels_internal = new HashSet<syspolicy_target_set_levels_internal>();
        }

        [Key]
        public int target_set_id { get; set; }

        public int object_set_id { get; set; }

        [Required]
        [StringLength(440)]
        public string type_skeleton { get; set; }

        [Required]
        [StringLength(128)]
        public string type { get; set; }

        public bool enabled { get; set; }

        public virtual syspolicy_object_sets_internal syspolicy_object_sets_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syspolicy_target_set_levels_internal> syspolicy_target_set_levels_internal { get; set; }
    }
}
