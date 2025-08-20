using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cms.core.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Username   { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }
        public bool Isactive { get; set; }
        public bool Isadmin {  get; set; }
        public DateTime LastLogin { get; set; }
    }
}
