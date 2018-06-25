namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_query_transfer
    {
        [Key]
        public Guid uid { get; set; }

        public string text_data { get; set; }

        public DateTime create_date { get; set; }
    }
}
