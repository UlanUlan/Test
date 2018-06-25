namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmanagement_shared_server_groups_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysmanagement_shared_server_groups_internal()
        {
            sysmanagement_shared_registered_servers_internal = new HashSet<sysmanagement_shared_registered_servers_internal>();
        }

        [Key]
        public int server_group_id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [Required]
        [StringLength(2048)]
        public string description { get; set; }

        public int server_type { get; set; }

        public int? parent_id { get; set; }

        public bool? is_system_object { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmanagement_shared_registered_servers_internal> sysmanagement_shared_registered_servers_internal { get; set; }
    }
}
