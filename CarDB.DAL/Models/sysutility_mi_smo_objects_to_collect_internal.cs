namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_mi_smo_objects_to_collect_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysutility_mi_smo_objects_to_collect_internal()
        {
            sysutility_mi_smo_properties_to_collect_internal = new HashSet<sysutility_mi_smo_properties_to_collect_internal>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int object_type { get; set; }

        [Required]
        public string sfc_query { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysutility_mi_smo_properties_to_collect_internal> sysutility_mi_smo_properties_to_collect_internal { get; set; }
    }
}
