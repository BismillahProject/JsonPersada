namespace Persada.Fr.Model.Master
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOURIS_TM_CATEGORY
    {
        public TOURIS_TM_CATEGORY()
        {
            TOURIS_TM_CULINARY = new HashSet<TOURIS_TM_CULINARY>();
            TOURIS_TM_EVENT = new HashSet<TOURIS_TM_EVENT>();
            TOURIS_TM_TOUR = new HashSet<TOURIS_TM_TOUR>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CATEGORY_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string CATEGORY_NAME { get; set; }

        [Required]
        [StringLength(500)]
        public string CATEGORY_DESCRIPTION { get; set; }

        public DateTime CREATED_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? LAST_MODIFIED_TIME { get; set; }

        [StringLength(50)]
        public string LAST_MODIFIED_BY { get; set; }

        public int ROW_STATUS { get; set; }
        
        public virtual ICollection<TOURIS_TM_CULINARY> TOURIS_TM_CULINARY { get; set; }

        public virtual ICollection<TOURIS_TM_EVENT> TOURIS_TM_EVENT { get; set; }

        public virtual ICollection<TOURIS_TM_TOUR> TOURIS_TM_TOUR { get; set; }
    }
}
