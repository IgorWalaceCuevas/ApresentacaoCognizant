using Cognizant.Application.Interface;
using Cognizant.Domain.Entities;
using Cognizant.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Application
{
    public class LoginApp : AppBase<Client>, ILoginApp
    {
        private readonly ILoginService _loginService;
        public LoginApp(ILoginService loginService) : base(loginService)
        {
            _loginService = loginService;

        }
        public bool ValidateLogin(string login, string password)
        {
            return _loginService.ValidateLogin(login, password);
        }
    }
}
