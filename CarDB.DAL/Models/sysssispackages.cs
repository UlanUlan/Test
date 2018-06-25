namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysssispackages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysssispackages()
        {
            syscollector_collector_types_internal = new HashSet<syscollector_collector_types_internal>();
            syscollector_collector_types_internal1 = new HashSet<syscollector_collector_types_internal>();
        }

        [Key]
        [Column(Order = 0)]
        public string name { get; set; }

        public Guid id { get; set; }

        [StringLength(1024)]
        public string description { get; set; }

        public DateTime createdate { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid folderid { get; set; }

        [Required]
        [MaxLength(85)]
        public byte[] ownersid { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] packagedata { get; set; }

        public int packageformat { get; set; }

        public int packagetype { get; set; }

        public int vermajor { get; set; }

        public int verminor { get; set; }

        public int verbuild { get; set; }

        [StringLength(1024)]
        public string vercomments { get; set; }

        public Guid verid { get; set; }

        public bool isencrypted { get; set; }

        [MaxLength(85)]
        public byte[] readrolesid { get; set; }

        [MaxLength(85)]
        public byte[] writerolesid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syscollector_collector_types_internal> syscollector_collector_types_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syscollector_collector_types_internal> syscollector_collector_types_internal1 { get; set; }
    }
}
