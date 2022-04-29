using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}