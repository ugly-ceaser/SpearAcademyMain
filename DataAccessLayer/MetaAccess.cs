using DataTransfarLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class MetaAccess:PostContext
    {
        public static void addMeta(MetaDataTransfer MetaData)
        {
            Meta MetaModel = new Meta();

            MetaModel.ID = MetaData.MetaId;
            MetaModel.MetaContent = MetaData.MetaContent;
            MetaModel.Name = MetaData.MetaName;

            database.Metas.Add(MetaModel);
            database.SaveChanges();

        }
    }
}
