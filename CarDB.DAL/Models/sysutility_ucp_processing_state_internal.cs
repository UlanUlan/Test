namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysutility_ucp_processing_state_internal
    {
        public DateTimeOffset? latest_processing_time { get; set; }

        public int? latest_health_state_id { get; set; }

        public int? next_health_state_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int id { get; set; }
    }
}
