using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICreditCard _creditCard;

        public HomeController(ICreditCard creditCard)
        {
            _creditCard = creditCard;
        }

        public ActionResult Index()
        {
            ViewBag.CreditCard = _creditCard.Charge();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}