using DataTransfarLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class UserDataAccess:PostContext
    {
        public UserDataTranfer Get_User_Detail( UserDataTranfer model) 
        {
            UserDataTranfer modelHolder = new UserDataTranfer();

            T_User user = database.T_User.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            if(user != null && user.ID != 0)
            {
                modelHolder.ID = user.ID;
                modelHolder.Username = user.Username;
                modelHolder.Name = user.NameSurname;
                modelHolder.IsAdmin = user.isAdmin;
                modelHolder.ImagePath = user.ImagePath;
            }



            return modelHolder;
        }

    }
}
