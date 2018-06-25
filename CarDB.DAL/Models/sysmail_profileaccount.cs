namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_profileaccount
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int profile_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int account_id { get; set; }

        public int? sequence_number { get; set; }

        public DateTime last_mod_datetime { get; set; }

        [Required]
        [StringLength(128)]
        public string last_mod_user { get; set; }

        public virtual sysmail_account sysmail_account { get; set; }
    }
}
