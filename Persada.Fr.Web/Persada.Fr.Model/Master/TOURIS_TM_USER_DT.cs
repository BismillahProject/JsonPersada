namespace Persada.Fr.Model.Master
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOURIS_TM_USER_DT
    {
        public TOURIS_TM_USER_DT()
        {
            TOURIS_TM_USER = new HashSet<TOURIS_TM_USER>();
        }

        public int ID { get; set; }

        public int ROLE_ID { get; set; }

        public int? IS_SUPER_ADMIN { get; set; }

        public DateTime CREATED_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? LAST_MODIFIED_TIME { get; set; }

        [StringLength(50)]
        public string LAST_MODIFIED_BY { get; set; }

        public int ROW_STATUS { get; set; }

        public virtual TOURIS_TM_ROLE TOURIS_TM_ROLE { get; set; }
        
        public virtual ICollection<TOURIS_TM_USER> TOURIS_TM_USER { get; set; }
    }
}
