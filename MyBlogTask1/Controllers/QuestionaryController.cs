using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using DBManipulator.Models;
using DBManipulator;
using System.Collections.Specialized;

namespace MyBlogTask1.Controllers
{
    public class QuestionaryController : Controller
    {
        //Возвращает представление с формрой для анкетирования
        public ActionResult Questionary()
        {
            return View();
        }

        //Принимает запрос из формы, инициализация полей модели, и добавление их в БД
        [HttpPost]
        public string Questionary(Profile anketa)
        {
            anketa.DateOfAnket = DateTime.Now;
            DbStart.db.Profiles.Add(anketa);
            DbStart.db.SaveChanges();
            return "Информация успешно добавлена: \n" + anketa.Surname + " " + anketa.Name + " , " + anketa.DateOfBirth + " , " + anketa.Address + " , " + "Хобби: " + anketa.Hobbies + " , " + "Пол: " + anketa.Gender;
        }
    }
}