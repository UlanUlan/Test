namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_mi_smo_properties_to_collect_internal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int object_type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(80)]
        public string property_name { get; set; }

        public virtual sysutility_mi_smo_objects_to_collect_internal sysutility_mi_smo_objects_to_collect_internal { get; set; }
    }
}
