using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;
using DataLogicLayer;
using DataTransfarLayer;

namespace UI.Areas.Admin.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: Admin/SocialMedia

        SocialMediaDataLogic SocialMediaDatalogic = new SocialMediaDataLogic();
        public ActionResult Index()
        {

            SocialMediaDataTransfer model = new SocialMediaDataTransfer();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(SocialMediaDataTransfer SocialMediaObject)
        {
            if (ModelState.IsValid)
            {
                if (SocialMediaDatalogic.AddSocialMediaData(SocialMediaObject))
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

            SocialMediaDataTransfer newObject = new SocialMediaDataTransfer();

            return View(newObject);

        }


        public ActionResult SocialList() 
        {

            List<SocialMediaDataTransfer> SocialList = new List<SocialMediaDataTransfer>();

            SocialList = SocialMediaDatalogic.GetAllSocialMedia();

            return View(SocialList);
        
        }

        public ActionResult UpdateSocial()
        {
            SocialMediaDataTransfer SocialDataModel = new SocialMediaDataTransfer();
            return View(SocialDataModel);
        }

        [HttpPost]

        public ActionResult UpdateSocial(SocialMediaDataTransfer model)
        {
            if (ModelState.IsValid) 
            {
                if (SocialMediaDatalogic.UpdateSocial(model))
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
            return View();
        }

        public ActionResult GetSocialById(int ID)
        {
            SocialMediaDataTransfer SocialMediaObject = new SocialMediaDataTransfer();

            SocialMediaObject = SocialMediaDatalogic.GetSocialMediaById(ID);

            return View(SocialMediaObject);
        }
    }
}