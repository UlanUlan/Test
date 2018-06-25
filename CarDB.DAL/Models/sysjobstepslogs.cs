namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysjobstepslogs
    {
        [Key]
        public int log_id { get; set; }

        [Required]
        public string log { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_modified { get; set; }

        public long log_size { get; set; }

        public Guid step_uid { get; set; }
    }
}
