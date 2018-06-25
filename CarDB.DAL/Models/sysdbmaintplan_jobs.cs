namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysdbmaintplan_jobs
    {
        [Key]
        [Column(Order = 0)]
        public Guid plan_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid job_id { get; set; }

        public virtual sysdbmaintplans sysdbmaintplans { get; set; }
    }
}
