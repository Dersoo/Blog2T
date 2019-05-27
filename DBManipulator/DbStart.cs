using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DBManipulator.Models;

namespace DBManipulator
{
    public static class DbStart
    {
        public static ArticleContext db = new ArticleContext();
    }
}