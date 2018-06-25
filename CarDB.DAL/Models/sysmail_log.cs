namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_log
    {
        [Key]
        public int log_id { get; set; }

        public int event_type { get; set; }

        public DateTime log_date { get; set; }

        public string description { get; set; }

        public int? process_id { get; set; }

        public int? mailitem_id { get; set; }

        public int? account_id { get; set; }

        public DateTime last_mod_date { get; set; }

        [Required]
        [StringLength(128)]
        public string last_mod_user { get; set; }
    }
}
