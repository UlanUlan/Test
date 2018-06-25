namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syscachedcredentials
    {
        [Key]
        public string login_name { get; set; }

        public bool has_server_access { get; set; }

        public bool is_sysadmin_member { get; set; }

        public DateTime cachedate { get; set; }
    }
}
