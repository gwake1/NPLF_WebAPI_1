using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NPLF_WebAPI;

namespace NPLF_WebAPI.Auth
{
    public class AuthContext : IdentityDbContext<User>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}