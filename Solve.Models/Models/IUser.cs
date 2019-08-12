using System;
using System.Collections.Generic;
using System.Text;

namespace Solve.Models
{
    public interface IUser
    {
        string Login { get; set; }
        string Password { get; set; }
    }
}
