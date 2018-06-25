namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_target_set_levels_internal
    {
        [Key]
        public int target_set_level_id { get; set; }

        public int target_set_id { get; set; }

        [Required]
        [StringLength(440)]
        public string type_skeleton { get; set; }

        public int? condition_id { get; set; }

        [Required]
        [StringLength(128)]
        public string level_name { get; set; }

        public virtual syspolicy_conditions_internal syspolicy_conditions_internal { get; set; }

        public virtual syspolicy_target_sets_internal syspolicy_target_sets_internal { get; set; }
    }
}
