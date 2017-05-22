﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HBSISLibraryWeb.HBSISLibraryServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/HBSISLibraryWCF.ServiceEntities")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HBSISLibraryWeb.HBSISLibraryServiceReference.Author[] AuthorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HBSISLibraryWeb.HBSISLibraryServiceReference.Publisher PublisherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PublisherIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public HBSISLibraryWeb.HBSISLibraryServiceReference.Author[] Authors {
            get {
                return this.AuthorsField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorsField, value) != true)) {
                    this.AuthorsField = value;
                    this.RaisePropertyChanged("Authors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pages {
            get {
                return this.PagesField;
            }
            set {
                if ((this.PagesField.Equals(value) != true)) {
                    this.PagesField = value;
                    this.RaisePropertyChanged("Pages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HBSISLibraryWeb.HBSISLibraryServiceReference.Publisher Publisher {
            get {
                return this.PublisherField;
            }
            set {
                if ((object.ReferenceEquals(this.PublisherField, value) != true)) {
                    this.PublisherField = value;
                    this.RaisePropertyChanged("Publisher");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PublisherID {
            get {
                return this.PublisherIDField;
            }
            set {
                if ((this.PublisherIDField.Equals(value) != true)) {
                    this.PublisherIDField = value;
                    this.RaisePropertyChanged("PublisherID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Publisher", Namespace="http://schemas.datacontract.org/2004/07/HBSISLibraryWCF.ServiceEntities")]
    [System.SerializableAttribute()]
    public partial class Publisher : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PublisherNameField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PublisherName {
            get {
                return this.PublisherNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PublisherNameField, value) != true)) {
                    this.PublisherNameField = value;
                    this.RaisePropertyChanged("PublisherName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Author", Namespace="http://schemas.datacontract.org/2004/07/HBSISLibraryWCF.ServiceEntities")]
    [System.SerializableAttribute()]
    public partial class Author : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HBSISLibraryWeb.HBSISLibraryServiceReference.Book[] BooksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public HBSISLibraryWeb.HBSISLibraryServiceReference.Book[] Books {
            get {
                return this.BooksField;
            }
            set {
                if ((object.ReferenceEquals(this.BooksField, value) != true)) {
                    this.BooksField = value;
                    this.RaisePropertyChanged("Books");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HBSISLibraryServiceReference.IHBSISLibraryService")]
    public interface IHBSISLibraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/FindAllBooks", ReplyAction="http://tempuri.org/IHBSISLibraryService/FindAllBooksResponse")]
        HBSISLibraryWeb.HBSISLibraryServiceReference.Book[] FindAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/FindAllBooks", ReplyAction="http://tempuri.org/IHBSISLibraryService/FindAllBooksResponse")]
        System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Book[]> FindAllBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/FindBookById", ReplyAction="http://tempuri.org/IHBSISLibraryService/FindBookByIdResponse")]
        HBSISLibraryWeb.HBSISLibraryServiceReference.Book FindBookById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/FindBookById", ReplyAction="http://tempuri.org/IHBSISLibraryService/FindBookByIdResponse")]
        System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Book> FindBookByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/InsertBook", ReplyAction="http://tempuri.org/IHBSISLibraryService/InsertBookResponse")]
        HBSISLibraryWeb.HBSISLibraryServiceReference.Book InsertBook(HBSISLibraryWeb.HBSISLibraryServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/InsertBook", ReplyAction="http://tempuri.org/IHBSISLibraryService/InsertBookResponse")]
        System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Book> InsertBookAsync(HBSISLibraryWeb.HBSISLibraryServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/UpdateBook", ReplyAction="http://tempuri.org/IHBSISLibraryService/UpdateBookResponse")]
        HBSISLibraryWeb.HBSISLibraryServiceReference.Book UpdateBook(HBSISLibraryWeb.HBSISLibraryServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/UpdateBook", ReplyAction="http://tempuri.org/IHBSISLibraryService/UpdateBookResponse")]
        System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Book> UpdateBookAsync(HBSISLibraryWeb.HBSISLibraryServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/DeleteBookById", ReplyAction="http://tempuri.org/IHBSISLibraryService/DeleteBookByIdResponse")]
        void DeleteBookById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/DeleteBookById", ReplyAction="http://tempuri.org/IHBSISLibraryService/DeleteBookByIdResponse")]
        System.Threading.Tasks.Task DeleteBookByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/FindAllPublishers", ReplyAction="http://tempuri.org/IHBSISLibraryService/FindAllPublishersResponse")]
        HBSISLibraryWeb.HBSISLibraryServiceReference.Publisher[] FindAllPublishers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/FindAllPublishers", ReplyAction="http://tempuri.org/IHBSISLibraryService/FindAllPublishersResponse")]
        System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Publisher[]> FindAllPublishersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/FindAllAuthors", ReplyAction="http://tempuri.org/IHBSISLibraryService/FindAllAuthorsResponse")]
        HBSISLibraryWeb.HBSISLibraryServiceReference.Author[] FindAllAuthors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHBSISLibraryService/FindAllAuthors", ReplyAction="http://tempuri.org/IHBSISLibraryService/FindAllAuthorsResponse")]
        System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Author[]> FindAllAuthorsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHBSISLibraryServiceChannel : HBSISLibraryWeb.HBSISLibraryServiceReference.IHBSISLibraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HBSISLibraryServiceClient : System.ServiceModel.ClientBase<HBSISLibraryWeb.HBSISLibraryServiceReference.IHBSISLibraryService>, HBSISLibraryWeb.HBSISLibraryServiceReference.IHBSISLibraryService {
        
        public HBSISLibraryServiceClient() {
        }
        
        public HBSISLibraryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HBSISLibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HBSISLibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HBSISLibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HBSISLibraryWeb.HBSISLibraryServiceReference.Book[] FindAllBooks() {
            return base.Channel.FindAllBooks();
        }
        
        public System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Book[]> FindAllBooksAsync() {
            return base.Channel.FindAllBooksAsync();
        }
        
        public HBSISLibraryWeb.HBSISLibraryServiceReference.Book FindBookById(int id) {
            return base.Channel.FindBookById(id);
        }
        
        public System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Book> FindBookByIdAsync(int id) {
            return base.Channel.FindBookByIdAsync(id);
        }
        
        public HBSISLibraryWeb.HBSISLibraryServiceReference.Book InsertBook(HBSISLibraryWeb.HBSISLibraryServiceReference.Book book) {
            return base.Channel.InsertBook(book);
        }
        
        public System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Book> InsertBookAsync(HBSISLibraryWeb.HBSISLibraryServiceReference.Book book) {
            return base.Channel.InsertBookAsync(book);
        }
        
        public HBSISLibraryWeb.HBSISLibraryServiceReference.Book UpdateBook(HBSISLibraryWeb.HBSISLibraryServiceReference.Book book) {
            return base.Channel.UpdateBook(book);
        }
        
        public System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Book> UpdateBookAsync(HBSISLibraryWeb.HBSISLibraryServiceReference.Book book) {
            return base.Channel.UpdateBookAsync(book);
        }
        
        public void DeleteBookById(int id) {
            base.Channel.DeleteBookById(id);
        }
        
        public System.Threading.Tasks.Task DeleteBookByIdAsync(int id) {
            return base.Channel.DeleteBookByIdAsync(id);
        }
        
        public HBSISLibraryWeb.HBSISLibraryServiceReference.Publisher[] FindAllPublishers() {
            return base.Channel.FindAllPublishers();
        }
        
        public System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Publisher[]> FindAllPublishersAsync() {
            return base.Channel.FindAllPublishersAsync();
        }
        
        public HBSISLibraryWeb.HBSISLibraryServiceReference.Author[] FindAllAuthors() {
            return base.Channel.FindAllAuthors();
        }
        
        public System.Threading.Tasks.Task<HBSISLibraryWeb.HBSISLibraryServiceReference.Author[]> FindAllAuthorsAsync() {
            return base.Channel.FindAllAuthorsAsync();
        }
    }
}
