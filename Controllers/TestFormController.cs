using NavTECH.Web.Models;
using Services.Models;
using Services.Repositories;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webtest.Controllers
{
    public class TestFormController : Controller
    {
        // GET: Calendar
        private CalendarDateService _CalendarDateService;
        private CalendarJobService _CalendarJobService;
        private static IUnitOfWork _unitOfWork;
        static TestFormController()
        {
            _unitOfWork = new UnitOfWork();
        }

        public TestFormController()
        {
            _CalendarDateService = new CalendarDateService(_unitOfWork);
            _CalendarJobService = new CalendarJobService(_unitOfWork);
        }
        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult CalendarFull()
        {
            return View();
        }



        public ActionResult GetCalendarJob()
        {
            var data = _CalendarJobService.Get();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCalendarDate()
        {
            var data = _CalendarDateService.Get();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}