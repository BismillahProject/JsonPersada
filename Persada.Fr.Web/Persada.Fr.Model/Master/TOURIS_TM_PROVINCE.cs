namespace Persada.Fr.Model.Master
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOURIS_TM_PROVINCE
    {
        public TOURIS_TM_PROVINCE()
        {
            TOURIS_TM_CITY = new HashSet<TOURIS_TM_CITY>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string COUNTRY_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string PROVINCE_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string PROVINCE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string PROVINCE_DESCRIPTION { get; set; }

        public DateTime CREATED_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? LAST_MODIFIED_TIME { get; set; }

        [StringLength(50)]
        public string LAST_MODIFIED_BY { get; set; }

        public int ROW_STATUS { get; set; }
        
        public virtual ICollection<TOURIS_TM_CITY> TOURIS_TM_CITY { get; set; }
    }
}
