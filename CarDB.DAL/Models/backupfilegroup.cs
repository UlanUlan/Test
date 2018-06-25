namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("backupfilegroup")]
    public partial class backupfilegroup
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int backup_set_id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int filegroup_id { get; set; }

        public Guid? filegroup_guid { get; set; }

        [Required]
        [StringLength(2)]
        public string type { get; set; }

        [Required]
        [StringLength(60)]
        public string type_desc { get; set; }

        public bool is_default { get; set; }

        public bool is_readonly { get; set; }

        public Guid? log_filegroup_guid { get; set; }

        public virtual backupset backupset { get; set; }
    }
}
