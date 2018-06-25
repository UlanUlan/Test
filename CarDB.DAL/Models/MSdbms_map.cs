namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSdbms_map
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSdbms_map()
        {
            MSdbms_datatype_mapping = new HashSet<MSdbms_datatype_mapping>();
        }

        [Key]
        public int map_id { get; set; }

        public int src_dbms_id { get; set; }

        public int dest_dbms_id { get; set; }

        public int src_datatype_id { get; set; }

        public long? src_len_min { get; set; }

        public long? src_len_max { get; set; }

        public long? src_prec_min { get; set; }

        public long? src_prec_max { get; set; }

        public long? src_scale_min { get; set; }

        public long? src_scale_max { get; set; }

        public bool? src_nullable { get; set; }

        public int? default_datatype_mapping_id { get; set; }

        public virtual MSdbms MSdbms { get; set; }

        public virtual MSdbms MSdbms1 { get; set; }

        public virtual MSdbms_datatype MSdbms_datatype { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSdbms_datatype_mapping> MSdbms_datatype_mapping { get; set; }

        public virtual MSdbms_datatype_mapping MSdbms_datatype_mapping1 { get; set; }
    }
}
