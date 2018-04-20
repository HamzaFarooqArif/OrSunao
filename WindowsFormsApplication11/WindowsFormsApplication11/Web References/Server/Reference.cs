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

namespace WindowsFormsApplication11.Server {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SRegisterUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback SLoginUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDataUsingDataContractOperationCompleted;
        
        private System.Threading.SendOrPostCallback SRegisterAdminOperationCompleted;
        
        private System.Threading.SendOrPostCallback SLoginAdminOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::WindowsFormsApplication11.Properties.Settings.Default.WindowsFormsApplication11_Server_Service1;
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
        public event SRegisterUserCompletedEventHandler SRegisterUserCompleted;
        
        /// <remarks/>
        public event SLoginUserCompletedEventHandler SLoginUserCompleted;
        
        /// <remarks/>
        public event GetDataCompletedEventHandler GetDataCompleted;
        
        /// <remarks/>
        public event GetDataUsingDataContractCompletedEventHandler GetDataUsingDataContractCompleted;
        
        /// <remarks/>
        public event SRegisterAdminCompletedEventHandler SRegisterAdminCompleted;
        
        /// <remarks/>
        public event SLoginAdminCompletedEventHandler SLoginAdminCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SRegisterUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SRegisterUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string firstname, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string lastname, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string contact, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string cnic, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string secretq, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string ans, out bool SRegisterUserResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool SRegisterUserResultSpecified) {
            object[] results = this.Invoke("SRegisterUser", new object[] {
                        firstname,
                        lastname,
                        password,
                        email,
                        contact,
                        cnic,
                        secretq,
                        ans});
            SRegisterUserResult = ((bool)(results[0]));
            SRegisterUserResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void SRegisterUserAsync(string firstname, string lastname, string password, string email, string contact, string cnic, string secretq, string ans) {
            this.SRegisterUserAsync(firstname, lastname, password, email, contact, cnic, secretq, ans, null);
        }
        
        /// <remarks/>
        public void SRegisterUserAsync(string firstname, string lastname, string password, string email, string contact, string cnic, string secretq, string ans, object userState) {
            if ((this.SRegisterUserOperationCompleted == null)) {
                this.SRegisterUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSRegisterUserOperationCompleted);
            }
            this.InvokeAsync("SRegisterUser", new object[] {
                        firstname,
                        lastname,
                        password,
                        email,
                        contact,
                        cnic,
                        secretq,
                        ans}, this.SRegisterUserOperationCompleted, userState);
        }
        
        private void OnSRegisterUserOperationCompleted(object arg) {
            if ((this.SRegisterUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SRegisterUserCompleted(this, new SRegisterUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SLoginUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SLoginUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, out bool SLoginUserResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool SLoginUserResultSpecified) {
            object[] results = this.Invoke("SLoginUser", new object[] {
                        email,
                        password});
            SLoginUserResult = ((bool)(results[0]));
            SLoginUserResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void SLoginUserAsync(string email, string password) {
            this.SLoginUserAsync(email, password, null);
        }
        
        /// <remarks/>
        public void SLoginUserAsync(string email, string password, object userState) {
            if ((this.SLoginUserOperationCompleted == null)) {
                this.SLoginUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSLoginUserOperationCompleted);
            }
            this.InvokeAsync("SLoginUser", new object[] {
                        email,
                        password}, this.SLoginUserOperationCompleted, userState);
        }
        
        private void OnSLoginUserOperationCompleted(object arg) {
            if ((this.SLoginUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SLoginUserCompleted(this, new SLoginUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetData(int value, [System.Xml.Serialization.XmlIgnoreAttribute()] bool valueSpecified) {
            object[] results = this.Invoke("GetData", new object[] {
                        value,
                        valueSpecified});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified) {
            this.GetDataAsync(value, valueSpecified, null);
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified, object userState) {
            if ((this.GetDataOperationCompleted == null)) {
                this.GetDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataOperationCompleted);
            }
            this.InvokeAsync("GetData", new object[] {
                        value,
                        valueSpecified}, this.GetDataOperationCompleted, userState);
        }
        
        private void OnGetDataOperationCompleted(object arg) {
            if ((this.GetDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetDataUsingDataContract", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CompositeType GetDataUsingDataContract([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CompositeType composite) {
            object[] results = this.Invoke("GetDataUsingDataContract", new object[] {
                        composite});
            return ((CompositeType)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite) {
            this.GetDataUsingDataContractAsync(composite, null);
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite, object userState) {
            if ((this.GetDataUsingDataContractOperationCompleted == null)) {
                this.GetDataUsingDataContractOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractOperationCompleted);
            }
            this.InvokeAsync("GetDataUsingDataContract", new object[] {
                        composite}, this.GetDataUsingDataContractOperationCompleted, userState);
        }
        
        private void OnGetDataUsingDataContractOperationCompleted(object arg) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SRegisterAdmin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SRegisterAdmin([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string UserFirstName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string UserLastName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Password, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string CNIC, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Contact, out bool SRegisterAdminResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool SRegisterAdminResultSpecified) {
            object[] results = this.Invoke("SRegisterAdmin", new object[] {
                        UserFirstName,
                        UserLastName,
                        Password,
                        Email,
                        CNIC,
                        Contact});
            SRegisterAdminResult = ((bool)(results[0]));
            SRegisterAdminResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void SRegisterAdminAsync(string UserFirstName, string UserLastName, string Password, string Email, string CNIC, string Contact) {
            this.SRegisterAdminAsync(UserFirstName, UserLastName, Password, Email, CNIC, Contact, null);
        }
        
        /// <remarks/>
        public void SRegisterAdminAsync(string UserFirstName, string UserLastName, string Password, string Email, string CNIC, string Contact, object userState) {
            if ((this.SRegisterAdminOperationCompleted == null)) {
                this.SRegisterAdminOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSRegisterAdminOperationCompleted);
            }
            this.InvokeAsync("SRegisterAdmin", new object[] {
                        UserFirstName,
                        UserLastName,
                        Password,
                        Email,
                        CNIC,
                        Contact}, this.SRegisterAdminOperationCompleted, userState);
        }
        
        private void OnSRegisterAdminOperationCompleted(object arg) {
            if ((this.SRegisterAdminCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SRegisterAdminCompleted(this, new SRegisterAdminCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SLoginAdmin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SLoginAdmin([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Password, out bool SLoginAdminResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool SLoginAdminResultSpecified) {
            object[] results = this.Invoke("SLoginAdmin", new object[] {
                        Email,
                        Password});
            SLoginAdminResult = ((bool)(results[0]));
            SLoginAdminResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void SLoginAdminAsync(string Email, string Password) {
            this.SLoginAdminAsync(Email, Password, null);
        }
        
        /// <remarks/>
        public void SLoginAdminAsync(string Email, string Password, object userState) {
            if ((this.SLoginAdminOperationCompleted == null)) {
                this.SLoginAdminOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSLoginAdminOperationCompleted);
            }
            this.InvokeAsync("SLoginAdmin", new object[] {
                        Email,
                        Password}, this.SLoginAdminOperationCompleted, userState);
        }
        
        private void OnSLoginAdminOperationCompleted(object arg) {
            if ((this.SLoginAdminCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SLoginAdminCompleted(this, new SLoginAdminCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/OrSunao")]
    public partial class CompositeType {
        
        private bool boolValueField;
        
        private bool boolValueFieldSpecified;
        
        private string stringValueField;
        
        /// <remarks/>
        public bool BoolValue {
            get {
                return this.boolValueField;
            }
            set {
                this.boolValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BoolValueSpecified {
            get {
                return this.boolValueFieldSpecified;
            }
            set {
                this.boolValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StringValue {
            get {
                return this.stringValueField;
            }
            set {
                this.stringValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SRegisterUserCompletedEventHandler(object sender, SRegisterUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SRegisterUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SRegisterUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool SRegisterUserResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool SRegisterUserResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SLoginUserCompletedEventHandler(object sender, SLoginUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SLoginUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SLoginUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool SLoginUserResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool SLoginUserResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetDataCompletedEventHandler(object sender, GetDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetDataUsingDataContractCompletedEventHandler(object sender, GetDataUsingDataContractCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CompositeType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CompositeType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SRegisterAdminCompletedEventHandler(object sender, SRegisterAdminCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SRegisterAdminCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SRegisterAdminCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool SRegisterAdminResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool SRegisterAdminResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SLoginAdminCompletedEventHandler(object sender, SLoginAdminCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SLoginAdminCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SLoginAdminCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool SLoginAdminResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool SLoginAdminResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591