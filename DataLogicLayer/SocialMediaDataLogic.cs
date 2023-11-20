using DataAccessLayer;
using DataTransfarLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLayer
{
    public class SocialMediaDataLogic
    {

        SocialMediaDataAccess SocialMediaDataAccess = new SocialMediaDataAccess();
        public bool AddSocialMediaData(SocialMediaDataTransfer SocialMediaDataObject)
        {
            SocialMedia SocialMediaModel = new SocialMedia
            {
                ID = SocialMediaDataObject.SocialId,
                Link = SocialMediaDataObject.Link,
                ImagePath = SocialMediaDataObject.ImagePath,
                Name = SocialMediaDataObject.SocialName,
                AddDate = DateTime.UtcNow,
                LastUpdateDate = DateTime.UtcNow,
                LastUpdateUserID = UserStactic.UserId
            };

            var SocialMediaId = SocialMediaDataAccess.AddSocial(SocialMediaModel);

            LogDataLogic.Addlog(General.proccessType.SocialAdd, General.TableName.Social, SocialMediaId);

            return true;
            

        }

        public  List<SocialMediaDataTransfer> GetAllSocialMedia()
        {
            List<SocialMediaDataTransfer> SocialMediaList = new List<SocialMediaDataTransfer>();

            SocialMediaList = SocialMediaDataAccess.GetAllSocial();

            return SocialMediaList;
        }

        public SocialMediaDataTransfer GetSocialMediaById(int ID)
        {
            SocialMediaDataTransfer model = SocialMediaDataAccess.GetSocialDataById(ID);

            return model;
        }

        public bool UpdateSocial(SocialMediaDataTransfer model)
        {
            SocialMediaDataAccess.UpdateSocialMedia(model);
            LogDataAccess.AddLog(General.proccessType.SocialUpdate, General.TableName.Social, model.SocialId);
            return true;
        }

       
    }
}
