using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYD_s.Domain.Enum
{
    public enum StatusCode
    {
        UserNotFound = 0,
        DoctorNotFound =10,
        OK = 200,
        InternalServerError = 500
    }
}
