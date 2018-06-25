namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysdownloadlist")]
    public partial class sysdownloadlist
    {
        [Key]
        [Column(Order = 0)]
        public int instance_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string source_server { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte operation_code { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte object_type { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid object_id { get; set; }

        [Key]
        [Column(Order = 5)]
        public string target_server { get; set; }

        [StringLength(1024)]
        public string error_message { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime date_posted { get; set; }

        public DateTime? date_downloaded { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte status { get; set; }

        [StringLength(128)]
        public string deleted_object_name { get; set; }
    }
}
