namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_mi_configuration_internal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int configuration_id { get; set; }

        [StringLength(128)]
        public string ucp_instance_name { get; set; }

        [StringLength(128)]
        public string mdw_database_name { get; set; }
    }
}
