using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persada.Fr.ModelView
{
    public class User
    {
        public string UserId { get; set; }
        public string Nama { get; set; }
        public string TempatLahir { get; set; }
        public DateTime? TglLahir { get; set; }
        public string Alamat { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool? Active { get; set; }
    }
}
