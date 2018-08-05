using App_master.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_master.Web.Controllers
{
    public class MainController : Controller
    {
        private readonly IBannerService bannerService;
        private readonly IWhatsNewService whatsnewService;
        private readonly IStructuredService structuredService;
        private readonly IGearedService gearedService;

        public MainController(IBannerService bannerService, IWhatsNewService whatsnewService, IStructuredService structuredService, IGearedService gearedService)
        {
            this.bannerService = bannerService;
            this.whatsnewService = whatsnewService;
            this.structuredService = structuredService;
            this.gearedService = gearedService;

        }
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
    }
}