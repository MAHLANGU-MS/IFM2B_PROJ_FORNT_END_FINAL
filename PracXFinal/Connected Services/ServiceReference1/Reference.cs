﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracXFinal.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/TeamweDev_GP_Service")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserType {
            get {
                return this.UserTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.UserTypeField, value) != true)) {
                    this.UserTypeField = value;
                    this.RaisePropertyChanged("UserType");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/TeamweDev_GP_Service")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> PrOldPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PrQuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PrRatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrStatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrCategory {
            get {
                return this.PrCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.PrCategoryField, value) != true)) {
                    this.PrCategoryField = value;
                    this.RaisePropertyChanged("PrCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrDescription {
            get {
                return this.PrDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.PrDescriptionField, value) != true)) {
                    this.PrDescriptionField = value;
                    this.RaisePropertyChanged("PrDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrImage {
            get {
                return this.PrImageField;
            }
            set {
                if ((object.ReferenceEquals(this.PrImageField, value) != true)) {
                    this.PrImageField = value;
                    this.RaisePropertyChanged("PrImage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrName {
            get {
                return this.PrNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PrNameField, value) != true)) {
                    this.PrNameField = value;
                    this.RaisePropertyChanged("PrName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> PrOldPrice {
            get {
                return this.PrOldPriceField;
            }
            set {
                if ((this.PrOldPriceField.Equals(value) != true)) {
                    this.PrOldPriceField = value;
                    this.RaisePropertyChanged("PrOldPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PrPrice {
            get {
                return this.PrPriceField;
            }
            set {
                if ((this.PrPriceField.Equals(value) != true)) {
                    this.PrPriceField = value;
                    this.RaisePropertyChanged("PrPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PrQuantity {
            get {
                return this.PrQuantityField;
            }
            set {
                if ((this.PrQuantityField.Equals(value) != true)) {
                    this.PrQuantityField = value;
                    this.RaisePropertyChanged("PrQuantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PrRating {
            get {
                return this.PrRatingField;
            }
            set {
                if ((this.PrRatingField.Equals(value) != true)) {
                    this.PrRatingField = value;
                    this.RaisePropertyChanged("PrRating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrStatus {
            get {
                return this.PrStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.PrStatusField, value) != true)) {
                    this.PrStatusField = value;
                    this.RaisePropertyChanged("PrStatus");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        PracXFinal.ServiceReference1.User Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<PracXFinal.ServiceReference1.User> LoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/register", ReplyAction="http://tempuri.org/IService1/registerResponse")]
        int register(PracXFinal.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/register", ReplyAction="http://tempuri.org/IService1/registerResponse")]
        System.Threading.Tasks.Task<int> registerAsync(PracXFinal.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllProducts", ReplyAction="http://tempuri.org/IService1/getAllProductsResponse")]
        PracXFinal.ServiceReference1.Product[] getAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllProducts", ReplyAction="http://tempuri.org/IService1/getAllProductsResponse")]
        System.Threading.Tasks.Task<PracXFinal.ServiceReference1.Product[]> getAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getProduct", ReplyAction="http://tempuri.org/IService1/getProductResponse")]
        PracXFinal.ServiceReference1.Product getProduct(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getProduct", ReplyAction="http://tempuri.org/IService1/getProductResponse")]
        System.Threading.Tasks.Task<PracXFinal.ServiceReference1.Product> getProductAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : PracXFinal.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<PracXFinal.ServiceReference1.IService1>, PracXFinal.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PracXFinal.ServiceReference1.User Login(string email, string password) {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<PracXFinal.ServiceReference1.User> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
        
        public int register(PracXFinal.ServiceReference1.User user) {
            return base.Channel.register(user);
        }
        
        public System.Threading.Tasks.Task<int> registerAsync(PracXFinal.ServiceReference1.User user) {
            return base.Channel.registerAsync(user);
        }
        
        public PracXFinal.ServiceReference1.Product[] getAllProducts() {
            return base.Channel.getAllProducts();
        }
        
        public System.Threading.Tasks.Task<PracXFinal.ServiceReference1.Product[]> getAllProductsAsync() {
            return base.Channel.getAllProductsAsync();
        }
        
        public PracXFinal.ServiceReference1.Product getProduct(int ID) {
            return base.Channel.getProduct(ID);
        }
        
        public System.Threading.Tasks.Task<PracXFinal.ServiceReference1.Product> getProductAsync(int ID) {
            return base.Channel.getProductAsync(ID);
        }
    }
}