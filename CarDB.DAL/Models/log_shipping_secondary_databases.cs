namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_shipping_secondary_databases
    {
        [Key]
        public string secondary_database { get; set; }

        public Guid secondary_id { get; set; }

        public int restore_delay { get; set; }

        public bool restore_all { get; set; }

        public bool restore_mode { get; set; }

        public bool disconnect_users { get; set; }

        public int? block_size { get; set; }

        public int? buffer_count { get; set; }

        public int? max_transfer_size { get; set; }

        [StringLength(500)]
        public string last_restored_file { get; set; }

        public DateTime? last_restored_date { get; set; }
    }
}
