namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_supported_object_types_internal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int object_type { get; set; }

        [StringLength(32)]
        public string object_name { get; set; }
    }
}
