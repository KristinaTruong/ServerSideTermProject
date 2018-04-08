using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;
using System.Data;
using AirServiceLibrary;
using System.Data.SqlClient;
using System.Collections;

namespace AirServiceProject
{
    /// <summary>
    /// Summary description for AirService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    //[System.Web.Script.Services.ScriptService]
    public class AirService : System.Web.Services.WebService
    {
        public DBConnect objDB = new DBConnect();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataSet GetFlights(AirCarrierClass AirCarrierID,
            String DepartureCity, String DepartureState,
            String ArrivalCity, String ArrivalState)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetOpenFlights";
            objCommand.Parameters.AddWithValue("airCarrierID", AirCarrierID.AirCarrierID); //check
            objCommand.Parameters.AddWithValue("departureCity", DepartureCity);
            objCommand.Parameters.AddWithValue("departureState", DepartureState);
            objCommand.Parameters.AddWithValue("arrivalCity", ArrivalCity);
            objCommand.Parameters.AddWithValue("arrivalState", ArrivalState);
            DataSet OpenFlights = objDB.GetDataSetUsingCmdObj(objCommand);

            return OpenFlights;
        }

        [WebMethod]
        public DataSet FindFlights(RequirementClass requirements,
            String DepartureCity, String DepartureState,
            String ArrivalCity, String ArrivalState)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "FindOpenFlights";
            objCommand.Parameters.AddWithValue("stops", requirements.requirementStops);
            objCommand.Parameters.AddWithValue("class", requirements.requirementClass);
            objCommand.Parameters.AddWithValue("departureCity", DepartureCity);
            objCommand.Parameters.AddWithValue("departureState", DepartureState);
            objCommand.Parameters.AddWithValue("arrivalCity", ArrivalCity);
            objCommand.Parameters.AddWithValue("arrivalState", ArrivalState);
            DataSet OpenFlights = objDB.GetDataSetUsingCmdObj(objCommand);
            return OpenFlights;
        }

        [WebMethod]
        public Boolean Reserve(AirCarrierClass AirCarrierID,
            FlightClass flight, CustomerClass customer,
            String TravelSiteID, String TravelSitePassword)
        {
            //checks to make sure the arguments are valid
            if ((TravelSiteID.Trim() == "")
                && (TravelSitePassword.Trim() == "")
                && (AirCarrierID != null)
                && (flight != null)
                && (customer != null))
            {
                //Get flight data first
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetFlightData";
                objCommand.Parameters.AddWithValue("flightID", flight.FlightID); //check 
                DataSet FlightData = objDB.GetDataSetUsingCmdObj(objCommand);
                //Makes sure that the flight still has seats left
                if (Convert.ToInt32(FlightData.Tables[0].Rows[0][11].ToString()) >
                    Convert.ToInt32(FlightData.Tables[0].Rows[0][12].ToString())) //max seats > seats reserved
                {
                    //reserve the flight
                    SqlCommand objCommandReserve = new SqlCommand();
                    objCommandReserve.CommandType = CommandType.StoredProcedure;
                    objCommandReserve.CommandText = "ReserveFlight";
                    objCommandReserve.Parameters.AddWithValue("flightID", flight.FlightID); //check 
                    objCommandReserve.Parameters.AddWithValue("customerID", customer.CustomerID);
                    objCommandReserve.Parameters.AddWithValue("airCarrierID", AirCarrierID.AirCarrierID); //check
                    DataSet ReserveFlight = objDB.GetDataSetUsingCmdObj(objCommandReserve);
                    return true;
                }
               else
                {
                    return false;
                }

                
            }
            else
            {
                return false;
            }

        }

    }



}
