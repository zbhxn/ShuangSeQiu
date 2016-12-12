using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShuangSeQiu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Action()
        {
            return Json(GetNumber(), JsonRequestBehavior.AllowGet);
        }

        public string[] GetNumber()
        {
            string[] array = new string[7];
            Random rd = new Random();

            array[0] = rd.Next(1, 34).ToString();
            do
            {
                array[1] = rd.Next(1, 34).ToString();
            } while (array[1] == array[0]);
            do
            {
                array[2] = rd.Next(1, 34).ToString();
            } while (array[2] == array[0] || array[2] == array[1]);
            do
            {
                array[3] = rd.Next(1, 34).ToString();
            } while (array[3] == array[0] || array[3] == array[1] || array[3] == array[2]);
            do
            {
                array[4] = rd.Next(1, 34).ToString();
            } while (array[4] == array[0] || array[4] == array[1] || array[4] == array[2] || array[4] == array[3]);
            do
            {
                array[5] = rd.Next(1, 34).ToString();
            } while (array[5] == array[0] || array[5] == array[1] || array[5] == array[2] || array[5] == array[3] || array[5] == array[4]);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (Convert.ToInt32(array[i]) > Convert.ToInt32(array[j]))
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            array[6] = rd.Next(1, 17).ToString();

            return array;
        }
    }
}