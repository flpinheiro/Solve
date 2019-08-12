using System;
using System.Collections.Generic;
using System.Text;

namespace Solve.Models
{
    class User : IUser
    {        
        public string Login { get; set ; }
        public string Password { get ; set; }
    }
}
