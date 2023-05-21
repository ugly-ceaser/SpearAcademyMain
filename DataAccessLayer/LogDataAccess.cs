using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataAccessLayer
{
    public class LogDataAccess:PostContext
    {
        public static void AddLog(int proccessType, string TableName,int ProccessId)
        {
            Log_Table logData = new Log_Table();

            logData.ProcessID = ProccessId;
            logData.ProcessType = proccessType;
            logData.ProcessCategoryType = TableName;
            logData.IPAdress = HttpContext.Current.Request.UserHostAddress;
            database.Log_Table.Add(logData);
            database.SaveChanges();


        }
    }
}
