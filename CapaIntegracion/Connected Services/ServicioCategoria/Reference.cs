﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaIntegracion.ServicioCategoria {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Categoria", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Categoria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioCategoria.ServicioCategoriaSoap")]
    public interface ServicioCategoriaSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento categoria del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCategoria", ReplyAction="*")]
        CapaIntegracion.ServicioCategoria.AgregarCategoriaResponse AgregarCategoria(CapaIntegracion.ServicioCategoria.AgregarCategoriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.AgregarCategoriaResponse> AgregarCategoriaAsync(CapaIntegracion.ServicioCategoria.AgregarCategoriaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Remitente del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerCategoria", ReplyAction="*")]
        CapaIntegracion.ServicioCategoria.ObtenerCategoriaResponse ObtenerCategoria(CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.ObtenerCategoriaResponse> ObtenerCategoriaAsync(CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento categoria del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarCategoria", ReplyAction="*")]
        CapaIntegracion.ServicioCategoria.ActualizarCategoriaResponse ActualizarCategoria(CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.ActualizarCategoriaResponse> ActualizarCategoriaAsync(CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Remitente del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarCategoria", ReplyAction="*")]
        CapaIntegracion.ServicioCategoria.EliminarCategoriaResponse EliminarCategoria(CapaIntegracion.ServicioCategoria.EliminarCategoriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.EliminarCategoriaResponse> EliminarCategoriaAsync(CapaIntegracion.ServicioCategoria.EliminarCategoriaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarCategoriaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarCategoria", Namespace="http://tempuri.org/", Order=0)]
        public CapaIntegracion.ServicioCategoria.AgregarCategoriaRequestBody Body;
        
        public AgregarCategoriaRequest() {
        }
        
        public AgregarCategoriaRequest(CapaIntegracion.ServicioCategoria.AgregarCategoriaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarCategoriaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaIntegracion.ServicioCategoria.Categoria categoria;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Remitente;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Origen;
        
        public AgregarCategoriaRequestBody() {
        }
        
        public AgregarCategoriaRequestBody(CapaIntegracion.ServicioCategoria.Categoria categoria, string Remitente, int Origen) {
            this.categoria = categoria;
            this.Remitente = Remitente;
            this.Origen = Origen;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarCategoriaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarCategoriaResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaIntegracion.ServicioCategoria.AgregarCategoriaResponseBody Body;
        
        public AgregarCategoriaResponse() {
        }
        
        public AgregarCategoriaResponse(CapaIntegracion.ServicioCategoria.AgregarCategoriaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarCategoriaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AgregarCategoriaResult;
        
        public AgregarCategoriaResponseBody() {
        }
        
        public AgregarCategoriaResponseBody(bool AgregarCategoriaResult) {
            this.AgregarCategoriaResult = AgregarCategoriaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerCategoriaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerCategoria", Namespace="http://tempuri.org/", Order=0)]
        public CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequestBody Body;
        
        public ObtenerCategoriaRequest() {
        }
        
        public ObtenerCategoriaRequest(CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerCategoriaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Remitente;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Origen;
        
        public ObtenerCategoriaRequestBody() {
        }
        
        public ObtenerCategoriaRequestBody(string Remitente, int Origen) {
            this.Remitente = Remitente;
            this.Origen = Origen;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerCategoriaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerCategoriaResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaIntegracion.ServicioCategoria.ObtenerCategoriaResponseBody Body;
        
        public ObtenerCategoriaResponse() {
        }
        
        public ObtenerCategoriaResponse(CapaIntegracion.ServicioCategoria.ObtenerCategoriaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerCategoriaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ObtenerCategoriaResult;
        
        public ObtenerCategoriaResponseBody() {
        }
        
        public ObtenerCategoriaResponseBody(string ObtenerCategoriaResult) {
            this.ObtenerCategoriaResult = ObtenerCategoriaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ActualizarCategoriaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ActualizarCategoria", Namespace="http://tempuri.org/", Order=0)]
        public CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequestBody Body;
        
        public ActualizarCategoriaRequest() {
        }
        
        public ActualizarCategoriaRequest(CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ActualizarCategoriaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaIntegracion.ServicioCategoria.Categoria categoria;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Remitente;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Origen;
        
        public ActualizarCategoriaRequestBody() {
        }
        
        public ActualizarCategoriaRequestBody(CapaIntegracion.ServicioCategoria.Categoria categoria, string Remitente, int Origen) {
            this.categoria = categoria;
            this.Remitente = Remitente;
            this.Origen = Origen;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ActualizarCategoriaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ActualizarCategoriaResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaIntegracion.ServicioCategoria.ActualizarCategoriaResponseBody Body;
        
        public ActualizarCategoriaResponse() {
        }
        
        public ActualizarCategoriaResponse(CapaIntegracion.ServicioCategoria.ActualizarCategoriaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ActualizarCategoriaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ActualizarCategoriaResult;
        
        public ActualizarCategoriaResponseBody() {
        }
        
        public ActualizarCategoriaResponseBody(bool ActualizarCategoriaResult) {
            this.ActualizarCategoriaResult = ActualizarCategoriaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarCategoriaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarCategoria", Namespace="http://tempuri.org/", Order=0)]
        public CapaIntegracion.ServicioCategoria.EliminarCategoriaRequestBody Body;
        
        public EliminarCategoriaRequest() {
        }
        
        public EliminarCategoriaRequest(CapaIntegracion.ServicioCategoria.EliminarCategoriaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarCategoriaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Remitente;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Origen;
        
        public EliminarCategoriaRequestBody() {
        }
        
        public EliminarCategoriaRequestBody(int Id, string Remitente, int Origen) {
            this.Id = Id;
            this.Remitente = Remitente;
            this.Origen = Origen;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarCategoriaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarCategoriaResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaIntegracion.ServicioCategoria.EliminarCategoriaResponseBody Body;
        
        public EliminarCategoriaResponse() {
        }
        
        public EliminarCategoriaResponse(CapaIntegracion.ServicioCategoria.EliminarCategoriaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarCategoriaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool EliminarCategoriaResult;
        
        public EliminarCategoriaResponseBody() {
        }
        
        public EliminarCategoriaResponseBody(bool EliminarCategoriaResult) {
            this.EliminarCategoriaResult = EliminarCategoriaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioCategoriaSoapChannel : CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioCategoriaSoapClient : System.ServiceModel.ClientBase<CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap>, CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap {
        
        public ServicioCategoriaSoapClient() {
        }
        
        public ServicioCategoriaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioCategoriaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioCategoriaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioCategoriaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaIntegracion.ServicioCategoria.AgregarCategoriaResponse CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap.AgregarCategoria(CapaIntegracion.ServicioCategoria.AgregarCategoriaRequest request) {
            return base.Channel.AgregarCategoria(request);
        }
        
        public bool AgregarCategoria(CapaIntegracion.ServicioCategoria.Categoria categoria, string Remitente, int Origen) {
            CapaIntegracion.ServicioCategoria.AgregarCategoriaRequest inValue = new CapaIntegracion.ServicioCategoria.AgregarCategoriaRequest();
            inValue.Body = new CapaIntegracion.ServicioCategoria.AgregarCategoriaRequestBody();
            inValue.Body.categoria = categoria;
            inValue.Body.Remitente = Remitente;
            inValue.Body.Origen = Origen;
            CapaIntegracion.ServicioCategoria.AgregarCategoriaResponse retVal = ((CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap)(this)).AgregarCategoria(inValue);
            return retVal.Body.AgregarCategoriaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.AgregarCategoriaResponse> CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap.AgregarCategoriaAsync(CapaIntegracion.ServicioCategoria.AgregarCategoriaRequest request) {
            return base.Channel.AgregarCategoriaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.AgregarCategoriaResponse> AgregarCategoriaAsync(CapaIntegracion.ServicioCategoria.Categoria categoria, string Remitente, int Origen) {
            CapaIntegracion.ServicioCategoria.AgregarCategoriaRequest inValue = new CapaIntegracion.ServicioCategoria.AgregarCategoriaRequest();
            inValue.Body = new CapaIntegracion.ServicioCategoria.AgregarCategoriaRequestBody();
            inValue.Body.categoria = categoria;
            inValue.Body.Remitente = Remitente;
            inValue.Body.Origen = Origen;
            return ((CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap)(this)).AgregarCategoriaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaIntegracion.ServicioCategoria.ObtenerCategoriaResponse CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap.ObtenerCategoria(CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequest request) {
            return base.Channel.ObtenerCategoria(request);
        }
        
        public string ObtenerCategoria(string Remitente, int Origen) {
            CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequest inValue = new CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequest();
            inValue.Body = new CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequestBody();
            inValue.Body.Remitente = Remitente;
            inValue.Body.Origen = Origen;
            CapaIntegracion.ServicioCategoria.ObtenerCategoriaResponse retVal = ((CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap)(this)).ObtenerCategoria(inValue);
            return retVal.Body.ObtenerCategoriaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.ObtenerCategoriaResponse> CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap.ObtenerCategoriaAsync(CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequest request) {
            return base.Channel.ObtenerCategoriaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.ObtenerCategoriaResponse> ObtenerCategoriaAsync(string Remitente, int Origen) {
            CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequest inValue = new CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequest();
            inValue.Body = new CapaIntegracion.ServicioCategoria.ObtenerCategoriaRequestBody();
            inValue.Body.Remitente = Remitente;
            inValue.Body.Origen = Origen;
            return ((CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap)(this)).ObtenerCategoriaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaIntegracion.ServicioCategoria.ActualizarCategoriaResponse CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap.ActualizarCategoria(CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequest request) {
            return base.Channel.ActualizarCategoria(request);
        }
        
        public bool ActualizarCategoria(CapaIntegracion.ServicioCategoria.Categoria categoria, string Remitente, int Origen) {
            CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequest inValue = new CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequest();
            inValue.Body = new CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequestBody();
            inValue.Body.categoria = categoria;
            inValue.Body.Remitente = Remitente;
            inValue.Body.Origen = Origen;
            CapaIntegracion.ServicioCategoria.ActualizarCategoriaResponse retVal = ((CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap)(this)).ActualizarCategoria(inValue);
            return retVal.Body.ActualizarCategoriaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.ActualizarCategoriaResponse> CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap.ActualizarCategoriaAsync(CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequest request) {
            return base.Channel.ActualizarCategoriaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.ActualizarCategoriaResponse> ActualizarCategoriaAsync(CapaIntegracion.ServicioCategoria.Categoria categoria, string Remitente, int Origen) {
            CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequest inValue = new CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequest();
            inValue.Body = new CapaIntegracion.ServicioCategoria.ActualizarCategoriaRequestBody();
            inValue.Body.categoria = categoria;
            inValue.Body.Remitente = Remitente;
            inValue.Body.Origen = Origen;
            return ((CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap)(this)).ActualizarCategoriaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaIntegracion.ServicioCategoria.EliminarCategoriaResponse CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap.EliminarCategoria(CapaIntegracion.ServicioCategoria.EliminarCategoriaRequest request) {
            return base.Channel.EliminarCategoria(request);
        }
        
        public bool EliminarCategoria(int Id, string Remitente, int Origen) {
            CapaIntegracion.ServicioCategoria.EliminarCategoriaRequest inValue = new CapaIntegracion.ServicioCategoria.EliminarCategoriaRequest();
            inValue.Body = new CapaIntegracion.ServicioCategoria.EliminarCategoriaRequestBody();
            inValue.Body.Id = Id;
            inValue.Body.Remitente = Remitente;
            inValue.Body.Origen = Origen;
            CapaIntegracion.ServicioCategoria.EliminarCategoriaResponse retVal = ((CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap)(this)).EliminarCategoria(inValue);
            return retVal.Body.EliminarCategoriaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.EliminarCategoriaResponse> CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap.EliminarCategoriaAsync(CapaIntegracion.ServicioCategoria.EliminarCategoriaRequest request) {
            return base.Channel.EliminarCategoriaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaIntegracion.ServicioCategoria.EliminarCategoriaResponse> EliminarCategoriaAsync(int Id, string Remitente, int Origen) {
            CapaIntegracion.ServicioCategoria.EliminarCategoriaRequest inValue = new CapaIntegracion.ServicioCategoria.EliminarCategoriaRequest();
            inValue.Body = new CapaIntegracion.ServicioCategoria.EliminarCategoriaRequestBody();
            inValue.Body.Id = Id;
            inValue.Body.Remitente = Remitente;
            inValue.Body.Origen = Origen;
            return ((CapaIntegracion.ServicioCategoria.ServicioCategoriaSoap)(this)).EliminarCategoriaAsync(inValue);
        }
    }
}
