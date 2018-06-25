namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syssubsystems
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int subsystem_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string subsystem { get; set; }

        public int? description_id { get; set; }

        [StringLength(255)]
        public string subsystem_dll { get; set; }

        [StringLength(255)]
        public string agent_exe { get; set; }

        [StringLength(30)]
        public string start_entry_point { get; set; }

        [StringLength(30)]
        public string event_entry_point { get; set; }

        [StringLength(30)]
        public string stop_entry_point { get; set; }

        public int? max_worker_threads { get; set; }
    }
}
