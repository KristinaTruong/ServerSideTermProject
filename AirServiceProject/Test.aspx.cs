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
        public AirServiceProject.AirService pxy = new AirServiceProject.AirService();
        protected void Page_Load(object sender, EventArgs e)
		{
            DataSet startDS = null;
            gvFlights.DataSource = startDS;
            gvFlights.DataBind();
		}
        /*
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String depCity = (txtDepCity.Text.Trim() != null) ? txtDepCity.Text.Trim() : null;
            Boolean depCityB = (txtDepCity.Text.Trim() != null) ? true : false;

            String depState = (txtDepState.Text.Trim() != null) ? txtDepState.Text.Trim() : null;
            Boolean depStateB = (txtDepState.Text.Trim() != null) ? true : false;

            String arrivCity = (txtArrCity.Text.Trim() != null) ? txtArrCity.Text.Trim() : null;
            Boolean arrivCityB = (txtArrCity.Text.Trim() != null) ? true : false;

            String arrivState = (txtArrState.Text.Trim() != null) ? txtArrState.Text.Trim() : null;
            Boolean arrivStateB = (txtArrState.Text.Trim() != null) ? true : false;

            int numberOfTrips = (RbTwo.Checked) ? 2 : 1;

            int numberOfStops = (txtStops.Text.Trim() != null) ? (Convert.ToInt32(txtStops.Text.Trim())) : -1;
            Boolean numberOfStopsB = (numberOfStops != -1) ? true : false;

            String classReq = null;
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
            Boolean classReqB = (classReq != null) ? true : false; 

            String airCarrier = (txtAirCarrier.Text.Trim() != null) ? txtAirCarrier.Text.Trim() : null;
            Boolean airCarrierB = (airCarrier != null) ? true : false;

            AirServiceProject.AirCarrierClass airCarrierID = new AirServiceProject.AirCarrierClass();
            airCarrierID.AirCarrierID = airCarrier;

            AirServiceProject.RequirementClass requirements = new AirServiceProject.RequirementClass();
            requirements.requirementStops = numberOfStops;
            requirements.requirementClass = classReq;

            AirServiceProject.CustomerClass customer = new AirServiceProject.CustomerClass();
            customer.CustomerID = txtID.Text;
            customer.CustomerName = txtName.Text;
            customer.CustomerPhone = txtPhone.Text;
            customer.CustomerEmail = txtEmail.Text;


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
                gvFlights.DataSource = pxy.GetAirCarriers()
            }

            else if
                (depCityB &&
                depStateB &&
                arrivCityB &&
                arrivStateB &&
                (!numberOfStopsB &&
                !classReqB) &&
                !airCarrierB
                )
            {

            }

            else if //find flights
                (depCityB &&
                depStateB &&
                arrivCityB &&
                arrivStateB &&
                (!numberOfStopsB &&
                !classReqB) &&
                !airCarrierB
                )
            {

            }

            else if //filter flights by carrier
                (depCityB &&
                depStateB &&
                arrivCityB &&
                arrivStateB &&
                (!numberOfStopsB &&
                !classReqB) &&
                !airCarrierB
                )
            {

            }

            else if //reserve
                (depCityB &&
                depStateB &&
                arrivCityB &&
                arrivStateB &&
                (!numberOfStopsB &&
                !classReqB) &&
                !airCarrierB
                )
            {

            }

            else
            {

            }
        }*/
    }
}