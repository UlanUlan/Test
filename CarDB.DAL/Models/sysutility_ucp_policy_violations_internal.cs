namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_policy_violations_internal
    {
        public int health_policy_id { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int policy_id { get; set; }

        [StringLength(128)]
        public string policy_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int history_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int detail_id { get; set; }

        public string target_query_expression { get; set; }

        public string target_query_expression_with_id { get; set; }

        public DateTime? execution_date { get; set; }

        public int? result { get; set; }
    }
}
