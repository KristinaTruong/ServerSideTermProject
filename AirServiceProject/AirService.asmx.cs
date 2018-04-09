using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        //Get flights with specified aircarrier, dep.city, dep.state, arrivalCity, arrivalState
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
            DataSet OpenFlights = objDB.GetDataSetUsingCmdObj(objCommand); //return results of stored procedure as dataset

            return OpenFlights;
        }

        //get flights with the specificed requirements, departure reqs and arrival reqs
        [WebMethod]
        public DataSet FindFlights(RequirementClass requirements,
            String DepartureCity, String DepartureState,
            String ArrivalCity, String ArrivalState)
        {
            //if only one requirement is specified or neither is
            if (requirements.requirementClass == null || requirements.requirementStops == null)
            {
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "FindFlightsEitherReq";
                objCommand.Parameters.AddWithValue("stops", requirements.requirementStops);
                objCommand.Parameters.AddWithValue("class", requirements.requirementClass);
                objCommand.Parameters.AddWithValue("departureCity", DepartureCity);
                objCommand.Parameters.AddWithValue("departureState", DepartureState);
                objCommand.Parameters.AddWithValue("arrivalCity", ArrivalCity);
                objCommand.Parameters.AddWithValue("arrivalState", ArrivalState);
                DataSet OpenFlights = objDB.GetDataSetUsingCmdObj(objCommand);
                return OpenFlights;
            }

            //if both requirements are specified
            else
            {
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "FindFlightsBothReq";
                objCommand.Parameters.AddWithValue("stops", requirements.requirementStops);
                objCommand.Parameters.AddWithValue("class", requirements.requirementClass);
                objCommand.Parameters.AddWithValue("departureCity", DepartureCity);
                objCommand.Parameters.AddWithValue("departureState", DepartureState);
                objCommand.Parameters.AddWithValue("arrivalCity", ArrivalCity);
                objCommand.Parameters.AddWithValue("arrivalState", ArrivalState);
                DataSet OpenFlights = objDB.GetDataSetUsingCmdObj(objCommand);
                return OpenFlights;
            }

        }


        //Reserve one flight
        [WebMethod]
        public Boolean Reserve(FlightClass flight, CustomerClass customer,
            String TravelSiteID, String TravelSitePassword)
        {
            //checks to make sure the arguments are valid
            if (checkIdAndPassword(TravelSiteID, TravelSitePassword)
                && (flight.FlightID != null)
                && (customer.CustomerID != 0))
            {
                //Check that the flight still has seats left
                Boolean hasOpenSeats = flightHasSeats(flight);

                if (hasOpenSeats == true) //if seats are available
                {
                    //first, check if the customer is in the database, if not create a record for them

                    checkCustomer(customer);
                    //second, create a reservation
                    int reservationID = Convert.ToInt32(CreateReservation(customer).Tables[0].Rows[0][0].ToString());

                    //third, reserve the flight
                    SqlCommand objCommandReserve = new SqlCommand();
                    objCommandReserve.CommandType = CommandType.StoredProcedure;
                    objCommandReserve.CommandText = "ReserveFlight";
                    objCommandReserve.Parameters.AddWithValue("reservationID", reservationID);
                    objCommandReserve.Parameters.AddWithValue("flightID", flight.FlightID); //check 
                    objCommandReserve.Parameters.AddWithValue("customerID", customer.CustomerID);
                    objCommandReserve.Parameters.AddWithValue("airCarrierID", flight.AirCarrierID); //check
                    DataSet ReserveFlight = objDB.GetDataSetUsingCmdObj(objCommandReserve);

                    //update the number of seats reserved for that flight
                    SqlCommand objCommandUpdate = new SqlCommand();
                    objCommandUpdate.CommandType = CommandType.StoredProcedure;
                    objCommandUpdate.CommandText = "UpdateReservedSeats";
                    objCommandUpdate.Parameters.AddWithValue("flightID", flight.FlightID); //check 
                    DataSet UpdateFlight = objDB.GetDataSetUsingCmdObj(objCommandUpdate);

                    return true; //return true for success
                }
                else //if no seats are available
                {
                    return false;
                }
            }
            else //if arguments are invalid
            {
                return false;
            }
        }

        //Reserve a two-way flight
        [WebMethod]
        public Boolean ReserveTwoWay(
            FlightClass firstFlight, FlightClass secondFlight,
            CustomerClass customer,
            String TravelSiteID, String TravelSitePassword)
        {
            //check arguments for validity
            if (checkIdAndPassword(TravelSiteID, TravelSitePassword)
                && (firstFlight != null)
                && (secondFlight != null)
                && (customer != null))
            {
                //check to see if both flights have seats
                if ((flightHasSeats(firstFlight) == true) && (flightHasSeats(secondFlight) == true))
                {
                    checkCustomer(customer); //check if customer exists, if not, add to database
                    Reserve(firstFlight, customer, TravelSiteID, TravelSitePassword); //reserve first flight
                    Reserve(secondFlight, customer, TravelSiteID, TravelSitePassword); //reserve second flight
                    return true;
                }
            }
            return false;

        }

        //checks to see if a customer ID is provided in customer object or if the provided
        //customerID is in the customer database
        //if no for either, a new customer is made
        private void checkCustomer(CustomerClass customer)
        {
            if (customer.CustomerID == 0)
            {
                createCustomer(customer);
            }
            else
            {
                //find the customer if a customerID is given
                SqlCommand objCommandCheckCustomer = new SqlCommand();
                objCommandCheckCustomer.CommandType = CommandType.StoredProcedure;
                objCommandCheckCustomer.CommandText = "FindCustomer";
                objCommandCheckCustomer.Parameters.AddWithValue("customerID", customer.CustomerID); //check 
                DataSet FindCustomer = objDB.GetDataSetUsingCmdObj(objCommandCheckCustomer);
                if (FindCustomer.Tables[0].Rows.Count == 0)
                {
                    //create a new customer if the customer cannot be found
                    createCustomer(customer);
                }
            }


        }

        //creates a new customer
        private void createCustomer(CustomerClass customer)
        {
            SqlCommand objCommandCheckCustomer = new SqlCommand();
            objCommandCheckCustomer.CommandType = CommandType.StoredProcedure;
            objCommandCheckCustomer.CommandText = "CreateCustomer";
            objCommandCheckCustomer.Parameters.AddWithValue("customerName", customer.CustomerName);
            objCommandCheckCustomer.Parameters.AddWithValue("customerPhone", customer.CustomerPhone);
            objCommandCheckCustomer.Parameters.AddWithValue("customerEmail", customer.CustomerEmail);
            DataSet CreateCustomer = objDB.GetDataSetUsingCmdObj(objCommandCheckCustomer);
        }
        //method to check travel site credentials
        private Boolean checkIdAndPassword(String TravelSiteID, String TravelSitePassword)
        {
            if ((TravelSiteID.Trim() == "")
                && (TravelSitePassword.Trim() == ""))
            {
                return true; //return true if correct
            }
            else
            {
                return false; // return false if incorrect
            }
        }

        //creates a reservation and returns a simple one cell dataset containing the reservationID of the new reservation
        private DataSet CreateReservation(CustomerClass customer)
        {
            //if seats are open, create a reservation first
            SqlCommand objCommandCreate = new SqlCommand();
            objCommandCreate.CommandType = CommandType.StoredProcedure;
            objCommandCreate.CommandText = "CreateReservation";
            objCommandCreate.Parameters.AddWithValue("customerID", customer.CustomerID);
            DataSet CreateReservation = objDB.GetDataSetUsingCmdObj(objCommandCreate);
            return CreateReservation;
        }
        //returns flight data dataset
        private DataSet getFlightData(FlightClass flight)
        {
            //Get flight data first
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetFlightData";
            objCommand.Parameters.AddWithValue("flightID", flight.FlightID); //check 
            DataSet FlightData = objDB.GetDataSetUsingCmdObj(objCommand);
            return FlightData;
        }
        //returns a boolean to indicate whether or not the flight has open seats
        private Boolean flightHasSeats(FlightClass flight)
        {
            //Get flight data first
            DataSet FlightData = getFlightData(flight);
            //check to see if flight was found
            if (FlightData.Tables[0].Rows.Count != 0)
            {
                //check if flight has open seats
                if (Convert.ToInt32(FlightData.Tables[0].Rows[0][11].ToString()) >
                    Convert.ToInt32(FlightData.Tables[0].Rows[0][12].ToString()))
                {  //max seats > seats reserved
                    return true; //if yes, return true
                }
            }
            return false; //if flight not found or flight has fully booked, return false
        }
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
