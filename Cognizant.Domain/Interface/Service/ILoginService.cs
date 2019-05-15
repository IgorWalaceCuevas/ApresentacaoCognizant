using Cognizant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Domain.Interface.Service
{
    public interface ILoginService : IServiceBase<Client>
    {
        bool ValidateLogin(string login, string password);
    }
}
