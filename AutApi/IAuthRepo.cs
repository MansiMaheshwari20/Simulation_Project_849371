using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutApi
{
    public interface IAuthRepo
    {
        
        string GenerateJSONWebToken();

        Authen AuthenticateUser(Authen userdetail);
    }
}
