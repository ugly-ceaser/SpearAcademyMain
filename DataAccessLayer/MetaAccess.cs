using DataTransfarLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MetaAccess:PostContext
    {
        public  int  addMeta(Meta MetaData)
        {

            try
            {
                database.Metas.Add(MetaData);
                database.SaveChanges();

                return MetaData.ID;

            }
            catch(Exception e)
            {
                throw e;
            }
           

        }

        public List<MetaDataTransfer> getMetaData()
        {
            List<MetaDataTransfer> AllMetaData = new List<MetaDataTransfer>();

            List<Meta> AllMeta = database.Metas.Where(x=>x.isDeleted == false).OrderBy(x=>x.AddDate).ToList();

            foreach(var Meta in AllMeta)
            {
                MetaDataTransfer Object = new MetaDataTransfer();

                Object.MetaId = Meta.ID;
                Object.MetaName = Meta.Name;
                Object.MetaContent = Meta.MetaContent;

                AllMetaData.Add(Object);

            }


            return AllMetaData;
        }

        public MetaDataTransfer getMetaDataById(int ID)
        {
            Meta Metadata = database.Metas.First(x => x.ID == ID);

            MetaDataTransfer Object = new MetaDataTransfer();

            Object.MetaId = Metadata.ID;
            Object.MetaName = Metadata.Name;
            Object.MetaContent = Metadata.MetaContent;

            return Object;
        }

        public void UpdateMeta(MetaDataTransfer model)
        {
            try
            {
                Meta Object = database.Metas.First(x => x.ID == model.MetaId);

                Object.MetaContent = model.MetaContent;
                Object.Name = model.MetaName;
                Object.LastUpdateDate = DateTime.Now;
                Object.LastUpdateUserID = UserStactic.UserId;


            }
            catch(Exception ex)
            {
                throw ex;
            }
            


        }
    }
}
