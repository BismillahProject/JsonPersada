namespace Persada.Fr.Model.Master
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOURIS_TM_DISTRICTS
    {
        public TOURIS_TM_DISTRICTS()
        {
            TOURIS_TM_VILLAGE = new HashSet<TOURIS_TM_VILLAGE>();
        }

        public int ID { get; set; }

        public int CITY_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string DISTRICTS_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string DISTRICTS_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string DISTRICTS_DESCRIPTION { get; set; }

        public DateTime CREATED_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? LAST_MODIFIED_TIME { get; set; }

        [StringLength(50)]
        public string LAST_MODIFIED_BY { get; set; }

        public int ROW_STATUS { get; set; }

        public virtual TOURIS_TM_CITY TOURIS_TM_CITY { get; set; }
        
        public virtual ICollection<TOURIS_TM_VILLAGE> TOURIS_TM_VILLAGE { get; set; }
    }
}
