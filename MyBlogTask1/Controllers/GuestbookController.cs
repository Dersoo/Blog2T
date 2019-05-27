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
    public class GuestbookController : Controller
    {
        //Вывод отзывов из БД, и дальнейшее отбражение
        public ActionResult Guestbook()
        {
            var reviews = DbStart.db.Reviews;
            ViewBag.Reviews = reviews;
            return View();
        }

        //Принимает запрос из формы, инициализация полей модели, и добавление их в БД
        [HttpPost]
        public ActionResult Guestbook(Review review)
        {
            review.Rdate = DateTime.Now;
            DbStart.db.Reviews.Add(review);
            DbStart.db.SaveChanges();
            return Redirect("/Guestbook/Guestbook");
            //return "Спасибо," + review.Rname + ", за отзыв!";
        }
    }
}