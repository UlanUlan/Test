namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class syscollector_tsql_query_collector
    {
        [Key]
        [Column(Order = 0)]
        public Guid collection_set_uid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int collection_set_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int collection_item_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid collection_package_id { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid upload_package_id { get; set; }

        public virtual syscollector_collection_items_internal syscollector_collection_items_internal { get; set; }
    }
}
