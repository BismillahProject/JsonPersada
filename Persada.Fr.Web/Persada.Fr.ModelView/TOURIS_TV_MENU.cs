using System;
using System.ComponentModel.DataAnnotations;

namespace Persada.Fr.ModelView
{
   public class TOURIS_TV_MENU
    {
        [Required]
        [StringLength(50)]
        public string MENU_NAME { get; set; }

        public int? MENU_PARENT_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string MENU_DESCRIPTION { get; set; }

        public DateTime CREATED_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string CREATED_BY { get; set; }

        public DateTime? LAST_MODIFIED_TIME { get; set; }

        [StringLength(50)]
        public string LAST_MODIFIED_BY { get; set; }

    }
}
