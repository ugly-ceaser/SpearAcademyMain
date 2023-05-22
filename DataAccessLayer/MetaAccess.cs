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
    }
}
