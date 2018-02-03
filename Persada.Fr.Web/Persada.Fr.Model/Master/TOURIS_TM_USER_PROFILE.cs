namespace Persada.Fr.Model.Master
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOURIS_TM_USER_PROFILE
    {
        public TOURIS_TM_USER_PROFILE()
        {
            TOURIS_TM_USER_PROFILE_SOSMED = new HashSet<TOURIS_TM_USER_PROFILE_SOSMED>();
        }

        public int ID { get; set; }

        public int USER_ID_ID { get; set; }

        [MaxLength(1)]
        public byte[] PHOTO { get; set; }

        [StringLength(1)]
        public string GENDER { get; set; }

        public DateTime? BORN { get; set; }

        [StringLength(100)]
        public string ADDRESS { get; set; }

        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        [StringLength(100)]
        public string JOB { get; set; }

        [StringLength(100)]
        public string COMPANY { get; set; }

        [StringLength(100)]
        public string HOBBY { get; set; }

        public DateTime CREATED_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? LAST_MODIFIED_TIME { get; set; }

        [StringLength(50)]
        public string LAST_MODIFIED_BY { get; set; }

        public int ROW_STATUS { get; set; }

        public virtual TOURIS_TM_USER TOURIS_TM_USER { get; set; }
        
        public virtual ICollection<TOURIS_TM_USER_PROFILE_SOSMED> TOURIS_TM_USER_PROFILE_SOSMED { get; set; }
    }
}
