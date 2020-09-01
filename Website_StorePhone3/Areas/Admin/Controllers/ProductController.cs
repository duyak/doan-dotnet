using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website_StorePhone3.Models.DB;

namespace Website_StorePhone3.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        dotnetstorephoneEntities db = new dotnetstorephoneEntities();
        // GET: Admin/Product
        public ActionResult Index()
        {
            List<product> products = db.products.ToList();
            return View(products);
        }
        public ActionResult Add()
        {
            // Lấy data category
            // Lấy toàn bộ thể loại:
            List<category> cate = db.categories.ToList();

            // Tạo SelectList
            SelectList cateList = new SelectList(cate, "id", "name");
            // Set vào ViewBag
            ViewBag.CategoryList = cateList;

            // Lấy data brand
            // Lấy toàn bộ thể loại
            List<brand> brand = db.brands.ToList();

            //Tạo SelectList
            SelectList brandList = new SelectList(brand, "id", "name");

            //Set vào ViewBag
            ViewBag.BrandList = brandList;


            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Add([Bind(Include = "id,activeFlag,createDate,updateDate")] product product2, int catagoryId, int brandId,string name, HttpPostedFileBase imgMain, string code, string description)
        {
            string fileName = System.IO.Path.GetFileName(imgMain.FileName);
            string urlImage = Server.MapPath("~/Image/product/" + fileName);
            imgMain.SaveAs(urlImage);
            product2.imgMain = "Image/" + fileName;
            product2.brandId = brandId;
            product2.catagoryId = catagoryId;
            product2.name = name;
            product2.code = code;
            product2.description = description;
            product2.activeFlag = 1;
            product2.createDate = DateTime.Now;
            product2.updateDate = DateTime.Now;
            db.products.Add(product2);
            db.SaveChanges();
            return RedirectToAction("Index");
/*            try
            {
                string fileName = System.IO.Path.GetFileName(imgMain.FileName);
                string urlImage = Server.MapPath("~/Image/product/" + fileName);
                imgMain.SaveAs(urlImage);
                product.brandId = brandId;
                product.catagoryId = catagoryId;
                product.code = code;
                product.description = description;
                product.activeFlag = 1;
                product.createDate = DateTime.Now;
                product.updateDate = DateTime.Now;
                db.products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            return RedirectToAction("Add");
*/
        }
    }
}