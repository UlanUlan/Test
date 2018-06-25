namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("restorefile")]
    public partial class restorefile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int restore_history_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? file_number { get; set; }

        [StringLength(260)]
        public string destination_phys_drive { get; set; }

        [StringLength(260)]
        public string destination_phys_name { get; set; }

        public virtual restorehistory restorehistory { get; set; }
    }
}
