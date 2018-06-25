namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_send_retries
    {
        [Key]
        public Guid conversation_handle { get; set; }

        public int mailitem_id { get; set; }

        public int send_attempts { get; set; }

        public DateTime last_send_attempt_date { get; set; }

        public virtual sysmail_mailitems sysmail_mailitems { get; set; }
    }
}
