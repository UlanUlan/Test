namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_health_policies_internal
    {
        [Key]
        public int health_policy_id { get; set; }

        [Required]
        [StringLength(128)]
        public string policy_name { get; set; }

        [Required]
        [StringLength(4000)]
        public string rollup_object_urn { get; set; }

        public int rollup_object_type { get; set; }

        public int target_type { get; set; }

        public int resource_type { get; set; }

        public int utilization_type { get; set; }

        public double utilization_threshold { get; set; }

        public bool? is_global_policy { get; set; }
    }
}
