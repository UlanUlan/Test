namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("backupmediafamily")]
    public partial class backupmediafamily
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int media_set_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte family_sequence_number { get; set; }

        public Guid? media_family_id { get; set; }

        public int? media_count { get; set; }

        [StringLength(128)]
        public string logical_device_name { get; set; }

        [StringLength(260)]
        public string physical_device_name { get; set; }

        public byte? device_type { get; set; }

        public int? physical_block_size { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte mirror { get; set; }

        public virtual backupmediaset backupmediaset { get; set; }
    }
}
