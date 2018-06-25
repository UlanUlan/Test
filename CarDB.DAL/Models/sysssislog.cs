namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysssislog")]
    public partial class sysssislog
    {
        public int id { get; set; }

        [Column("event")]
        [Required]
        [StringLength(128)]
        public string _event { get; set; }

        [Required]
        [StringLength(128)]
        public string computer { get; set; }

        [Column("operator")]
        [Required]
        [StringLength(128)]
        public string _operator { get; set; }

        [Required]
        [StringLength(1024)]
        public string source { get; set; }

        public Guid sourceid { get; set; }

        public Guid executionid { get; set; }

        public DateTime starttime { get; set; }

        public DateTime endtime { get; set; }

        public int datacode { get; set; }

        [Column(TypeName = "image")]
        public byte[] databytes { get; set; }

        [Required]
        [StringLength(2048)]
        public string message { get; set; }
    }
}
