using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19284129_HW04.Models;

namespace u19284129_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //VVM veVM = new VVM();
        //OVM ocVM = new OVM();

        public ActionResult VehicleV()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult VehicleV(double d, string ft, double fc)
        {
            return View("VehicleResults", veVM);
        }

        public ActionResult VehicleResults()
        {
            return View();
        }*/

        public ActionResult OceanV()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult OceanV(double p, double m)
        {
            foreach (O oce in OItems)
            {
                ocVM.OItems.Add(oce);
            }
            return View("OceanResults", ocVM);
        }

        public ActionResult OceanResults()
        {
            return View();
        }*/
    }
}