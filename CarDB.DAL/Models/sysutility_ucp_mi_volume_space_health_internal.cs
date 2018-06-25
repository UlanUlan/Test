namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_mi_volume_space_health_internal
    {
        [Required]
        [StringLength(128)]
        public string physical_server_name { get; set; }

        [Key]
        [Column(Order = 0)]
        public string server_instance_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public string volume_device_id { get; set; }

        public int health_state { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int set_number { get; set; }

        public DateTimeOffset processing_time { get; set; }
    }
}
