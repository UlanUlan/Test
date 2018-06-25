namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syspolicy_facet_events
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int management_facet_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string event_name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string target_type { get; set; }

        [Key]
        [Column(Order = 3)]
        public string target_type_alias { get; set; }

        public virtual syspolicy_management_facets syspolicy_management_facets { get; set; }
    }
}
