using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLogicLayer;
using DataTransfarLayer;

namespace UI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        UserDataLogic DataLogic = new UserDataLogic();

        // GET: Admin/Login
        public ActionResult Index()
        {
            UserDataTranfer UserDTO = new UserDataTranfer();
            return View(UserDTO);
        }

        [HttpPost]
        public ActionResult Index(UserDataTranfer model)
        {

            if (ModelState.IsValid)
            {
                var user = DataLogic.Authenticate_UserDetail(model);

                if(user.ID != 0)
                {

                    UserStactic.UserId = user.ID;
                    UserStactic.IsAdmin = user.IsAdmin;
                    UserStactic.ImagePath = user.ImagePath;
                    UserStactic.NameSurname = user.Name;

                    LogDataLogic.Addlog(1, "Login", 13);
                    

                    return RedirectToAction("Index", "Post");

                }
                else
                return View(model);

            }
            return View(model);
        }

      
    }
}