namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("backupmediaset")]
    public partial class backupmediaset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public backupmediaset()
        {
            backupmediafamily = new HashSet<backupmediafamily>();
            backupset = new HashSet<backupset>();
        }

        [Key]
        public int media_set_id { get; set; }

        public Guid? media_uuid { get; set; }

        public byte? media_family_count { get; set; }

        [StringLength(128)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(128)]
        public string software_name { get; set; }

        public int? software_vendor_id { get; set; }

        public byte? MTF_major_version { get; set; }

        public byte? mirror_count { get; set; }

        public bool? is_password_protected { get; set; }

        public bool? is_compressed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<backupmediafamily> backupmediafamily { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<backupset> backupset { get; set; }
    }
}
