namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSdbms_datatype_mapping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSdbms_datatype_mapping()
        {
            MSdbms_map1 = new HashSet<MSdbms_map>();
        }

        [Key]
        public int datatype_mapping_id { get; set; }

        public int map_id { get; set; }

        public int dest_datatype_id { get; set; }

        public long? dest_precision { get; set; }

        public int? dest_scale { get; set; }

        public long? dest_length { get; set; }

        public bool? dest_nullable { get; set; }

        public int? dest_createparams { get; set; }

        public bool dataloss { get; set; }

        public virtual MSdbms_datatype MSdbms_datatype { get; set; }

        public virtual MSdbms_map MSdbms_map { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSdbms_map> MSdbms_map1 { get; set; }
    }
}
