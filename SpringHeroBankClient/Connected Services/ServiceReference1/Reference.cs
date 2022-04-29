﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpringHeroBankClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        string Login(string accountNumber, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string accountNumber, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Transfer", ReplyAction="http://tempuri.org/IService1/TransferResponse")]
        bool Transfer(string senderToken, string receiverAccountNumber, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Transfer", ReplyAction="http://tempuri.org/IService1/TransferResponse")]
        System.Threading.Tasks.Task<bool> TransferAsync(string senderToken, string receiverAccountNumber, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deposit", ReplyAction="http://tempuri.org/IService1/DepositResponse")]
        bool Deposit(string token, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deposit", ReplyAction="http://tempuri.org/IService1/DepositResponse")]
        System.Threading.Tasks.Task<bool> DepositAsync(string token, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Withdraw", ReplyAction="http://tempuri.org/IService1/WithdrawResponse")]
        bool Withdraw(string token, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Withdraw", ReplyAction="http://tempuri.org/IService1/WithdrawResponse")]
        System.Threading.Tasks.Task<bool> WithdrawAsync(string token, double amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SpringHeroBankClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SpringHeroBankClient.ServiceReference1.IService1>, SpringHeroBankClient.ServiceReference1.IService1 {
        
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
        
        public string Login(string accountNumber, string code) {
            return base.Channel.Login(accountNumber, code);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string accountNumber, string code) {
            return base.Channel.LoginAsync(accountNumber, code);
        }
        
        public bool Transfer(string senderToken, string receiverAccountNumber, double amount) {
            return base.Channel.Transfer(senderToken, receiverAccountNumber, amount);
        }
        
        public System.Threading.Tasks.Task<bool> TransferAsync(string senderToken, string receiverAccountNumber, double amount) {
            return base.Channel.TransferAsync(senderToken, receiverAccountNumber, amount);
        }
        
        public bool Deposit(string token, double amount) {
            return base.Channel.Deposit(token, amount);
        }
        
        public System.Threading.Tasks.Task<bool> DepositAsync(string token, double amount) {
            return base.Channel.DepositAsync(token, amount);
        }
        
        public bool Withdraw(string token, double amount) {
            return base.Channel.Withdraw(token, amount);
        }
        
        public System.Threading.Tasks.Task<bool> WithdrawAsync(string token, double amount) {
            return base.Channel.WithdrawAsync(token, amount);
        }
    }
}