using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DateStorage.Models;

namespace DateStorage.Controllers
{
    public class DateController : ApiController
    {
        [HttpPost]
        public string AddNewDate([FromBody]Test date)
        {
              using(AppDateContext db = new AppDateContext())
              {
                  UserDate userDate = new UserDate { Date = DateTime.Parse(date.Date) };
                  db.UserDates.Add(userDate);
                  db.SaveChanges();
              }
            return "ok";
        }
    }
    public class Test
    {
        public string Date { get; set; }
    }
}
