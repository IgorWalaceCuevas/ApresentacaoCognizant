using Cognizant.Domain.Entities;
using Cognizant.Domain.Interface.Repository;
using Cognizant.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Domain.Service
{
    public class LoginService : ServiceBase<Client>, ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository) : base (loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public bool ValidateLogin(string login, string password)
        {
            return _loginRepository.ValidateLogin(login, password);
        }
    }
}
