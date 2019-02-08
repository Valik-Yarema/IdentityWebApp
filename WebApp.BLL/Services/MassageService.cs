using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApp.BLL.DTO;
using WebApp.BLL.Infrastructure;
using WebApp.BLL.Interfaces;

namespace WebApp.BLL.Services
{
    public class MassageService { 
        public Task<ClaimsIdentity> Authenticate(UserDTO userDto)
        {
            throw new NotImplementedException();
        }

     
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task SetInitialData(UserDTO adminDto, List<string> roles)
        {
            throw new NotImplementedException();
        }
    }
}
