﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Danilins.Multitouch.Framework.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Danilins.Multitouch", ConfigurationName="Service.IMultitouchService", CallbackContract=typeof(Danilins.Multitouch.Framework.Service.IMultitouchServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IMultitouchService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Danilins.Multitouch/IMultitouchService/RegisterApplication")]
        void RegisterApplication();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Danilins.Multitouch/IMultitouchService/UnregisterApplication")]
        void UnregisterApplication();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Danilins.Multitouch/IMultitouchService/EnableLegacySupport")]
        void EnableLegacySupport();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Danilins.Multitouch/IMultitouchService/DisableLegacySupport")]
        void DisableLegacySupport();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IMultitouchServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Danilins.Multitouch/IMultitouchService/ProcessContact")]
        void ProcessContact(Danilins.Multitouch.Common.ContactInfo[] contacts);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IMultitouchServiceChannel : Danilins.Multitouch.Framework.Service.IMultitouchService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MultitouchServiceClient : System.ServiceModel.DuplexClientBase<Danilins.Multitouch.Framework.Service.IMultitouchService>, Danilins.Multitouch.Framework.Service.IMultitouchService {
        
        public MultitouchServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MultitouchServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MultitouchServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MultitouchServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MultitouchServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void RegisterApplication() {
            base.Channel.RegisterApplication();
        }
        
        public void UnregisterApplication() {
            base.Channel.UnregisterApplication();
        }
        
        public void EnableLegacySupport() {
            base.Channel.EnableLegacySupport();
        }
        
        public void DisableLegacySupport() {
            base.Channel.DisableLegacySupport();
        }
    }
}