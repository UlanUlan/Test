namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_servertype
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysmail_servertype()
        {
            sysmail_server = new HashSet<sysmail_server>();
        }

        [Key]
        public string servertype { get; set; }

        public bool is_incoming { get; set; }

        public bool is_outgoing { get; set; }

        public DateTime last_mod_datetime { get; set; }

        [Required]
        [StringLength(128)]
        public string last_mod_user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmail_server> sysmail_server { get; set; }
    }
}
