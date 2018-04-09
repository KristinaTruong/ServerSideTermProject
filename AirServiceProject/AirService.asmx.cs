using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;


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
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        [WebMethod]
        public DataSet GetAirCarriers(string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetAirCarriers";
            objCommand.Parameters.AddWithValue("@theDepartureCity", DepartureCity);
            objCommand.Parameters.AddWithValue("@theDepartureState", DepartureState);
            objCommand.Parameters.AddWithValue("@theArrivalCity", ArrivalCity);
            objCommand.Parameters.AddWithValue("@theArrivalState", ArrivalState);

            DataSet AirCarrier = objDB.GetDataSetUsingCmdObj(objCommand);

            return AirCarrier;
        }
        [WebMethod]
        public DataSet FilterFlightsByCarrier(int AirCarrierID, string requirements, string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "FilterFlightsByCarrier";
            objCommand.Parameters.AddWithValue("@theAirCarrierID", AirCarrierID);
            objCommand.Parameters.AddWithValue("@therequirements", requirements);
            objCommand.Parameters.AddWithValue("@theDepartureCity", DepartureCity);
            objCommand.Parameters.AddWithValue("@theDepartureState", DepartureState);
            objCommand.Parameters.AddWithValue("@theArrivalCity", ArrivalCity);
            objCommand.Parameters.AddWithValue("@theArrivalState", ArrivalState);

            DataSet FilterFlight = objDB.GetDataSetUsingCmdObj(objCommand);
            return FilterFlight;


        }
    }
       
        
    
}
