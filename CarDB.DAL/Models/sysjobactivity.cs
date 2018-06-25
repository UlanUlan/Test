namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysjobactivity")]
    public partial class sysjobactivity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int session_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid job_id { get; set; }

        public DateTime? run_requested_date { get; set; }

        [StringLength(128)]
        public string run_requested_source { get; set; }

        public DateTime? queued_date { get; set; }

        public DateTime? start_execution_date { get; set; }

        public int? last_executed_step_id { get; set; }

        public DateTime? last_executed_step_date { get; set; }

        public DateTime? stop_execution_date { get; set; }

        public int? job_history_id { get; set; }

        public DateTime? next_scheduled_run_date { get; set; }

        public virtual syssessions syssessions { get; set; }
    }
}
