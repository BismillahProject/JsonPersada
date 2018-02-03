namespace Persada.Fr.Model.Master
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOURIS_TM_TOUR_PHOTO
    {
        public int ID { get; set; }

        public int TOUR_ID { get; set; }

        [Required]
        [StringLength(500)]
        public string PHOTO_NAME { get; set; }

        public int PHOTO_DESCRIPTION { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] PHOTO { get; set; }

        public DateTime CREATED_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? LAST_MODIFIED_TIME { get; set; }

        [StringLength(50)]
        public string LAST_MODIFIED_BY { get; set; }

        public int ROW_STATUS { get; set; }

        public virtual TOURIS_TM_TOUR TOURIS_TM_TOUR { get; set; }
    }
}
