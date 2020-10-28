using DB.Entity;
using System;

namespace CourseWork.Domain
{
    public interface IJWTTokenService
    {
        string CreateToken(User user);
    }
}
