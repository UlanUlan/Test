namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysdbmaintplans
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysdbmaintplans()
        {
            sysdbmaintplan_jobs = new HashSet<sysdbmaintplan_jobs>();
            sysdbmaintplan_databases = new HashSet<sysdbmaintplan_databases>();
        }

        [Key]
        public Guid plan_id { get; set; }

        [Required]
        [StringLength(128)]
        public string plan_name { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(128)]
        public string owner { get; set; }

        public int max_history_rows { get; set; }

        [Required]
        [StringLength(128)]
        public string remote_history_server { get; set; }

        public int max_remote_history_rows { get; set; }

        public int? user_defined_1 { get; set; }

        [StringLength(100)]
        public string user_defined_2 { get; set; }

        public DateTime? user_defined_3 { get; set; }

        public Guid? user_defined_4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysdbmaintplan_jobs> sysdbmaintplan_jobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysdbmaintplan_databases> sysdbmaintplan_databases { get; set; }
    }
}
