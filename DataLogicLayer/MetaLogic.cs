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
        
        public void addMetaData(MetaDataTransfer MetaDataObject)
        {
            MetaAccess.addMeta(MetaDataObject);
            

        }
    }
}
