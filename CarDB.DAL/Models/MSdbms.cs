namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSdbms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSdbms()
        {
            MSdbms_datatype = new HashSet<MSdbms_datatype>();
            MSdbms_map = new HashSet<MSdbms_map>();
            MSdbms_map1 = new HashSet<MSdbms_map>();
        }

        [Key]
        public int dbms_id { get; set; }

        [Required]
        [StringLength(128)]
        public string dbms { get; set; }

        [StringLength(128)]
        public string version { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSdbms_datatype> MSdbms_datatype { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSdbms_map> MSdbms_map { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSdbms_map> MSdbms_map1 { get; set; }
    }
}
