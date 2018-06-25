namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_attachments_transfer
    {
        [Key]
        public int transfer_id { get; set; }

        public Guid uid { get; set; }

        [Required]
        [StringLength(260)]
        public string filename { get; set; }

        public int filesize { get; set; }

        public byte[] attachment { get; set; }

        public DateTime create_date { get; set; }
    }
}
