﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileUploader.LargeFileAPI {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LargeFileAPI.IFileUpload")]
    public interface IFileUpload {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpload/UploadFile", ReplyAction="http://tempuri.org/IFileUpload/UploadFileResponse")]
        Interfaces.UploadFileResponse UploadFile(byte[] fileBytes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpload/UploadFile", ReplyAction="http://tempuri.org/IFileUpload/UploadFileResponse")]
        System.Threading.Tasks.Task<Interfaces.UploadFileResponse> UploadFileAsync(byte[] fileBytes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpload/UploadFileViaStream", ReplyAction="http://tempuri.org/IFileUpload/UploadFileViaStreamResponse")]
        Interfaces.UploadFileResponse UploadFileViaStream(System.IO.Stream fileStream);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpload/UploadFileViaStream", ReplyAction="http://tempuri.org/IFileUpload/UploadFileViaStreamResponse")]
        System.Threading.Tasks.Task<Interfaces.UploadFileResponse> UploadFileViaStreamAsync(System.IO.Stream fileStream);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpload/SayHello", ReplyAction="http://tempuri.org/IFileUpload/SayHelloResponse")]
        string SayHello(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpload/SayHello", ReplyAction="http://tempuri.org/IFileUpload/SayHelloResponse")]
        System.Threading.Tasks.Task<string> SayHelloAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileUploadChannel : FileUploader.LargeFileAPI.IFileUpload, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileUploadClient : System.ServiceModel.ClientBase<FileUploader.LargeFileAPI.IFileUpload>, FileUploader.LargeFileAPI.IFileUpload {
        
        public FileUploadClient() {
        }
        
        public FileUploadClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileUploadClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUploadClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUploadClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Interfaces.UploadFileResponse UploadFile(byte[] fileBytes) {
            return base.Channel.UploadFile(fileBytes);
        }
        
        public System.Threading.Tasks.Task<Interfaces.UploadFileResponse> UploadFileAsync(byte[] fileBytes) {
            return base.Channel.UploadFileAsync(fileBytes);
        }
        
        public Interfaces.UploadFileResponse UploadFileViaStream(System.IO.Stream fileStream) {
            return base.Channel.UploadFileViaStream(fileStream);
        }
        
        public System.Threading.Tasks.Task<Interfaces.UploadFileResponse> UploadFileViaStreamAsync(System.IO.Stream fileStream) {
            return base.Channel.UploadFileViaStreamAsync(fileStream);
        }
        
        public string SayHello(string name) {
            return base.Channel.SayHello(name);
        }
        
        public System.Threading.Tasks.Task<string> SayHelloAsync(string name) {
            return base.Channel.SayHelloAsync(name);
        }
    }
}
