namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syscollector_execution_stats_internal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long log_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string task_name { get; set; }

        public int? execution_row_count_in { get; set; }

        public int? execution_row_count_out { get; set; }

        public int? execution_row_count_errors { get; set; }

        public int? execution_time_ms { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime log_time { get; set; }

        public virtual syscollector_execution_log_internal syscollector_execution_log_internal { get; set; }
    }
}
