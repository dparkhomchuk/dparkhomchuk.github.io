using AuthorizationPrototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebPrototype.Models;

namespace AuthorizationPrototype.Controllers
{
    public class HomeController : Controller
    {
        private List<Location> _location = new List<Location>();
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PostPoint(StationDTO dto)
        {
            var station = new Location();
            station.GeoLat = dto.GeoLat;
            station.GeoLong = dto.GeoLong;
            station.PlaceCategory = dto.PlaceCategory;
            station.PlaceName = dto.PlaceName;
            station.ToiletAvail = dto.ToiletAvail;
            station.TrafficLightAvail = dto.TrafficLightAvail;
            station.MenuAvail = dto.MenuAvail;
            station.VisualAvail = dto.VisualAvail;
            var random = new Random((int)DateTime.Now.Ticks);
            var value = random.Next(0, 3);
            station.AvailabilityType = (AvailabilityType)random.Next(0,3);
            _dbContext.Locations.Add(station);
            _dbContext.SaveChanges();
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public JsonResult GetData()
        {
            _location = _dbContext.Locations.ToList();
            return Json(_location, JsonRequestBehavior.AllowGet);
        }

    }
}