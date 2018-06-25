namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysdbmaintplan_history
    {
        [Key]
        [Column(Order = 0)]
        public int sequence_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid plan_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public string plan_name { get; set; }

        [StringLength(128)]
        public string database_name { get; set; }

        [Key]
        [Column(Order = 3)]
        public string server_name { get; set; }

        [StringLength(128)]
        public string activity { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool succeeded { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime end_time { get; set; }

        public int? duration { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? start_time { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int error_number { get; set; }

        [StringLength(512)]
        public string message { get; set; }
    }
}
