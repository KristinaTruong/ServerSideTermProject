﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace AirServiceProject.AirServiceWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AirServiceSoap", Namespace="http://tempuri.org/")]
    public partial class AirService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetFlightsOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindFlightsOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReserveOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAirCarriersOperationCompleted;
        
        private System.Threading.SendOrPostCallback FilterFlightsByCarrierOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AirService() {
            this.Url = global::AirServiceProject.Properties.Settings.Default.AirServiceProject_AirServiceWS_AirService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetFlightsCompletedEventHandler GetFlightsCompleted;
        
        /// <remarks/>
        public event FindFlightsCompletedEventHandler FindFlightsCompleted;
        
        /// <remarks/>
        public event ReserveCompletedEventHandler ReserveCompleted;
        
        /// <remarks/>
        public event GetAirCarriersCompletedEventHandler GetAirCarriersCompleted;
        
        /// <remarks/>
        public event FilterFlightsByCarrierCompletedEventHandler FilterFlightsByCarrierCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetFlights", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetFlights(AirCarrierClass AirCarrierID, string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState) {
            object[] results = this.Invoke("GetFlights", new object[] {
                        AirCarrierID,
                        DepartureCity,
                        DepartureState,
                        ArrivalCity,
                        ArrivalState});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetFlightsAsync(AirCarrierClass AirCarrierID, string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState) {
            this.GetFlightsAsync(AirCarrierID, DepartureCity, DepartureState, ArrivalCity, ArrivalState, null);
        }
        
        /// <remarks/>
        public void GetFlightsAsync(AirCarrierClass AirCarrierID, string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState, object userState) {
            if ((this.GetFlightsOperationCompleted == null)) {
                this.GetFlightsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFlightsOperationCompleted);
            }
            this.InvokeAsync("GetFlights", new object[] {
                        AirCarrierID,
                        DepartureCity,
                        DepartureState,
                        ArrivalCity,
                        ArrivalState}, this.GetFlightsOperationCompleted, userState);
        }
        
        private void OnGetFlightsOperationCompleted(object arg) {
            if ((this.GetFlightsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFlightsCompleted(this, new GetFlightsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindFlights", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet FindFlights(RequirementClass requirements, string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState) {
            object[] results = this.Invoke("FindFlights", new object[] {
                        requirements,
                        DepartureCity,
                        DepartureState,
                        ArrivalCity,
                        ArrivalState});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void FindFlightsAsync(RequirementClass requirements, string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState) {
            this.FindFlightsAsync(requirements, DepartureCity, DepartureState, ArrivalCity, ArrivalState, null);
        }
        
        /// <remarks/>
        public void FindFlightsAsync(RequirementClass requirements, string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState, object userState) {
            if ((this.FindFlightsOperationCompleted == null)) {
                this.FindFlightsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindFlightsOperationCompleted);
            }
            this.InvokeAsync("FindFlights", new object[] {
                        requirements,
                        DepartureCity,
                        DepartureState,
                        ArrivalCity,
                        ArrivalState}, this.FindFlightsOperationCompleted, userState);
        }
        
        private void OnFindFlightsOperationCompleted(object arg) {
            if ((this.FindFlightsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindFlightsCompleted(this, new FindFlightsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Reserve", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Reserve(AirCarrierClass AirCarrierID, FlightClass flight, CustomerClass customer, string TravelSiteID, string TravelSitePassword) {
            object[] results = this.Invoke("Reserve", new object[] {
                        AirCarrierID,
                        flight,
                        customer,
                        TravelSiteID,
                        TravelSitePassword});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ReserveAsync(AirCarrierClass AirCarrierID, FlightClass flight, CustomerClass customer, string TravelSiteID, string TravelSitePassword) {
            this.ReserveAsync(AirCarrierID, flight, customer, TravelSiteID, TravelSitePassword, null);
        }
        
        /// <remarks/>
        public void ReserveAsync(AirCarrierClass AirCarrierID, FlightClass flight, CustomerClass customer, string TravelSiteID, string TravelSitePassword, object userState) {
            if ((this.ReserveOperationCompleted == null)) {
                this.ReserveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReserveOperationCompleted);
            }
            this.InvokeAsync("Reserve", new object[] {
                        AirCarrierID,
                        flight,
                        customer,
                        TravelSiteID,
                        TravelSitePassword}, this.ReserveOperationCompleted, userState);
        }
        
        private void OnReserveOperationCompleted(object arg) {
            if ((this.ReserveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReserveCompleted(this, new ReserveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAirCarriers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetAirCarriers(string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState) {
            object[] results = this.Invoke("GetAirCarriers", new object[] {
                        DepartureCity,
                        DepartureState,
                        ArrivalCity,
                        ArrivalState});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetAirCarriersAsync(string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState) {
            this.GetAirCarriersAsync(DepartureCity, DepartureState, ArrivalCity, ArrivalState, null);
        }
        
        /// <remarks/>
        public void GetAirCarriersAsync(string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState, object userState) {
            if ((this.GetAirCarriersOperationCompleted == null)) {
                this.GetAirCarriersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAirCarriersOperationCompleted);
            }
            this.InvokeAsync("GetAirCarriers", new object[] {
                        DepartureCity,
                        DepartureState,
                        ArrivalCity,
                        ArrivalState}, this.GetAirCarriersOperationCompleted, userState);
        }
        
        private void OnGetAirCarriersOperationCompleted(object arg) {
            if ((this.GetAirCarriersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAirCarriersCompleted(this, new GetAirCarriersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FilterFlightsByCarrier", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet FilterFlightsByCarrier(AirCarrierClass AirCarrierID, RequirementClass requirements, string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState) {
            object[] results = this.Invoke("FilterFlightsByCarrier", new object[] {
                        AirCarrierID,
                        requirements,
                        DepartureCity,
                        DepartureState,
                        ArrivalCity,
                        ArrivalState});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void FilterFlightsByCarrierAsync(AirCarrierClass AirCarrierID, RequirementClass requirements, string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState) {
            this.FilterFlightsByCarrierAsync(AirCarrierID, requirements, DepartureCity, DepartureState, ArrivalCity, ArrivalState, null);
        }
        
        /// <remarks/>
        public void FilterFlightsByCarrierAsync(AirCarrierClass AirCarrierID, RequirementClass requirements, string DepartureCity, string DepartureState, string ArrivalCity, string ArrivalState, object userState) {
            if ((this.FilterFlightsByCarrierOperationCompleted == null)) {
                this.FilterFlightsByCarrierOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFilterFlightsByCarrierOperationCompleted);
            }
            this.InvokeAsync("FilterFlightsByCarrier", new object[] {
                        AirCarrierID,
                        requirements,
                        DepartureCity,
                        DepartureState,
                        ArrivalCity,
                        ArrivalState}, this.FilterFlightsByCarrierOperationCompleted, userState);
        }
        
        private void OnFilterFlightsByCarrierOperationCompleted(object arg) {
            if ((this.FilterFlightsByCarrierCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FilterFlightsByCarrierCompleted(this, new FilterFlightsByCarrierCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AirCarrierClass {
        
        private int airCarrierIDField;
        
        private string airCarrierNameField;
        
        /// <remarks/>
        public int AirCarrierID {
            get {
                return this.airCarrierIDField;
            }
            set {
                this.airCarrierIDField = value;
            }
        }
        
        /// <remarks/>
        public string AirCarrierName {
            get {
                return this.airCarrierNameField;
            }
            set {
                this.airCarrierNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CustomerClass {
        
        private int customerIDField;
        
        private string customerNameField;
        
        private string customerPhoneField;
        
        private string customerEmailField;
        
        /// <remarks/>
        public int CustomerID {
            get {
                return this.customerIDField;
            }
            set {
                this.customerIDField = value;
            }
        }
        
        /// <remarks/>
        public string CustomerName {
            get {
                return this.customerNameField;
            }
            set {
                this.customerNameField = value;
            }
        }
        
        /// <remarks/>
        public string CustomerPhone {
            get {
                return this.customerPhoneField;
            }
            set {
                this.customerPhoneField = value;
            }
        }
        
        /// <remarks/>
        public string CustomerEmail {
            get {
                return this.customerEmailField;
            }
            set {
                this.customerEmailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class FlightClass {
        
        private int flightIDField;
        
        private int airCarrierIDField;
        
        private decimal priceField;
        
        private string departureCityField;
        
        private string departureStateField;
        
        private string departureDateField;
        
        private string departureTimeField;
        
        private string arrivalCityField;
        
        private string arrivalStateField;
        
        private string arrivalDateField;
        
        private string arrivalTimeField;
        
        private int stopsField;
        
        private string classField;
        
        private int maxSeatsField;
        
        private int seatsReservedField;
        
        /// <remarks/>
        public int FlightID {
            get {
                return this.flightIDField;
            }
            set {
                this.flightIDField = value;
            }
        }
        
        /// <remarks/>
        public int AirCarrierID {
            get {
                return this.airCarrierIDField;
            }
            set {
                this.airCarrierIDField = value;
            }
        }
        
        /// <remarks/>
        public decimal Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public string DepartureCity {
            get {
                return this.departureCityField;
            }
            set {
                this.departureCityField = value;
            }
        }
        
        /// <remarks/>
        public string DepartureState {
            get {
                return this.departureStateField;
            }
            set {
                this.departureStateField = value;
            }
        }
        
        /// <remarks/>
        public string DepartureDate {
            get {
                return this.departureDateField;
            }
            set {
                this.departureDateField = value;
            }
        }
        
        /// <remarks/>
        public string DepartureTime {
            get {
                return this.departureTimeField;
            }
            set {
                this.departureTimeField = value;
            }
        }
        
        /// <remarks/>
        public string ArrivalCity {
            get {
                return this.arrivalCityField;
            }
            set {
                this.arrivalCityField = value;
            }
        }
        
        /// <remarks/>
        public string ArrivalState {
            get {
                return this.arrivalStateField;
            }
            set {
                this.arrivalStateField = value;
            }
        }
        
        /// <remarks/>
        public string ArrivalDate {
            get {
                return this.arrivalDateField;
            }
            set {
                this.arrivalDateField = value;
            }
        }
        
        /// <remarks/>
        public string ArrivalTime {
            get {
                return this.arrivalTimeField;
            }
            set {
                this.arrivalTimeField = value;
            }
        }
        
        /// <remarks/>
        public int Stops {
            get {
                return this.stopsField;
            }
            set {
                this.stopsField = value;
            }
        }
        
        /// <remarks/>
        public string Class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        public int MaxSeats {
            get {
                return this.maxSeatsField;
            }
            set {
                this.maxSeatsField = value;
            }
        }
        
        /// <remarks/>
        public int SeatsReserved {
            get {
                return this.seatsReservedField;
            }
            set {
                this.seatsReservedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RequirementClass {
        
        private string requirementStopsField;
        
        private string requirementClassField;
        
        /// <remarks/>
        public string requirementStops {
            get {
                return this.requirementStopsField;
            }
            set {
                this.requirementStopsField = value;
            }
        }
        
        /// <remarks/>
        public string requirementClass {
            get {
                return this.requirementClassField;
            }
            set {
                this.requirementClassField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetFlightsCompletedEventHandler(object sender, GetFlightsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFlightsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFlightsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void FindFlightsCompletedEventHandler(object sender, FindFlightsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindFlightsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindFlightsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void ReserveCompletedEventHandler(object sender, ReserveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReserveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReserveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetAirCarriersCompletedEventHandler(object sender, GetAirCarriersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAirCarriersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAirCarriersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void FilterFlightsByCarrierCompletedEventHandler(object sender, FilterFlightsByCarrierCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FilterFlightsByCarrierCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FilterFlightsByCarrierCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591