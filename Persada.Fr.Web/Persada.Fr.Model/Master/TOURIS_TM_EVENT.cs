namespace Persada.Fr.Model.Master
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOURIS_TM_EVENT
    {
        public TOURIS_TM_EVENT()
        {
            TOURIS_TM_EVENT_PHOTO = new HashSet<TOURIS_TM_EVENT_PHOTO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string EVENT_NAME { get; set; }

        [Required]
        [StringLength(500)]
        public string EVENT_DESCRIPTION { get; set; }

        public int CATEGORY_ID { get; set; }

        public int VILLAGE_ID { get; set; }

        [Required]
        [StringLength(500)]
        public string ADDRESS { get; set; }

        public DateTime START_TIME { get; set; }

        public DateTime END_TIME { get; set; }

        public DateTime CREATED_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? LAST_MODIFIED_TIME { get; set; }

        [StringLength(50)]
        public string LAST_MODIFIED_BY { get; set; }

        public int ROW_STATUS { get; set; }

        public virtual TOURIS_TM_CATEGORY TOURIS_TM_CATEGORY { get; set; }
        
        public virtual ICollection<TOURIS_TM_EVENT_PHOTO> TOURIS_TM_EVENT_PHOTO { get; set; }

        public virtual TOURIS_TM_VILLAGE TOURIS_TM_VILLAGE { get; set; }
    }
}
