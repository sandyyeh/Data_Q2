using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sandy_20190417_Data_Q2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Sandy_20190417_Data_Q2.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public static double Hour(double hour)
        {
            return Math.Round((hour / 60), 2);
        }

        public ActionResult Dashboard(Data data)
        {

            int total = 0;
            double day, hour;

            Random random = new Random();//亂數種子
            int num = random.Next(0, 3);//回傳1-3的亂數

            string[] file = { "~/App_Data/data1.json", "~/App_Data/data2.json", "~/App_Data/data3.json" };
            string json = System.IO.File.ReadAllText(Server.MapPath(file[num]));
            List<Data> list = JsonConvert.DeserializeObject<List<Data>>(json);

            for (int i = 0; i < list.Count; i++)
            {

                total += list[i].ResponseMinutes;

            }

            day = Math.Floor((double)total / (1440 * list.Count));
            hour = Math.Round(((double)total / (60 * list.Count)), 2);

            ViewBag.Day = day;
            ViewBag.Hour = hour;

            return View(list);
        }


    }
}