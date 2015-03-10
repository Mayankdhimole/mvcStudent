using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStudent.BusinessLogic;
using MvcStudent.Models;

namespace MvcStudent.Controllers
{
    public class RestuarantController : Controller
    {
        Category category = new Category();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FetchCategory()
        {
            List<CategoryModel> categoryModelList = new List<CategoryModel>();
            categoryModelList = category.FetchCustomer();
            return View(categoryModelList);
        }

        public ActionResult Edit(int id)
        {
            List<CategoryModel> categoryEditedList = category.FetchCustomer();
            CategoryModel categoryEdited = categoryEditedList.Single(x => x.CATEGORY_ID == id);
            return View(categoryEdited);
        }

        public ActionResult Details(int id)
        {
            return Edit(id);
        }

    }
}
