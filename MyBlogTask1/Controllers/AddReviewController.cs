using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using DBManipulator.Models;
using DBManipulator;

namespace MyBlogTask1.Controllers
{
    public class AddReviewController : Controller
    {
        //Возвращает представление формы для добавление статьи
        public ActionResult AddReview()
        {
            return View();
        }

        //Принимает запрос из формы, инициализация полей модели, и добавление их в БД
        [HttpPost]
        public ActionResult AddReview(Article article)
        {
            article.Adate = DateTime.Now;
            DbStart.db.Articles.Add(article);
            DbStart.db.SaveChanges();
            return Redirect("/Articles/Articles");
            //return "Статья на тему '" + article.Aname + "' успешно добавлена.";
        }
    }
}