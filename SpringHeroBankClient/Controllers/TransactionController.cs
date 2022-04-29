using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpringHeroBankClient.ServiceReference1;

namespace SpringHeroBankClient.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult Deposit()
        {
            return View();
        }

        public ActionResult Withdraw()
        {
            return View();
        }

        public ActionResult Transfer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Transfer(string receiverAccountNumber, double amount)
        {
            var service = new Service1Client();
            var token = Views.AccountController.staticToken;

            if (service.Transfer(token, receiverAccountNumber, amount))
            {
                ViewBag.Message = "Action success";
            }
            else
            {
                ViewBag.Message = "Action failed";
            }
            return View();
        }
    }
}