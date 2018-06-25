namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_attachments
    {
        [Key]
        [Column(Order = 0)]
        public int attachment_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mailitem_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(260)]
        public string filename { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int filesize { get; set; }

        public byte[] attachment { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime last_mod_date { get; set; }

        [Key]
        [Column(Order = 5)]
        public string last_mod_user { get; set; }

        public virtual sysmail_mailitems sysmail_mailitems { get; set; }
    }
}
