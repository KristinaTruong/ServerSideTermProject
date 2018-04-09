﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceDescription.aspx.cs" Inherits="AirServiceProject.ServiceDescription" %>

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
            background-image: url("https://wallpaper.wiki/wp-content/uploads/2017/05/Abstract-grey-wallpaper-HD.png");
            background-size: cover;
            background-attachment: fixed;
        }

        form {
            opacity: 0.9;
        }

        td {
            vertical-align: top;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <h1 style="color: white;">AirService.asmx</h1>
        <div class="row">
            <div class="col-3">
                <button class="btn btn-light btn-lg btn-block" type="button" data-toggle="collapse" data-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">
                    WEB METHODS
                </button>
            </div>
            <div class="col">
                <div class="collapse" id="collapseExample">
                    <div class="card">
                        <div class="card-header">
                            <h5>GetFlights</h5>
                        </div>
                        <div class="card-body">

                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <b>Description</b>
                                        <p>
                                            This method accepts as input an AirCarrierID for the air carrier of their choice, and returns a 
                        DataSet containing records for available flights to an arrival city and state and from a departure city and state
                                        </p>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <b>Parameters (In Order)</b>

                                        <ol>
                                            <li>AirCarrierClass object - AirCarrierID<
                                            </li>
                                            <li>String - DepartureCity</li>
                                            <li>String - DepartureState (String)<ul>
                                                <li>Must be acronym of state (ex. PA for Pennsylvania)</li>
                                            </ul>
                                            </li>
                                            <li>String - ArrivalCity</li>
                                            <li>String - ArrivalState<ul>
                                                <li>Must be acronym of state (ex. PA for Pennsylvania)</li>
                                            </ul>
                                            </li>
                                        </ol>
                                    </div>
                                    <div class="col">
                                        <b>Dataset Returned (In Order)</b>

                                        <ol>
                                            <li>int - FlightID</li>
                                            <li>int - AirCarrierID</li>
                                            <li>String - AirCarrierName</li>
                                            <li>decimal - Price</li>
                                            <li>String - DepartureCity</li>
                                            <li>String - DepartureState</li>
                                            <li>String - DepartureTime</li>
                                            <li>String - ArrivalCity</li>
                                            <li>String - ArrivalState</li>
                                            <li>String - ArrivalTime</li>
                                            <li>int - Stops</li>
                                            <li>String - Class</li>
                                            <li>int - MaxSeats</li>
                                            <li>int - SeatsReserved</li>
                                        </ol>

                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <br />
                    <div class="card">
                        <div class="card-header">
                            <h5>FindFlights</h5>
                        </div>
                        <div class="card-body">
                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <b>Description</b>
                                        <p>
                                            This method accepts an object of the RequirementClass that contains information
                        about the search requirements the user is looking for and 
                         returns a DataSet containing records 
                        that meet the requirements. Both class and stops may be specified for this search, but at least one of these requirements must be
                                            specified for this method.
                        This method returns all flights regardless of the air carrier.
                                        </p>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <b>Parameters (In Order)</b>

                                        <ol>
                                            <li>RequirementClass object - requirements
                                            </li>
                                            <li>String - DepartureCity</li>
                                            <li>String - DepartureState<ul>
                                                <li>Must be acronym of state (ex. PA for Pennsylvania)</li>
                                            </ul>
                                            </li>
                                            <li>String - ArrivalCity</li>
                                            <li>String - ArrivalState<ul>
                                                <li>Must be acronym of state (ex. PA for Pennsylvania)</li>
                                            </ul>
                                            </li>
                                        </ol>
                                    </div>
                                    <div class="col">
                                        <b>Dataset Returned</b>

                                        <ol>
                                            <li>int - FlightID</li>
                                            <li>int - AirCarrierID</li>
                                            <li>String - AirCarrierName</li>
                                            <li>decimal - Price</li>
                                            <li>String - DepartureCity</li>
                                            <li>String - DepartureState</li>
                                            <li>String - DepartureTime</li>
                                            <li>String - ArrivalCity</li>
                                            <li>String - ArrivalState</li>
                                            <li>String - ArrivalTime</li>
                                            <li>int - Stops</li>
                                            <li>String - Class</li>
                                            <li>int - MaxSeats</li>
                                            <li>int - SeatsReserved</li>
                                        </ol>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="card">
                        <div class="card-header">
                            <h5>Reserve</h5>
                        </div>
                        <div class="card-body">
                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <b>Description</b>
                                        <p>
                                            This method accepts air carrier and flight information used to reserve a
                                     seat for a customer. The method updates the necessary tables to record the
                                     flight’s reservation. Customers that reserve a flight may or may not be from 
                                    the database, and will be added to the database if they are new.
                                        </p>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <b>Parameters (In Order)</b>
                                        <ol>
                                            <li>FlightClass object - flight</li>
                                            <li>CustomerClass object - customer</li>
                                            <li>String - TravelSiteID</li>
                                            <li>String - TravelSitePassword</li>
                                        </ol>
                                    </div>
                                    <div class="col">
                                        <b>Boolean Returned</b>

                                        <ol>
                                            <li>True - Reservation was successfully booked</li>
                                            <li>False - Reservation failed to be booked</li>
                                        </ol>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <br />
                    <div class="card">
                        <div class="card-header">
                            <h5>ReserveTwoWay</h5>
                        </div>
                        <div class="card-body">
                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <b>Description</b>
                                        <p>
                                            Similar to the Reserve method, but this method reserves a two-way trip. Two flight objects are needed.
                                        </p>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <b>Parameters (In Order)</b>
                                        <ol>
                                            <li>FlightClass object - firstFlight</li>
                                            <li>FlightClass object - secondFlight</li>
                                            <li>CustomerClass object - customer</li>
                                            <li>String - TravelSiteID</li>
                                            <li>String - TravelSitePassword</li>
                                        </ol>
                                    </div>
                                    <div class="col">
                                        <b>Boolean Returned</b>
                                        <ol>
                                            <li>True - Reservations were successfully booked</li>
                                            <li>False - Reservations failed to be booked</li>
                                        </ol>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <br />
                    <!-- TEMPLATE FOR EACH WEBMETHOD ------------------------------------------------------------------------------
            <div class="card">
                <div class="card-header">
                    <h5>WEB METHOD NAME</h5>
                </div>
                <div class="card-body">
                    <div class="container">
                        <div class="row">
                            <div class="col">
                                <b>Description</b>
                                <p>
                                    WEBMETHOD DESCRIPTION
                                </p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <b>Parameters (In Order)</b>
                                <ol>
                                    <li>PARAMETER TYPE - PARAMETER NAME (ex.String name)</li>
                                </ol>
                            </div>
                            <div class="col">
                                <b>Dataset Returned (In Order)</b>

                                <ol>
                                    <li>DATABASE FIELD DATATYPE - FIELD NAME (ex.String CustomerName)</li>
                                </ol>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <br />
            -------------------------------------------------------------------------------------------------------------->
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col"></div>
        </div>
        <div class="row">
            <div class="col-3">
                <button class="btn btn-light btn-lg btn-block" type="button" data-toggle="collapse" data-target="#collapseExample2" aria-expanded="false" aria-controls="collapseExample">
                    CLASSES
                </button>
            </div>
            <div class="col">
                <div class="collapse" id="collapseExample2">
                    <div class="card">
                        <div class="card-header">
                            <h5>AirCarrierClass</h5>
                        </div>
                        <div class="card-body">
                            <b>Properties (Get & Set)</b>
                            <ul>
                                <li>int - AirCarrierID
                                </li>
                                <li>String - AirCarrierName
                                </li>
                            </ul>
                        </div>
                    </div>
                    <br />
                    <div class="card">
                        <div class="card-header">
                            <h5>CustomerClass</h5>
                        </div>
                        <div class="card-body">
                            <b>Properties (Get & Set)</b>
                            <ul>
                                <li>int - CustomerID
                                </li>
                                <li>String - CustomerName</li>
                                <li>String - CustomerPhone</li>
                                <li>String - CustomerEmail</li>
                            </ul>
                        </div>
                    </div>
                    <br />
                    <div class="card">
                        <div class="card-header">
                            <h5>RequirementClass</h5>
                        </div>
                        <div class="card-body">
                            <b>Properties (Get & Set)</b>
                            <ul>
                                <li>String - requirementStops
                                </li>
                                <li>String - requirementClass</li>
                            </ul>
                        </div>
                    </div>
                    <br />
                    <div class="card">
                        <div class="card-header">
                            <h5>FlightClass</h5>
                        </div>
                        <div class="card-body">
                            <b>Properties (Get & Set)</b>
                            <ul>
                                <li>DATATYPE - PROPERTY NAME (ex.int - AirCarrierID)
                                </li>
                            </ul>
                        </div>
                    </div>
                    <br />
                    <!-- CLASS TEMPLATE --------------------------------------------------------------------------
                      <div class="card">
                        <div class="card-header">
                            <h5>CLASS NAME</h5>
                        </div>
                        <div class="card-body">
                            <b>Properties (Get & Set)</b>
                            <ul>
                                <li>DATATYPE - PROPERTY NAME (ex.int - AirCarrierID)
                                </li>
                            </ul>
                        </div>
                      </div><br />
                    ----------------------------------------------------------------------------------------->


                </div>
            </div>
        </div>
    </form>
</body>
</html>
