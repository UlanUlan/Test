namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysdbmaintplan_databases
    {
        [Key]
        [Column(Order = 0)]
        public Guid plan_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string database_name { get; set; }

        public virtual sysdbmaintplans sysdbmaintplans { get; set; }
    }
}
