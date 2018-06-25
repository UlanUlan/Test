namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_mi_dac_execution_statistics_internal
    {
        [Key]
        public string dac_instance_name { get; set; }

        [Required]
        [StringLength(128)]
        public string database_name { get; set; }

        public int database_id { get; set; }

        public DateTime? date_created { get; set; }

        [StringLength(4000)]
        public string description { get; set; }

        public DateTimeOffset? first_collection_time { get; set; }

        public DateTimeOffset? last_collection_time { get; set; }

        public DateTimeOffset? last_upload_time { get; set; }

        public long? lifetime_cpu_time_ms { get; set; }

        public long? cpu_time_ms_at_last_upload { get; set; }
    }
}
