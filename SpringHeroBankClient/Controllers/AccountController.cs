using SpringHeroBankClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpringHeroBankClient.Views
{
    public class AccountController : Controller
    {
        public static string staticToken = "1";

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string accountNumber, string securityCode)
        {
            var service = new Service1Client();
            if (ModelState.IsValid)
            {
                var token = service.Login(accountNumber, securityCode);
                if (String.IsNullOrEmpty(token))
                {
                    ViewBag.Error = "Login failed";
                    return RedirectToAction("Login");
                }
                else
                {
                    staticToken = token;
                    return RedirectToAction("ShowProfile");
                }
            }
            return View();
        }

        public ActionResult ShowProfile()
        {
            var service = new Service1Client();

            return View();
        }
    }
}