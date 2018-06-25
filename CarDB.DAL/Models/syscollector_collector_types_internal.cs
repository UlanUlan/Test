namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syscollector_collector_types_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syscollector_collector_types_internal()
        {
            syscollector_collection_items_internal = new HashSet<syscollector_collection_items_internal>();
        }

        [Key]
        public Guid collector_type_uid { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [Column(TypeName = "xml")]
        public string parameter_schema { get; set; }

        [Column(TypeName = "xml")]
        public string parameter_formatter { get; set; }

        [StringLength(128)]
        public string schema_collection { get; set; }

        [Required]
        [StringLength(128)]
        public string collection_package_name { get; set; }

        public Guid collection_package_folderid { get; set; }

        [Required]
        [StringLength(128)]
        public string upload_package_name { get; set; }

        public Guid upload_package_folderid { get; set; }

        public bool is_system { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syscollector_collection_items_internal> syscollector_collection_items_internal { get; set; }

        public virtual sysssispackages sysssispackages { get; set; }

        public virtual sysssispackages sysssispackages1 { get; set; }
    }
}
