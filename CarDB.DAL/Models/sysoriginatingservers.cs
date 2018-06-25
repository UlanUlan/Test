namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysoriginatingservers
    {
        public int? originating_server_id { get; set; }

        [Key]
        public string originating_server { get; set; }

        public bool? master_server { get; set; }
    }
}
