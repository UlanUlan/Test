namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_policy_execution_history_details_internal
    {
        [Key]
        [Column(Order = 0)]
        public long detail_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long history_id { get; set; }

        [Required]
        [StringLength(4000)]
        public string target_query_expression { get; set; }

        [Required]
        [StringLength(4000)]
        public string target_query_expression_with_id { get; set; }

        public DateTime execution_date { get; set; }

        public bool result { get; set; }

        public string result_detail { get; set; }

        public string exception_message { get; set; }

        public string exception { get; set; }

        public virtual syspolicy_policy_execution_history_internal syspolicy_policy_execution_history_internal { get; set; }
    }
}
