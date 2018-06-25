namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("backupfile")]
    public partial class backupfile
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int backup_set_id { get; set; }

        public byte? first_family_number { get; set; }

        public short? first_media_number { get; set; }

        [StringLength(128)]
        public string filegroup_name { get; set; }

        public int? page_size { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal file_number { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? backed_up_page_count { get; set; }

        [StringLength(1)]
        public string file_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? source_file_block_size { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? file_size { get; set; }

        [StringLength(128)]
        public string logical_name { get; set; }

        [StringLength(260)]
        public string physical_drive { get; set; }

        [StringLength(260)]
        public string physical_name { get; set; }

        public byte? state { get; set; }

        [StringLength(64)]
        public string state_desc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? create_lsn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? drop_lsn { get; set; }

        public Guid? file_guid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? read_only_lsn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? read_write_lsn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? differential_base_lsn { get; set; }

        public Guid? differential_base_guid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? backup_size { get; set; }

        public Guid? filegroup_guid { get; set; }

        public bool? is_readonly { get; set; }

        public bool? is_present { get; set; }

        public virtual backupset backupset { get; set; }
    }
}
