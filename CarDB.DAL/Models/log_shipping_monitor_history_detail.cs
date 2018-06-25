namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_shipping_monitor_history_detail
    {
        [Key]
        [Column(Order = 0)]
        public Guid agent_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte agent_type { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int session_id { get; set; }

        [StringLength(128)]
        public string database_name { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte session_status { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime log_time { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime log_time_utc { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(4000)]
        public string message { get; set; }
    }
}
