using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLayer
{
    public class LogDataLogic
    {
        
        public static void Addlog(int proccessType, string TableName, int ProcessId)
        {
            LogDataAccess.AddLog(proccessType, TableName, ProcessId);

        }
    }
}
