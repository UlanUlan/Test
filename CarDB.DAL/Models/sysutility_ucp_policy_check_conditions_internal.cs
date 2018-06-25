namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_policy_check_conditions_internal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int target_type { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int resource_type { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int utilization_type { get; set; }

        [Key]
        [Column(Order = 3)]
        public string facet_name { get; set; }

        [Key]
        [Column(Order = 4)]
        public string attribute_name { get; set; }

        public int operator_type { get; set; }

        [Required]
        [StringLength(128)]
        public string property_name { get; set; }
    }
}
