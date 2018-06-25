namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("backupset")]
    public partial class backupset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public backupset()
        {
            backupfile = new HashSet<backupfile>();
            backupfilegroup = new HashSet<backupfilegroup>();
            restorehistory = new HashSet<restorehistory>();
        }

        [Key]
        public int backup_set_id { get; set; }

        public Guid backup_set_uuid { get; set; }

        public int media_set_id { get; set; }

        public byte? first_family_number { get; set; }

        public short? first_media_number { get; set; }

        public byte? last_family_number { get; set; }

        public short? last_media_number { get; set; }

        public byte? catalog_family_number { get; set; }

        public short? catalog_media_number { get; set; }

        public int? position { get; set; }

        public DateTime? expiration_date { get; set; }

        public int? software_vendor_id { get; set; }

        [StringLength(128)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(128)]
        public string user_name { get; set; }

        public byte? software_major_version { get; set; }

        public byte? software_minor_version { get; set; }

        public short? software_build_version { get; set; }

        public short? time_zone { get; set; }

        public byte? mtf_minor_version { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? first_lsn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? last_lsn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? checkpoint_lsn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? database_backup_lsn { get; set; }

        public DateTime? database_creation_date { get; set; }

        public DateTime? backup_start_date { get; set; }

        public DateTime? backup_finish_date { get; set; }

        [StringLength(1)]
        public string type { get; set; }

        public short? sort_order { get; set; }

        public short? code_page { get; set; }

        public byte? compatibility_level { get; set; }

        public int? database_version { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? backup_size { get; set; }

        [StringLength(128)]
        public string database_name { get; set; }

        [StringLength(128)]
        public string server_name { get; set; }

        [StringLength(128)]
        public string machine_name { get; set; }

        public int? flags { get; set; }

        public int? unicode_locale { get; set; }

        public int? unicode_compare_style { get; set; }

        [StringLength(128)]
        public string collation_name { get; set; }

        public bool? is_password_protected { get; set; }

        [StringLength(60)]
        public string recovery_model { get; set; }

        public bool? has_bulk_logged_data { get; set; }

        public bool? is_snapshot { get; set; }

        public bool? is_readonly { get; set; }

        public bool? is_single_user { get; set; }

        public bool? has_backup_checksums { get; set; }

        public bool? is_damaged { get; set; }

        public bool? begins_log_chain { get; set; }

        public bool? has_incomplete_metadata { get; set; }

        public bool? is_force_offline { get; set; }

        public bool? is_copy_only { get; set; }

        public Guid? first_recovery_fork_guid { get; set; }

        public Guid? last_recovery_fork_guid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fork_point_lsn { get; set; }

        public Guid? database_guid { get; set; }

        public Guid? family_guid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? differential_base_lsn { get; set; }

        public Guid? differential_base_guid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? compressed_backup_size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<backupfile> backupfile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<backupfilegroup> backupfilegroup { get; set; }

        public virtual backupmediaset backupmediaset { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<restorehistory> restorehistory { get; set; }
    }
}
