﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentacion.WebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Respuesta", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Respuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadRestanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PuntosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] ValoresField;
        
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
        public int CantidadRestante {
            get {
                return this.CantidadRestanteField;
            }
            set {
                if ((this.CantidadRestanteField.Equals(value) != true)) {
                    this.CantidadRestanteField = value;
                    this.RaisePropertyChanged("CantidadRestante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Puntos {
            get {
                return this.PuntosField;
            }
            set {
                if ((this.PuntosField.Equals(value) != true)) {
                    this.PuntosField = value;
                    this.RaisePropertyChanged("Puntos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] Valores {
            get {
                return this.ValoresField;
            }
            set {
                if ((object.ReferenceEquals(this.ValoresField, value) != true)) {
                    this.ValoresField = value;
                    this.RaisePropertyChanged("Valores");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DevolverMensaje", ReplyAction="http://tempuri.org/IService/DevolverMensajeResponse")]
        Presentacion.WebService.Respuesta DevolverMensaje(int[] valor, int puntajeTotal, int cantidadRestante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DevolverMensaje", ReplyAction="http://tempuri.org/IService/DevolverMensajeResponse")]
        System.Threading.Tasks.Task<Presentacion.WebService.Respuesta> DevolverMensajeAsync(int[] valor, int puntajeTotal, int cantidadRestante);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Presentacion.WebService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Presentacion.WebService.IService>, Presentacion.WebService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Presentacion.WebService.Respuesta DevolverMensaje(int[] valor, int puntajeTotal, int cantidadRestante) {
            return base.Channel.DevolverMensaje(valor, puntajeTotal, cantidadRestante);
        }
        
        public System.Threading.Tasks.Task<Presentacion.WebService.Respuesta> DevolverMensajeAsync(int[] valor, int puntajeTotal, int cantidadRestante) {
            return base.Channel.DevolverMensajeAsync(valor, puntajeTotal, cantidadRestante);
        }
    }
}
