namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_mi_volumes_stage_internal
    {
        [Key]
        [Column(Order = 0)]
        public string volume_device_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(260)]
        public string volume_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal capacity_mb { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal free_space_mb { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(128)]
        public string server_instance_name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(128)]
        public string virtual_server_name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(128)]
        public string physical_server_name { get; set; }
    }
}
