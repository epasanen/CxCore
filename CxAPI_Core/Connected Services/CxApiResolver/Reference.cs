﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CxApiResolver
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CxClientType", Namespace="http://Checkmarx.com")]
    public enum CxClientType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WebPortal = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CLI = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Eclipse = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        VS = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InteliJ = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Audit = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SDK = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Jenkins = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TFSBuild = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Importer = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sonar = 12,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CxWSBasicRepsonse", Namespace="http://Checkmarx.com")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CxApiResolver.CxWSResponseDiscovery))]
    public partial class CxWSBasicRepsonse : object
    {
        
        private bool IsSuccesfullField;
        
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool IsSuccesfull
        {
            get
            {
                return this.IsSuccesfullField;
            }
            set
            {
                this.IsSuccesfullField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string ErrorMessage
        {
            get
            {
                return this.ErrorMessageField;
            }
            set
            {
                this.ErrorMessageField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CxWSResponseDiscovery", Namespace="http://Checkmarx.com")]
    public partial class CxWSResponseDiscovery : CxApiResolver.CxWSBasicRepsonse
    {
        
        private string ServiceURLField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ServiceURL
        {
            get
            {
                return this.ServiceURLField;
            }
            set
            {
                this.ServiceURLField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Checkmarx.com", ConfigurationName="CxApiResolver.CxWSResolverSoap")]
    public interface CxWSResolverSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Checkmarx.com/GetWebServiceUrl", ReplyAction="*")]
        System.Threading.Tasks.Task<CxApiResolver.GetWebServiceUrlResponse> GetWebServiceUrlAsync(CxApiResolver.GetWebServiceUrlRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWebServiceUrlRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWebServiceUrl", Namespace="http://Checkmarx.com", Order=0)]
        public CxApiResolver.GetWebServiceUrlRequestBody Body;
        
        public GetWebServiceUrlRequest()
        {
        }
        
        public GetWebServiceUrlRequest(CxApiResolver.GetWebServiceUrlRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://Checkmarx.com")]
    public partial class GetWebServiceUrlRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public CxApiResolver.CxClientType ClientType;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int APIVersion;
        
        public GetWebServiceUrlRequestBody()
        {
        }
        
        public GetWebServiceUrlRequestBody(CxApiResolver.CxClientType ClientType, int APIVersion)
        {
            this.ClientType = ClientType;
            this.APIVersion = APIVersion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWebServiceUrlResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWebServiceUrlResponse", Namespace="http://Checkmarx.com", Order=0)]
        public CxApiResolver.GetWebServiceUrlResponseBody Body;
        
        public GetWebServiceUrlResponse()
        {
        }
        
        public GetWebServiceUrlResponse(CxApiResolver.GetWebServiceUrlResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://Checkmarx.com")]
    public partial class GetWebServiceUrlResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CxApiResolver.CxWSResponseDiscovery GetWebServiceUrlResult;
        
        public GetWebServiceUrlResponseBody()
        {
        }
        
        public GetWebServiceUrlResponseBody(CxApiResolver.CxWSResponseDiscovery GetWebServiceUrlResult)
        {
            this.GetWebServiceUrlResult = GetWebServiceUrlResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface CxWSResolverSoapChannel : CxApiResolver.CxWSResolverSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class CxWSResolverSoapClient : System.ServiceModel.ClientBase<CxApiResolver.CxWSResolverSoap>, CxApiResolver.CxWSResolverSoap
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CxWSResolverSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(CxWSResolverSoapClient.GetBindingForEndpoint(endpointConfiguration), CxWSResolverSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CxWSResolverSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CxWSResolverSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CxWSResolverSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CxWSResolverSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CxWSResolverSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CxApiResolver.GetWebServiceUrlResponse> CxApiResolver.CxWSResolverSoap.GetWebServiceUrlAsync(CxApiResolver.GetWebServiceUrlRequest request)
        {
            return base.Channel.GetWebServiceUrlAsync(request);
        }
        
        public System.Threading.Tasks.Task<CxApiResolver.GetWebServiceUrlResponse> GetWebServiceUrlAsync(CxApiResolver.CxClientType ClientType, int APIVersion)
        {
            CxApiResolver.GetWebServiceUrlRequest inValue = new CxApiResolver.GetWebServiceUrlRequest();
            inValue.Body = new CxApiResolver.GetWebServiceUrlRequestBody();
            inValue.Body.ClientType = ClientType;
            inValue.Body.APIVersion = APIVersion;
            return ((CxApiResolver.CxWSResolverSoap)(this)).GetWebServiceUrlAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CxWSResolverSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.CxWSResolverSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CxWSResolverSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://192.168.250.6/CxWebInterface/CxWSResolver.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.CxWSResolverSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://192.168.250.6/CxWebInterface/CxWSResolver.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            CxWSResolverSoap,
            
            CxWSResolverSoap12,
        }
    }
}
