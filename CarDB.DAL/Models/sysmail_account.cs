namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysmail_account()
        {
            sysmail_profileaccount = new HashSet<sysmail_profileaccount>();
            sysmail_server = new HashSet<sysmail_server>();
        }

        [Key]
        public int account_id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [StringLength(256)]
        public string description { get; set; }

        [Required]
        [StringLength(128)]
        public string email_address { get; set; }

        [StringLength(128)]
        public string display_name { get; set; }

        [StringLength(128)]
        public string replyto_address { get; set; }

        public DateTime last_mod_datetime { get; set; }

        [Required]
        [StringLength(128)]
        public string last_mod_user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmail_profileaccount> sysmail_profileaccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmail_server> sysmail_server { get; set; }
    }
}
