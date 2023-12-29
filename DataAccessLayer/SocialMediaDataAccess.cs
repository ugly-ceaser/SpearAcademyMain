using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransfarLayer;

namespace DataAccessLayer
{
    public class SocialMediaDataAccess: PostContext
    {

        public int AddSocial(SocialMedia SocialMedia)
        {

            try 
            {
                database.SocialMedias.Add(SocialMedia);
                database.SaveChanges();

                return SocialMedia.ID;
            }
            catch(Exception e)
            {
                throw e;

            }
            
        }

        public List<SocialMediaDataTransfer> GetAllSocial()
        {

            List<SocialMediaDataTransfer> AllSocialData = new List<SocialMediaDataTransfer>();

            List<SocialMedia> AllSocialMedia = database.SocialMedias.Where(x => x.isDeleted == false).OrderBy(x => x.AddDate).ToList();

            foreach (var Social in AllSocialMedia)
            {
                SocialMediaDataTransfer Object = new SocialMediaDataTransfer
                {
                    SocialId = Social.ID,
                    SocialName = Social.Name,
                    ImagePath = Social.ImagePath,
                    Link = Social.Link
                };


                AllSocialData.Add(Object);

            }


            return AllSocialData;

        }

        public SocialMediaDataTransfer GetSocialDataById(int ID)
        {
            SocialMedia SocialMediaData = database.SocialMedias.First(x => x.ID == ID);

            SocialMediaDataTransfer Object = new SocialMediaDataTransfer
            {
                SocialId = SocialMediaData.ID,
                SocialName = SocialMediaData.Name,
                Link = SocialMediaData.Link,
                ImagePath = SocialMediaData.ImagePath
            };

            return Object;
        }

        public void UpdateSocialMedia(SocialMediaDataTransfer model) 
        {
            try
            {

                SocialMedia Object = database.SocialMedias.First(x => x.ID == model.SocialId);

                Object.Link = model.Link;
                Object.Name = model.SocialName;
                Object.ImagePath = model.ImagePath;
                Object.LastUpdateDate = DateTime.UtcNow;
                Object.LastUpdateUserID = UserStactic.UserId;


            }
            catch(Exception e) 
            {
                throw e;
            }
            
        }
        
        public bool DeleteSocialMediaById(int ID)
        {
            SocialMedia Object = database.SocialMedias.First(x => x.ID == ID);

            Object.isDeleted = true;

            database.SaveChanges();

            return true;
        }
    }
}
