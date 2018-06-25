namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSdbms_datatype
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSdbms_datatype()
        {
            MSdbms_datatype_mapping = new HashSet<MSdbms_datatype_mapping>();
            MSdbms_map = new HashSet<MSdbms_map>();
        }

        [Key]
        public int datatype_id { get; set; }

        public int dbms_id { get; set; }

        [Required]
        [StringLength(128)]
        public string type { get; set; }

        public int createparams { get; set; }

        public virtual MSdbms MSdbms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSdbms_datatype_mapping> MSdbms_datatype_mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSdbms_map> MSdbms_map { get; set; }
    }
}
