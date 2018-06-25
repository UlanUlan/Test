namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysschedules
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysschedules()
        {
            sysmaintplan_subplans = new HashSet<sysmaintplan_subplans>();
            sysjobschedules = new HashSet<sysjobschedules>();
        }

        [Key]
        public int schedule_id { get; set; }

        public Guid schedule_uid { get; set; }

        public int originating_server_id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [Required]
        [MaxLength(85)]
        public byte[] owner_sid { get; set; }

        public int enabled { get; set; }

        public int freq_type { get; set; }

        public int freq_interval { get; set; }

        public int freq_subday_type { get; set; }

        public int freq_subday_interval { get; set; }

        public int freq_relative_interval { get; set; }

        public int freq_recurrence_factor { get; set; }

        public int active_start_date { get; set; }

        public int active_end_date { get; set; }

        public int active_start_time { get; set; }

        public int active_end_time { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_modified { get; set; }

        public int version_number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmaintplan_subplans> sysmaintplan_subplans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysjobschedules> sysjobschedules { get; set; }
    }
}
