namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_computer_cpu_health_internal
    {
        [Key]
        [Column(Order = 0)]
        public string physical_server_name { get; set; }

        public int health_state { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int set_number { get; set; }

        public DateTimeOffset processing_time { get; set; }
    }
}
