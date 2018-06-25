namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_dac_health_internal
    {
        [Key]
        [Column(Order = 0)]
        public string dac_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public string dac_server_instance_name { get; set; }

        public int is_volume_space_over_utilized { get; set; }

        public int is_volume_space_under_utilized { get; set; }

        public int is_computer_processor_over_utilized { get; set; }

        public int is_computer_processor_under_utilized { get; set; }

        public int is_file_space_over_utilized { get; set; }

        public int is_file_space_under_utilized { get; set; }

        public int is_dac_processor_over_utilized { get; set; }

        public int is_dac_processor_under_utilized { get; set; }

        public bool is_policy_overridden { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int set_number { get; set; }

        public DateTimeOffset processing_time { get; set; }
    }
}
