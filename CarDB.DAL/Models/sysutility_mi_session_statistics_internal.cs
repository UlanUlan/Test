namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_mi_session_statistics_internal
    {
        [Key]
        [Column(Order = 0)]
        public DateTimeOffset collection_time { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int session_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public string dac_instance_name { get; set; }

        [Key]
        [Column(Order = 3)]
        public string database_name { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime login_time { get; set; }

        public int cumulative_cpu_ms { get; set; }
    }
}
