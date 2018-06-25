namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_system_health_state_internal
    {
        [Key]
        public long health_state_id { get; set; }

        public int policy_id { get; set; }

        public DateTime last_run_date { get; set; }

        [Required]
        [StringLength(400)]
        public string target_query_expression_with_id { get; set; }

        [Required]
        public string target_query_expression { get; set; }

        public bool result { get; set; }

        public virtual syspolicy_policies_internal syspolicy_policies_internal { get; set; }
    }
}
