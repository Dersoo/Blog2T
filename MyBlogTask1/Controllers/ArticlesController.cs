using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using DBManipulator;
using DBManipulator.Models;

namespace MyBlogTask1.Controllers
{
    public class ArticlesController : Controller
    {
        //Вывод статье из БД, и дальнейшее отображение
        public ActionResult Articles()
        {
            var articles = DbStart.db.Articles;
            ViewBag.Articles = articles;
            return View();
        }
    }
}