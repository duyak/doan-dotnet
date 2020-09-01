using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Website_StorePhone3.Controllers;

namespace Website_StorePhone3.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    public class HomeAdminController : Controller
    {
        // GET: Admin/HomeAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult add_Product()
        {
            return View();
        }
        public ActionResult add_supplier()
        {
            return View();
        }
        public ActionResult add_user()
        {
            return View();
        }
        public ActionResult edit_supplier()
        {
            return View();
        }
        public ActionResult info_order()
        {
            return View();
        }
        public ActionResult manager_color()
        {
            return View();
        }
        public ActionResult manager_order()
        {
            return View();
        }
        public ActionResult manager_user()
        {
            return View();
        }
        public ActionResult profile_product()
        {
            return View();
        }
        public ActionResult profile_supplier()
        {
            return View();
        }
        public ActionResult profile_users()
        {
            return View();
        }

        //logout
        [Authorize]
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            /*  Session.Clear();*/

            return Redirect("/Home/Index");
        }
    }
}