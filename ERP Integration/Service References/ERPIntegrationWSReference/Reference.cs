﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_Integration.ERPIntegrationWSReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://brokerapplication.org/", ConfigurationName="ERPIntegrationWSReference.ERPIntegrationWSSoap")]
    public interface ERPIntegrationWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://brokerapplication.org/InsertEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void InsertEmployee(string no, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://brokerapplication.org/UpdateEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateEmployee(string no, string name, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://brokerapplication.org/DeleteEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void DeleteEmployee(string no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://brokerapplication.org/SearchEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SearchEmployee(string searchString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://brokerapplication.org/GetEmployeeAndMetaData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetEmployeeAndMetaData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://brokerapplication.org/GetEmployeeAndRelatives", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetEmployeeAndRelatives();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://brokerapplication.org/GetSickEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSickEmployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://brokerapplication.org/GetMostSickEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetMostSickEmployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://brokerapplication.org/GetAllKeys", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ERP_Integration.ERPIntegrationWSReference.SysObject[] GetAllKeys();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://brokerapplication.org/")]
    public partial class SysObject : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idField;
        
        private string xtypeField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Xtype {
            get {
                return this.xtypeField;
            }
            set {
                this.xtypeField = value;
                this.RaisePropertyChanged("Xtype");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ERPIntegrationWSSoapChannel : ERP_Integration.ERPIntegrationWSReference.ERPIntegrationWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ERPIntegrationWSSoapClient : System.ServiceModel.ClientBase<ERP_Integration.ERPIntegrationWSReference.ERPIntegrationWSSoap>, ERP_Integration.ERPIntegrationWSReference.ERPIntegrationWSSoap {
        
        public ERPIntegrationWSSoapClient() {
        }
        
        public ERPIntegrationWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ERPIntegrationWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ERPIntegrationWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ERPIntegrationWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertEmployee(string no, string name) {
            base.Channel.InsertEmployee(no, name);
        }
        
        public void UpdateEmployee(string no, string name, string lastName) {
            base.Channel.UpdateEmployee(no, name, lastName);
        }
        
        public void DeleteEmployee(string no) {
            base.Channel.DeleteEmployee(no);
        }
        
        public void SearchEmployee(string searchString) {
            base.Channel.SearchEmployee(searchString);
        }
        
        public System.Data.DataSet GetEmployeeAndMetaData() {
            return base.Channel.GetEmployeeAndMetaData();
        }
        
        public System.Data.DataSet GetEmployeeAndRelatives() {
            return base.Channel.GetEmployeeAndRelatives();
        }
        
        public System.Data.DataSet GetSickEmployee() {
            return base.Channel.GetSickEmployee();
        }
        
        public System.Data.DataSet GetMostSickEmployee() {
            return base.Channel.GetMostSickEmployee();
        }
        
        public ERP_Integration.ERPIntegrationWSReference.SysObject[] GetAllKeys() {
            return base.Channel.GetAllKeys();
        }
    }
}
