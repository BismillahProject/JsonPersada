namespace Persada.Fr.Model.Master
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOURIS_TM_CITY
    {
        public TOURIS_TM_CITY()
        {
            TOURIS_TM_DISTRICTS = new HashSet<TOURIS_TM_DISTRICTS>();
        }

        public int ID { get; set; }

        public int PROVINCE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CITY_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string CITY_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string CITY_DESCRIPTION { get; set; }

        public DateTime CREATED_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? LAST_MODIFIED_TIME { get; set; }

        [StringLength(50)]
        public string LAST_MODIFIED_BY { get; set; }

        public int ROW_STATUS { get; set; }

        public virtual TOURIS_TM_PROVINCE TOURIS_TM_PROVINCE { get; set; }
        
        public virtual ICollection<TOURIS_TM_DISTRICTS> TOURIS_TM_DISTRICTS { get; set; }
    }
}
