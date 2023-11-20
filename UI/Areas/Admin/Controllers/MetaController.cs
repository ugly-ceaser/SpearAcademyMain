using DataAccessLayer;
using DataLogicLayer;
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
        MetaLogic MetalDatalogic = new MetaLogic();
        // GET: Admin/Meta
        public ActionResult Index()
        {
            MetaDataTransfer model = new MetaDataTransfer();

            return View(model);

        }

        [HttpPost]
        public ActionResult Index(MetaDataTransfer MetaObject)
        {
            
            if (ModelState.IsValid)
            {
             

                if (MetalDatalogic.addMetaData(MetaObject))
                {
                    ViewBag.ProccessState = General.Messages.AddSuccess;

                    ModelState.Clear();
                }
                else
                {
                    ViewBag.ProccessState = General.Messages.GeneralError;
                }
            }
            else
            {
                ViewBag.ProccessState = General.Messages.EmptyArea;
            }
            
                
            MetaDataTransfer newObject = new MetaDataTransfer();

            return View(newObject);


        }

        public ActionResult MetaList()
        {
            List <MetaDataTransfer> MetaList = new List<MetaDataTransfer>();

            MetaList = MetalDatalogic.getAllMetaData();


            return View(MetaList);
        }

        public ActionResult UpdateMeta(int? ID)
        {
            MetaDataTransfer model = MetalDatalogic.getMetaById((int)ID);

            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateMeta(MetaDataTransfer model)
        {
            if (ModelState.IsValid)
            {
                if (MetalDatalogic.UpdateMeta(model))
                {
                    ViewBag.ProccessState = General.Messages.UpdateSuccess;


                }
                else
                {
                    ViewBag.ProcessState = General.Messages.GeneralError;
                }

            }
            else
            {
                ViewBag.ProccessState = General.Messages.EmptyArea;
            }

            return View(model);
        }



        public ActionResult GetMetaById(int ID)
        {
            MetaDataTransfer MetaObject = new MetaDataTransfer();

            MetaObject = MetalDatalogic.getMetaById(ID);

            return View(MetaObject);
        }
    }
}