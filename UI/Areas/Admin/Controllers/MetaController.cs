using DataTransfarLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class MetaController : Controller
    {
        // GET: Admin/Meta
        public ActionResult Index()
        {
            MetaDataTransfer model = new MetaDataTransfer();

            return View(model);

        }

        [HttpPost]
        public ActionResult Index(MetaDataTransfer MetaObject)
        {


            return View(MetaObject);


        }
    }
}