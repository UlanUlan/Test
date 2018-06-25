namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_filegroups_with_policy_violations_internal
    {
        [Key]
        [Column(Order = 0)]
        public string server_instance_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public string database_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string filegroup_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int policy_id { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int set_number { get; set; }
    }
}
