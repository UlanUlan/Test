namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmaintplan_subplans
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysmaintplan_subplans()
        {
            sysmaintplan_log = new HashSet<sysmaintplan_log>();
        }

        [Key]
        public Guid subplan_id { get; set; }

        [Required]
        [StringLength(128)]
        public string subplan_name { get; set; }

        [StringLength(512)]
        public string subplan_description { get; set; }

        public Guid plan_id { get; set; }

        public Guid job_id { get; set; }

        public Guid? msx_job_id { get; set; }

        public int? schedule_id { get; set; }

        public bool msx_plan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmaintplan_log> sysmaintplan_log { get; set; }

        public virtual sysschedules sysschedules { get; set; }
    }
}
