namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysmail_mailitems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sysmail_mailitems()
        {
            sysmail_send_retries = new HashSet<sysmail_send_retries>();
            sysmail_attachments = new HashSet<sysmail_attachments>();
        }

        [Key]
        public int mailitem_id { get; set; }

        public int profile_id { get; set; }

        public string recipients { get; set; }

        public string copy_recipients { get; set; }

        public string blind_copy_recipients { get; set; }

        [StringLength(255)]
        public string subject { get; set; }

        public string from_address { get; set; }

        public string reply_to { get; set; }

        public string body { get; set; }

        [StringLength(20)]
        public string body_format { get; set; }

        [StringLength(6)]
        public string importance { get; set; }

        [StringLength(12)]
        public string sensitivity { get; set; }

        public string file_attachments { get; set; }

        [StringLength(20)]
        public string attachment_encoding { get; set; }

        public string query { get; set; }

        [StringLength(128)]
        public string execute_query_database { get; set; }

        public bool? attach_query_result_as_file { get; set; }

        public bool? query_result_header { get; set; }

        public int? query_result_width { get; set; }

        [StringLength(1)]
        public string query_result_separator { get; set; }

        public bool? exclude_query_output { get; set; }

        public bool? append_query_error { get; set; }

        public DateTime send_request_date { get; set; }

        [Required]
        [StringLength(128)]
        public string send_request_user { get; set; }

        public int? sent_account_id { get; set; }

        public byte? sent_status { get; set; }

        public DateTime? sent_date { get; set; }

        public DateTime last_mod_date { get; set; }

        [Required]
        [StringLength(128)]
        public string last_mod_user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmail_send_retries> sysmail_send_retries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sysmail_attachments> sysmail_attachments { get; set; }
    }
}
