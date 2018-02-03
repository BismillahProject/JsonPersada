using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persada.Fr.Model.Context
{
    [Table("MUSER")]
    public class MUSER
    {
        [Key]
        public string USERID { get; set; }
        public string USERNAME { get; set; }
        public string TEMPAT_LAHIR { get; set; }
        public DateTime? TGL_LAHIR { get; set; }
        public string ALAMAT { get; set; }
        public string PWD { get; set; }
        public string EMAIL { get; set; }
        public bool? ACTIVE { get; set; }
    }
}
