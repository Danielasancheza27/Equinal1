﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace LogicaNegocio.wsadmin {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WsAdminEmpresasSoap", Namespace="http://tempuri.org/")]
    public partial class WsAdminEmpresas : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CrearEmpresaOperationCompleted;
        
        private System.Threading.SendOrPostCallback TraerEmpresaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WsAdminEmpresas() {
            this.Url = global::LogicaNegocio.Properties.Settings.Default.LogicaNegocio_wsadmin_WsAdminEmpresas;
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
        public event CrearEmpresaCompletedEventHandler CrearEmpresaCompleted;
        
        /// <remarks/>
        public event TraerEmpresaCompletedEventHandler TraerEmpresaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CrearEmpresa", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CrearEmpresa(string nombre, string nit, string replegal, string direccion, string ciudad, string correo, string telefono, string estado, string instancia) {
            object[] results = this.Invoke("CrearEmpresa", new object[] {
                        nombre,
                        nit,
                        replegal,
                        direccion,
                        ciudad,
                        correo,
                        telefono,
                        estado,
                        instancia});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CrearEmpresaAsync(string nombre, string nit, string replegal, string direccion, string ciudad, string correo, string telefono, string estado) {
            this.CrearEmpresaAsync(nombre, nit, replegal, direccion, ciudad, correo, telefono, estado, null);
        }
        
        /// <remarks/>
        public void CrearEmpresaAsync(string nombre, string nit, string replegal, string direccion, string ciudad, string correo, string telefono, string estado, object userState) {
            if ((this.CrearEmpresaOperationCompleted == null)) {
                this.CrearEmpresaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCrearEmpresaOperationCompleted);
            }
            this.InvokeAsync("CrearEmpresa", new object[] {
                        nombre,
                        nit,
                        replegal,
                        direccion,
                        ciudad,
                        correo,
                        telefono,
                        estado}, this.CrearEmpresaOperationCompleted, userState);
        }
        
        private void OnCrearEmpresaOperationCompleted(object arg) {
            if ((this.CrearEmpresaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CrearEmpresaCompleted(this, new CrearEmpresaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/TraerEmpresa", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable TraerEmpresa() {
            object[] results = this.Invoke("TraerEmpresa", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void TraerEmpresaAsync() {
            this.TraerEmpresaAsync(null);
        }
        
        /// <remarks/>
        public void TraerEmpresaAsync(object userState) {
            if ((this.TraerEmpresaOperationCompleted == null)) {
                this.TraerEmpresaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTraerEmpresaOperationCompleted);
            }
            this.InvokeAsync("TraerEmpresa", new object[0], this.TraerEmpresaOperationCompleted, userState);
        }
        
        private void OnTraerEmpresaOperationCompleted(object arg) {
            if ((this.TraerEmpresaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TraerEmpresaCompleted(this, new TraerEmpresaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void CrearEmpresaCompletedEventHandler(object sender, CrearEmpresaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CrearEmpresaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CrearEmpresaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void TraerEmpresaCompletedEventHandler(object sender, TraerEmpresaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TraerEmpresaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TraerEmpresaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591