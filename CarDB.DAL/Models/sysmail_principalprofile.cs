namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_principalprofile
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int profile_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [MaxLength(85)]
        public byte[] principal_sid { get; set; }

        public bool is_default { get; set; }

        public DateTime last_mod_datetime { get; set; }

        [Required]
        [StringLength(128)]
        public string last_mod_user { get; set; }

        public virtual sysmail_profile sysmail_profile { get; set; }
    }
}
