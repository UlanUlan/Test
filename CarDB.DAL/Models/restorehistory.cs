namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("restorehistory")]
    public partial class restorehistory
    {
        [Key]
        public int restore_history_id { get; set; }

        public DateTime? restore_date { get; set; }

        [StringLength(128)]
        public string destination_database_name { get; set; }

        [StringLength(128)]
        public string user_name { get; set; }

        public int backup_set_id { get; set; }

        [StringLength(1)]
        public string restore_type { get; set; }

        public bool? replace { get; set; }

        public bool? recovery { get; set; }

        public bool? restart { get; set; }

        public DateTime? stop_at { get; set; }

        public byte? device_count { get; set; }

        [StringLength(128)]
        public string stop_at_mark_name { get; set; }

        public bool? stop_before { get; set; }

        public virtual backupset backupset { get; set; }

        public virtual restorefile restorefile { get; set; }

        public virtual restorefilegroup restorefilegroup { get; set; }
    }
}
