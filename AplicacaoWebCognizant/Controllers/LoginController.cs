﻿using Cognizant.Application.Interface;
using Cognizant.Domain.Entities;
using Cognizant.Domain.Entities.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AplicacaoWebCognizant.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginApp _loginApp;
        public LoginController(ILoginApp loginApp)
        {
            _loginApp = loginApp;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ClientMetadata _client)
        {
            if (ModelState.IsValid)
            {
                if (_loginApp.ValidateLogin(_client.Login, _client.Password))
                {
                    FormsAuthentication.SetAuthCookie(_client.Login, false);
                    return RedirectToAction("Index", "BankAccount");
                }                
            }
            return View();
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}