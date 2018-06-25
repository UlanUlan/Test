namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_mi_cpu_stage_internal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int num_processors { get; set; }

        [Key]
        [Column(Order = 1)]
        public string cpu_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string cpu_caption { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal cpu_family_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal cpu_architecture_id { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal cpu_max_clock_speed { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal cpu_clock_speed { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal l2_cache_size { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal l3_cache_size { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal instance_processor_usage_start_ticks { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal instance_collect_time_start_ticks { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal computer_processor_idle_start_ticks { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal computer_collect_time_start_ticks { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal instance_processor_usage_end_ticks { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal instance_collect_time_end_ticks { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal computer_processor_idle_end_ticks { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal computer_collect_time_end_ticks { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(128)]
        public string server_instance_name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(128)]
        public string virtual_server_name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(128)]
        public string physical_server_name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public float? instance_processor_usage_percentage { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public float? computer_processor_usage_percentage { get; set; }
    }
}
