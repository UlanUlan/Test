namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysjobsteps
    {
        [Key]
        [Column(Order = 0)]
        public Guid job_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int step_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public string step_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string subsystem { get; set; }

        public string command { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flags { get; set; }

        public string additional_parameters { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cmdexec_success_code { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte on_success_action { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int on_success_step_id { get; set; }

        [Key]
        [Column(Order = 8)]
        public byte on_fail_action { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int on_fail_step_id { get; set; }

        [StringLength(128)]
        public string server { get; set; }

        [StringLength(128)]
        public string database_name { get; set; }

        [StringLength(128)]
        public string database_user_name { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int retry_attempts { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int retry_interval { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int os_run_priority { get; set; }

        [StringLength(200)]
        public string output_file_name { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int last_run_outcome { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int last_run_duration { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int last_run_retries { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int last_run_date { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int last_run_time { get; set; }

        public int? proxy_id { get; set; }

        public Guid? step_uid { get; set; }
    }
}
