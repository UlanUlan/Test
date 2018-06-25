namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_server
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int account_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string servertype { get; set; }

        [Required]
        [StringLength(128)]
        public string servername { get; set; }

        public int port { get; set; }

        [StringLength(128)]
        public string username { get; set; }

        public int? credential_id { get; set; }

        public bool use_default_credentials { get; set; }

        public bool enable_ssl { get; set; }

        public int flags { get; set; }

        public int? timeout { get; set; }

        public DateTime last_mod_datetime { get; set; }

        [Required]
        [StringLength(128)]
        public string last_mod_user { get; set; }

        public virtual sysmail_account sysmail_account { get; set; }

        public virtual sysmail_servertype sysmail_servertype { get; set; }
    }
}
