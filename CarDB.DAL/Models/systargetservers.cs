namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class systargetservers
    {
        [Key]
        [Column(Order = 0)]
        public int server_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string server_name { get; set; }

        [StringLength(200)]
        public string location { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int time_zone_adjustment { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime enlist_date { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime last_poll_date { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int status { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime local_time_at_last_poll { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string enlisted_by_nt_user { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int poll_interval { get; set; }
    }
}
