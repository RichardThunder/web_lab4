﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LAB4.WebRefWeather {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebXml.com.cn/", ConfigurationName="WebRefWeather.WeatherWSSoap")]
    public interface WeatherWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getRegionDataset", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getRegionDataset();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getRegionDataset", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getRegionDatasetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getRegionProvince", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] getRegionProvince();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getRegionProvince", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> getRegionProvinceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getRegionCountry", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] getRegionCountry();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getRegionCountry", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> getRegionCountryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getSupportCityDataset", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getSupportCityDataset(string theRegionCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getSupportCityDataset", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getSupportCityDatasetAsync(string theRegionCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getSupportCityString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] getSupportCityString(string theRegionCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getSupportCityString", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> getSupportCityStringAsync(string theRegionCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getWeather", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] getWeather(string theCityCode, string theUserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getWeather", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> getWeatherAsync(string theCityCode, string theUserID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WeatherWSSoapChannel : LAB4.WebRefWeather.WeatherWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherWSSoapClient : System.ServiceModel.ClientBase<LAB4.WebRefWeather.WeatherWSSoap>, LAB4.WebRefWeather.WeatherWSSoap {
        
        public WeatherWSSoapClient() {
        }
        
        public WeatherWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet getRegionDataset() {
            return base.Channel.getRegionDataset();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getRegionDatasetAsync() {
            return base.Channel.getRegionDatasetAsync();
        }
        
        public string[] getRegionProvince() {
            return base.Channel.getRegionProvince();
        }
        
        public System.Threading.Tasks.Task<string[]> getRegionProvinceAsync() {
            return base.Channel.getRegionProvinceAsync();
        }
        
        public string[] getRegionCountry() {
            return base.Channel.getRegionCountry();
        }
        
        public System.Threading.Tasks.Task<string[]> getRegionCountryAsync() {
            return base.Channel.getRegionCountryAsync();
        }
        
        public System.Data.DataSet getSupportCityDataset(string theRegionCode) {
            return base.Channel.getSupportCityDataset(theRegionCode);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getSupportCityDatasetAsync(string theRegionCode) {
            return base.Channel.getSupportCityDatasetAsync(theRegionCode);
        }
        
        public string[] getSupportCityString(string theRegionCode) {
            return base.Channel.getSupportCityString(theRegionCode);
        }
        
        public System.Threading.Tasks.Task<string[]> getSupportCityStringAsync(string theRegionCode) {
            return base.Channel.getSupportCityStringAsync(theRegionCode);
        }
        
        public string[] getWeather(string theCityCode, string theUserID) {
            return base.Channel.getWeather(theCityCode, theUserID);
        }
        
        public System.Threading.Tasks.Task<string[]> getWeatherAsync(string theCityCode, string theUserID) {
            return base.Channel.getWeatherAsync(theCityCode, theUserID);
        }
    }
}
