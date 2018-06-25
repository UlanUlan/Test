namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_mi_smo_stage_internal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int object_type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4000)]
        public string urn { get; set; }

        [Key]
        [Column(Order = 2)]
        public string property_name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(128)]
        public string server_instance_name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(128)]
        public string physical_server_name { get; set; }
    }
}
