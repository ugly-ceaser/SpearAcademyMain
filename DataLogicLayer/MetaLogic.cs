using DataAccessLayer;
using DataTransfarLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLayer
{
    
    public class MetaLogic
    {
        MetaAccess MetaDataAccess = new MetaAccess();
        public bool addMetaData(MetaDataTransfer MetaDataObject)
        {
            Meta MetaModel = new Meta();

            MetaModel.ID = MetaDataObject.MetaId;
            MetaModel.MetaContent = MetaDataObject.MetaContent;
            MetaModel.Name = MetaDataObject.MetaName;
            MetaModel.AddDate = DateTime.Now;
            MetaModel.LastUpdateDate = DateTime.Now;
            MetaModel.LastUpdateUserID = UserStactic.UserId;

            var MetaId = MetaDataAccess.addMeta(MetaModel);

            LogDataLogic.Addlog(General.proccessType.MetaAdd, General.TableName.Meta, MetaId);

            return true;
            

        }
    }
}
