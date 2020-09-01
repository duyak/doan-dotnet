using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Website_StorePhone3.Models;
using Website_StorePhone3.Models.DB;

namespace Website_StorePhone3.Controllers
{
    [Authorize(Roles = "User")]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        [Authorize(Roles = "User")]
        public ActionResult Index()
        {
            return View();

        }
        [Authorize]
        public ActionResult Blog()
        {
            return View();

        }
        [Authorize]
        public ActionResult Cart()
        {
            return View();
        }
        [Authorize]
        public ActionResult ListProduct()
        {
            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            return View();
        }
        [Authorize]
        public ActionResult CheckOut()
        {
            return View();
        }
        

    }
}