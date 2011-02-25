//Copyright 2011 Jared Faris

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.
namespace WcfService
{
    using System.ServiceModel;
    using System.ServiceModel.Web;

    [ServiceContract]
    public interface IExampleService
    {
        [OperationContract]
        [WebGet(UriTemplate = "GetWithOne/{input}",
            ResponseFormat = WebMessageFormat.Json)]
        string GetWithOne(string input);

        [OperationContract]
        [WebGet(UriTemplate = "GetWithTwo/?input1={input1}&input2={input2}",
            ResponseFormat = WebMessageFormat.Json)]
        string GetWithTwo(string input1, string input2);

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "PostWithZero/",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json)]
        string PostWithZero();

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "PostWithOnePrim/",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string PostWithOnePrim(string input);

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "PostWithCompositeType/",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string PostWithCompositeType(ExampleCompositeType testInfo);

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "PostWithComposites/",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        ExampleCompositeType PostWithComposites(ExampleCompositeType testInfo);
    }
}