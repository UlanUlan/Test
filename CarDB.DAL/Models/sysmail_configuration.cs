namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_configuration
    {
        [Key]
        [StringLength(256)]
        public string paramname { get; set; }

        [StringLength(256)]
        public string paramvalue { get; set; }

        [StringLength(256)]
        public string description { get; set; }

        public DateTime last_mod_datetime { get; set; }

        [Required]
        [StringLength(128)]
        public string last_mod_user { get; set; }
    }
}
