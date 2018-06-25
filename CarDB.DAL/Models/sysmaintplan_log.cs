namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmaintplan_log
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysmaintplan_log()
        {
            sysmaintplan_logdetail = new HashSet<sysmaintplan_logdetail>();
        }

        [Key]
        public Guid task_detail_id { get; set; }

        public Guid? plan_id { get; set; }

        public Guid? subplan_id { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? end_time { get; set; }

        public bool? succeeded { get; set; }

        public bool logged_remotely { get; set; }

        [StringLength(128)]
        public string source_server_name { get; set; }

        [StringLength(128)]
        public string plan_name { get; set; }

        [StringLength(128)]
        public string subplan_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmaintplan_logdetail> sysmaintplan_logdetail { get; set; }

        public virtual sysmaintplan_subplans sysmaintplan_subplans { get; set; }
    }
}
