using Fan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fan.Controllers
{
    public class HomeController : Controller
    {
        private static int _speed = 0;
        private static bool _direction = true;
        public ActionResult Index()
        {
            var model = new FanModel();
            model.Direction = _direction;
            model.Speed = _speed;

            return View(model);
        }

        public ActionResult SpeedUp()
        {
            _speed = _speed > 2 ? 0 : ++_speed;

            var model = new FanModel();
            model.Direction = _direction;
            model.Speed = _speed;

            return View("Index", model);
        }
        public ActionResult Reverse()
        {
            _direction = !_direction;

            var model = new FanModel();
            model.Direction = _direction;
            model.Speed = _speed;

            return View("Index", model);
        }
    }
}