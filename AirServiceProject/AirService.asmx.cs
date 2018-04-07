using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;

using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace AirServiceProject
{
    /// <summary>
    /// Summary description for AirService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AirService : System.Web.Services.WebService
    {
        public DBConnect objDB = new DBConnect();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Dataset GetFlights()
        {
            return null;
        }
    }
       
        
    
}
