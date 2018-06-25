namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_managed_instances_internal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instance_id { get; set; }

        [Key]
        public string instance_name { get; set; }

        [Required]
        [StringLength(128)]
        public string virtual_server_name { get; set; }

        public DateTimeOffset date_created { get; set; }

        [Required]
        [StringLength(128)]
        public string created_by { get; set; }

        [Required]
        [StringLength(128)]
        public string agent_proxy_account { get; set; }

        [StringLength(520)]
        public string cache_directory { get; set; }

        public int management_state { get; set; }
    }
}
