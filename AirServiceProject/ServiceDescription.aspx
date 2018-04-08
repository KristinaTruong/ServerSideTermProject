<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceDescription.aspx.cs" Inherits="AirServiceProject.ServiceDescription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <style>
        body {
            padding: 50px;
            font-family: Arial, Helvetica, sans-serif,Calibri;
            font-size: 15px;
        }

        form {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="card">
                <div class="card-header">
                    <h5>GetFlights</h5>
                </div>
                <div class="card-body">

                    <b>Description</b>
                    <p>
                        This method accepts as input an AirCarrierID for the air carrier of their choice, and returns a 
                        DataSet containing records for available flights to an arrival city and state and from a departure city and state
                    </p>
                    <b>Parameters (In Order)</b>

                    <ul>
                        <li>AirCarrierClass AirCarrierID (object)<ul>
                            <li>AirCarrierClass Properties (getters and setters for each)<ul>
                                <li>AirCarrierID (int)</li>
                                <li>AirCarrierName (String)</li>
                            </ul>
                            </li>
                        </ul>
                        </li>
                        <li>DepartureCity (String)</li>
                        <li>DepartureState (String)<ul>
                            <li>Must be acronym of state (ex. PA for Pennsylvania)</li>
                        </ul>
                        </li>
                        <li>ArrivalCity (String)</li>
                        <li>ArrivalState (String)<ul>
                            <li>Must be acronym of state (ex. PA for Pennsylvania)</li>
                        </ul>
                        </li>
                    </ul>

                    <b>Dataset Returned (In Order)</b>

                    <ul>
                        <li>
                            FlightID</li>
                        <li>
                            AirCarrierID</li>
                        <li>
                            AirCarrierName</li>
                        <li>
                            Price</li>
                        <li>
                            DepartureCity</li>
                        <li>
                            DepartureState</li>
                        <li>
                            DepartureTime</li>
                        <li>
                            ArrivalCity</li>
                        <li>
                            ArrivalState</li>
                        <li>
                            ArrivalTime</li>
                        <li>
                            Stops</li>
                        <li>
                            Class</li>
                        <li>
                            MaxSeats</li>
                        <li>
                            SeatsReserved
                        </li>
                    </ul>
                </div>
            </div>
            <br />
            <div class="card">
                <div class="card-header">
                    <h5>FindFlights</h5>
                </div>
                <div class="card-body">

                    <b>Description</b>
                    <p>
                        This method accepts an object of the RequirementClass that contains information
                        about the search requirements the user is looking for and 
                         returns a DataSet containing records 
                        that meet the requirements. 
                        This method returns all flights regardless of the air carrier.
                    </p>
                    <b>Parameters (In Order)</b>

                    <ul>
                        <li>RequirementClass requirements (object)<ul>
                            <li>RequirementClass Properties (getters and setters for each)<ul>
                                <li>requirementStops (int)</li>
                                <li>requirementClass (String)</li>
                            </ul>
                            </li>
                        </ul>
                        </li>
                        <li>DepartureCity (String)</li>
                        <li>DepartureState (String)<ul>
                            <li>Must be acronym of state (ex. PA for Pennsylvania)</li>
                        </ul>
                        </li>
                        <li>ArrivalCity (String)</li>
                        <li>ArrivalState (String)<ul>
                            <li>Must be acronym of state (ex. PA for Pennsylvania)</li>
                        </ul>
                        </li>
                    </ul>

                    <b>Dataset Returned</b>

                    <ul>
                        <li>
                            FlightID</li>
                        <li>
                            AirCarrierID</li>
                        <li>
                            AirCarrierName</li>
                        <li>
                            Price</li>
                        <li>
                            DepartureCity</li>
                        <li>
                            DepartureState</li>
                        <li>
                            DepartureTime</li>
                        <li>
                            ArrivalCity</li>
                        <li>
                            ArrivalState</li>
                        <li>
                            ArrivalTime</li>
                        <li>
                            Stops</li>
                        <li>
                            Class</li>
                        <li>
                            MaxSeats</li>
                        <li>
                            SeatsReserved</li>
                    </ul>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
