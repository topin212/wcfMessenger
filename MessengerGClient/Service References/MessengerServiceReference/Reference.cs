﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessengerGClient.MessengerServiceReference
{
    using System.Runtime.Serialization;
    using System;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Message", Namespace = "http://schemas.datacontract.org/2004/07/MessangerServiceLibrary.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        public bool isWhispered = false;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string messageField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string senderField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                if ((this.dateField.Equals(value) != true))
                {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                if ((object.ReferenceEquals(this.messageField, value) != true))
                {
                    this.messageField = value;
                    this.RaisePropertyChanged("message");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                if ((object.ReferenceEquals(this.senderField, value) != true))
                {
                    this.senderField = value;
                    this.RaisePropertyChanged("sender");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "MessengerServiceReference.IMessengerService", CallbackContract = typeof(MessengerGClient.MessengerServiceReference.IMessengerServiceCallback), SessionMode = System.ServiceModel.SessionMode.Required)]
    public interface IMessengerService
    {

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessengerService/Join")]
        void Join(string name);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessengerService/Join")]
        System.Threading.Tasks.Task JoinAsync(string name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessengerService/Broadcast", ReplyAction = "http://tempuri.org/IMessengerService/BroadcastResponse")]
        void Broadcast(string from, string message);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessengerService/Broadcast", ReplyAction = "http://tempuri.org/IMessengerService/BroadcastResponse")]
        System.Threading.Tasks.Task BroadcastAsync(string from, string message);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessengerService/Whisper", ReplyAction = "http://tempuri.org/IMessengerService/WhisperResponse")]
        void Whisper(string from, string to, string message);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessengerService/Whisper", ReplyAction = "http://tempuri.org/IMessengerService/WhisperResponse")]
        System.Threading.Tasks.Task WhisperAsync(string from, string to, string message);

        [System.ServiceModel.OperationContractAttribute(IsTerminating = true, Action = "http://tempuri.org/IMessengerService/Leave", ReplyAction = "http://tempuri.org/IMessengerService/LeaveResponse")]
        void Leave(string who);

        [System.ServiceModel.OperationContractAttribute(IsTerminating = true, Action = "http://tempuri.org/IMessengerService/Leave", ReplyAction = "http://tempuri.org/IMessengerService/LeaveResponse")]
        System.Threading.Tasks.Task LeaveAsync(string who);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessengerServiceCallback
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessengerService/RecieveBroadcast", ReplyAction = "http://tempuri.org/IMessengerService/RecieveBroadcastResponse")]
        void RecieveBroadcast(MessengerGClient.MessengerServiceReference.Message msg);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessengerService/RecieveWhisper", ReplyAction = "http://tempuri.org/IMessengerService/RecieveWhisperResponse")]
        void RecieveWhisper(MessengerGClient.MessengerServiceReference.Message msg);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessengerService/OnJoin", ReplyAction = "http://tempuri.org/IMessengerService/OnJoinResponse")]
        void OnJoin(System.Collections.Generic.List<string> connectedClients);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessengerServiceChannel : MessengerGClient.MessengerServiceReference.IMessengerService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MessengerServiceClient : System.ServiceModel.DuplexClientBase<MessengerGClient.MessengerServiceReference.IMessengerService>, MessengerGClient.MessengerServiceReference.IMessengerService
    {

        public MessengerServiceClient(System.ServiceModel.InstanceContext callbackInstance) :
                base(callbackInstance)
        {
        }

        public MessengerServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) :
                base(callbackInstance, endpointConfigurationName)
        {
        }

        public MessengerServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) :
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        public MessengerServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        public MessengerServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(callbackInstance, binding, remoteAddress)
        {
        }

        public void Join(string name)
        {
            base.Channel.Join(name);
        }

        public System.Threading.Tasks.Task JoinAsync(string name)
        {
            return base.Channel.JoinAsync(name);
        }

        public void Broadcast(string from, string message)
        {
            base.Channel.Broadcast(from, message);
        }

        public System.Threading.Tasks.Task BroadcastAsync(string from, string message)
        {
            return base.Channel.BroadcastAsync(from, message);
        }

        public void Whisper(string from, string to, string message)
        {
            base.Channel.Whisper(from, to, message);
        }

        public System.Threading.Tasks.Task WhisperAsync(string from, string to, string message)
        {
            return base.Channel.WhisperAsync(from, to, message);
        }

        public void Leave(string who)
        {
            base.Channel.Leave(who);
        }

        public System.Threading.Tasks.Task LeaveAsync(string who)
        {
            return base.Channel.LeaveAsync(who);
        }
    }
}
