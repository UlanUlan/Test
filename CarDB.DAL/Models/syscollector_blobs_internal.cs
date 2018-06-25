namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syscollector_blobs_internal
    {
        [Key]
        public string parameter_name { get; set; }

        [Required]
        public byte[] parameter_value { get; set; }
    }
}
