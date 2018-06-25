namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysproxies
    {
        [Key]
        [Column(Order = 0)]
        public int proxy_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int credential_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte enabled { get; set; }

        [StringLength(512)]
        public string description { get; set; }

        [Key]
        [Column(Order = 4)]
        [MaxLength(85)]
        public byte[] user_sid { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime credential_date_created { get; set; }
    }
}
