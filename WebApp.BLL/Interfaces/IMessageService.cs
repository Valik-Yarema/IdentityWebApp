using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApp.BLL.DTO;
using WebApp.BLL.Infrastructure;

namespace WebApp.BLL.Interfaces
{
    public interface IMessageService : IDisposable
    {

        Task<OperationDetails> Create(MessageDTO messageDTO);
        Task<ClaimsIdentity> Send(MessageDTO messageDTO);
        Task SetInitialData(MessageDTO adminDto, List<string> Text);

    }
}
