using DB.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Interfaces
{
    public interface IJWTTokenService
    {
        string CreateToken(User user);
    }
}
