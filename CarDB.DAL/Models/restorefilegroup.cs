namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("restorefilegroup")]
    public partial class restorefilegroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int restore_history_id { get; set; }

        [StringLength(128)]
        public string filegroup_name { get; set; }

        public virtual restorehistory restorehistory { get; set; }
    }
}
