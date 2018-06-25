namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysmail_profile()
        {
            sysmail_principalprofile = new HashSet<sysmail_principalprofile>();
        }

        [Key]
        public int profile_id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [StringLength(256)]
        public string description { get; set; }

        public DateTime last_mod_datetime { get; set; }

        [Required]
        [StringLength(128)]
        public string last_mod_user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmail_principalprofile> sysmail_principalprofile { get; set; }
    }
}
