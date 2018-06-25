namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_policy_category_subscriptions_internal
    {
        [Key]
        public int policy_category_subscription_id { get; set; }

        [Required]
        [StringLength(128)]
        public string target_type { get; set; }

        [Required]
        [StringLength(128)]
        public string target_object { get; set; }

        public int policy_category_id { get; set; }

        public virtual syspolicy_policy_categories_internal syspolicy_policy_categories_internal { get; set; }
    }
}
