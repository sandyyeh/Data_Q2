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

        public ActionResult Dashboard()
        {
            string json1 = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/data1.json"));
            string json2 = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/data2.json"));
            string json3 = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/data3.json"));

            List<Model1> _list1 = JsonConvert.DeserializeObject<List<Model1>>(json1);
            List<Model1> _list2 = JsonConvert.DeserializeObject<List<Model1>>(json2);
            List<Model1> _list3 = JsonConvert.DeserializeObject<List<Model1>>(json3);


            Random num = new Random();//亂數種子
            int i = num.Next(1, 4);//回傳1-3的亂數

            switch (i)
            {
                case 1:
                   
                    return View(_list1);

                case 2:
                    return View(_list2);

                default:
                    return View(_list3);

            }
          
        }
    }
}