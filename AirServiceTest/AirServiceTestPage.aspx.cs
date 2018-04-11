using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AirServiceProject
{
    public partial class Test : System.Web.UI.Page
    {
        /*

        //global pxy object for methods to call web methods with
        public AirServiceProject.AirService pxy = new AirServiceProject.AirService();

        //variables to hold argument values
        //associated booleans for if-else statement purposes
        String depCity;
        Boolean depCityB;

        String depState;
        Boolean depStateB;

        String arrivCity;
        Boolean arrivCityB;

        String arrivState;
        Boolean arrivStateB;

        int numberOfTrips; //default is one way trip

        int numberOfStops;
        Boolean numberOfStopsB;

        String classReq = null;
        Boolean classReqB;

        String airCarrier;
        Boolean airCarrierB;

        String travelID;
        String travelPassword;

        //objects to be used in booking and searching flights
        AirServiceProject.CustomerClass customer = new AirServiceProject.CustomerClass();
        AirServiceProject.FlightClass flight = new AirServiceProject.FlightClass();
        AirServiceProject.RequirementClass requirements = new AirServiceProject.RequirementClass();
        AirServiceProject.AirCarrierClass airCarrierID = new AirServiceProject.AirCarrierClass();   */

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet startDS = null;
            gvFlights.DataSource = startDS;
            gvFlights.DataBind();
        }

        
        protected void btnSearch_Click(object sender, EventArgs e)
        {

            /*
            //assignment variables their appropriate values from the form text boxes
            //if value received, set associated boolean to true
            depCity = (txtDepCity.Text.Trim() != null) ? txtDepCity.Text.Trim() : null;
            depCityB = (txtDepCity.Text.Trim() != null) ? true : false;

            depState = (txtDepState.Text.Trim() != null) ? txtDepState.Text.Trim() : null;
            depStateB = (txtDepState.Text.Trim() != null) ? true : false;

            arrivCity = (txtArrCity.Text.Trim() != null) ? txtArrCity.Text.Trim() : null;
            arrivCityB = (txtArrCity.Text.Trim() != null) ? true : false;

            arrivState = (txtArrState.Text.Trim() != null) ? txtArrState.Text.Trim() : null;
            arrivStateB = (txtArrState.Text.Trim() != null) ? true : false;

            numberOfTrips = (RbTwo.Checked) ? 2 : 1;

            numberOfStops = (txtStops.Text.Trim() != null) ? (Convert.ToInt32(txtStops.Text.Trim())) : -1;
            numberOfStopsB = (numberOfStops != -1) ? true : false;

            //for one or two way radio buttons
            if (ddlClass.SelectedIndex != 0)
            {
                switch (ddlClass.SelectedIndex)
                {
                    case 1: classReq = "First"; break;
                    case 2: classReq = "Economy"; break;
                    case 3: classReq = "Business"; break;
                    case 4: classReq = "Premium"; break;
                    default: classReq = null; break;
                }
            }

            classReqB = (classReq != null) ? true : false;

            airCarrier = (txtAirCarrier.Text.Trim() != null) ? txtAirCarrier.Text.Trim() : null;
            airCarrierB = (airCarrier != null) ? true : false;


            airCarrierID.AirCarrierID = airCarrier;


            requirements.requirementStops = numberOfStops;
            requirements.requirementClass = classReq;

            //--------------------------------------------------------------------
            //Execute method depending on what values were inputted

            if //getAirCarriers
                (depCityB &&
                depStateB &&
                arrivCityB &&
                arrivStateB &&
                (!numberOfStopsB &&
                !classReqB) &&
                !airCarrierB
                )
            {
                gvFlights.DataSource = pxy.GetAirCarriers(depCity, depState, arrivCity, arrivState); //call on web service method
            }

            else if //get flights
                (depCityB &&
                depStateB &&
                arrivCityB &&
                arrivStateB &&
                (!numberOfStopsB &&
                !classReqB) &&
                airCarrierB
                )
            {
                gvFlights.DataSource = pxy.GetFlights(airCarrierID, depCity, depState, arrivCity, arrivState); //call on web service method
            }

            else if //find flights
                (depCityB &&
                depStateB &&
                arrivCityB &&
                arrivStateB &&
                (numberOfStopsB ||
                classReqB) &&
                !airCarrierB
                )
            {
                gvFlights.DataSource = pxy.FindFlights(requirements, depCity, depState, arrivCity, arrivState); //call on web service method
            }

            else if //filter flights by carrier
                (depCityB &&
                depStateB &&
                arrivCityB &&
                arrivStateB &&
                (numberOfStopsB ||
                classReqB) &&
                airCarrierB
                )
            {
                gvFlights.DataSource = pxy.FilterFlightsByCarrier(airCarrierID, requirements, depCity, depState, arrivCity, arrivState); //call on web service method
            }


            else
            {

            }
            reserveSection.Style["display"] = "block";

    */

        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            /*
             * 
             * 
            //set customer information
            customer.CustomerID = txtID.Text;
            customer.CustomerName = txtName.Text;
            customer.CustomerPhone = txtPhone.Text;
            customer.CustomerEmail = txtEmail.Text;

            //set flight object flight ID information
            flight.FlightID = txtFlightID.Text;

            //save inputed ID and password
            travelID = txtTravelID.Text;
            travelPassword = txtTravelPassword.Text;

            if //reserve flight
                (depCityB &&
                depStateB &&
                arrivCityB &&
                arrivStateB &&
                (!numberOfStopsB &&
                !classReqB) &&
                !airCarrierB
                )
            {
                gvFlights.DataSource = pxy.Reserve(airCarrierID, flight, customer, travelID, travelPassword); //call on web service method

            }

    */
        }


    
    }
}