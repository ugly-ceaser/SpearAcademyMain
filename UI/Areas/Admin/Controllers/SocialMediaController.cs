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

            if(SocialMediaObject.SocialMediaImage == null)
            {

                ViewBag.ProcessState = General.Messages.MissingImage;
                
            }

           else if (ModelState.IsValid)
            {

                HttpPostedFileBase HttpPostedFile = SocialMediaObject.SocialMediaImage;
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

        public ActionResult UpdateSocial(int ID)
        {

           
            SocialMediaDataTransfer SocialMediaObject = new SocialMediaDataTransfer();

            SocialMediaObject = SocialMediaDatalogic.GetSocialMediaById(ID);
            return View(SocialMediaObject);
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
            return RedirectToAction("SocialList");
        }

        public ActionResult DeleteSocialById(int ID)
        {
           

            var Feedback = SocialMediaDatalogic.DeleteSocialMediaById(ID);

            

            return RedirectToAction("SocialList");
        }
    }
}