namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syscollector_collection_items_internal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syscollector_collection_items_internal()
        {
            syscollector_tsql_query_collector = new HashSet<syscollector_tsql_query_collector>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int collection_set_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public int collection_item_id { get; set; }

        public Guid collector_type_uid { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public int? name_id { get; set; }

        public int frequency { get; set; }

        [Column(TypeName = "xml")]
        public string parameters { get; set; }

        public virtual syscollector_collection_sets_internal syscollector_collection_sets_internal { get; set; }

        public virtual syscollector_collector_types_internal syscollector_collector_types_internal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syscollector_tsql_query_collector> syscollector_tsql_query_collector { get; set; }
    }
}
