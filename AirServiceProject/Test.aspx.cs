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
        //global pxy object for methods to call web methods with
        public AirServiceWS.AirService pxy = new AirServiceWS.AirService();

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


        AirServiceWS.CustomerClass customer = new AirServiceWS.CustomerClass();
        AirServiceWS.FlightClass flight = new AirServiceWS.FlightClass();
        AirServiceWS.RequirementClass requirements = new AirServiceWS.RequirementClass();
        AirServiceWS.AirCarrierClass airCarrierID = new AirServiceWS.AirCarrierClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet startDS = null;
            gvFlights.DataSource = startDS;
            gvFlights.DataBind();
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {


            //assignment variables their appropriate values from the form text boxes
            //if value received, set associated boolean to true
            depCity = (txtDepCity.Text.Trim() != "") ? txtDepCity.Text.Trim() : "";
            depCityB = (txtDepCity.Text.Trim() != "") ? true : false;

            depState = (txtDepState.Text.Trim() != "") ? txtDepState.Text.Trim() : "";
            depStateB = (txtDepState.Text.Trim() != "") ? true : false;

            arrivCity = (txtArrCity.Text.Trim() != "") ? txtArrCity.Text.Trim() : "";
            arrivCityB = (txtArrCity.Text.Trim() != "") ? true : false;

            arrivState = (txtArrState.Text.Trim() != "") ? txtArrState.Text.Trim() : "";
            arrivStateB = (txtArrState.Text.Trim() != "") ? true : false;

            numberOfTrips = (RbTwo.Checked) ? 2 : 1;

            numberOfStops = (txtStops.Text.Trim() != "") ? (Convert.ToInt32(txtStops.Text.Trim())) : -1;
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
                    default: classReq = ""; break;
                }
            }

            classReqB = (classReq != "") ? true : false;

            airCarrier = (txtAirCarrier.Text.Trim() != "") ? txtAirCarrier.Text.Trim() : "";
            airCarrierB = (airCarrier != "") ? true : false;

            if (airCarrierB == true)
            {
                airCarrierID.AirCarrierID = Convert.ToInt32(airCarrier);
            }

            if (numberOfStopsB == true)
            {
                requirements.requirementStops = numberOfStops.ToString();
            }
            if (classReqB == true)
            {
                requirements.requirementClass = classReq;
            }

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
                (numberOfStopsB &&
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
                (numberOfStopsB &&
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



        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {

            //set customer information
            customer.CustomerID = Convert.ToInt32(txtID.Text);
            customer.CustomerName = txtName.Text;
            customer.CustomerPhone = txtPhone.Text;
            customer.CustomerEmail = txtEmail.Text;

            //set flight object flight ID information
            flight.FlightID = Convert.ToInt32(txtFlightID.Text);

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
            //---

        }
    }
}