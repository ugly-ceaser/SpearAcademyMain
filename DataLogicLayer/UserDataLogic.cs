using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransfarLayer;

namespace DataLogicLayer
{
    public class UserDataLogic
    {
        UserDataAccess DataAccess = new UserDataAccess();
        public UserDataTranfer Authenticate_UserDetail(UserDataTranfer model) {

            UserDataTranfer verifiedUser = DataAccess.Get_User_Detail(model);
            
            
            return verifiedUser;
        }
    }
}
