namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmaintplan_logdetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid task_detail_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string line1 { get; set; }

        [StringLength(256)]
        public string line2 { get; set; }

        [StringLength(256)]
        public string line3 { get; set; }

        [StringLength(256)]
        public string line4 { get; set; }

        [StringLength(256)]
        public string line5 { get; set; }

        [Key]
        [Column(Order = 2)]
        public string server_name { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? end_time { get; set; }

        public int? error_number { get; set; }

        public string error_message { get; set; }

        public string command { get; set; }

        public bool? succeeded { get; set; }

        public virtual sysmaintplan_log sysmaintplan_log { get; set; }
    }
}
