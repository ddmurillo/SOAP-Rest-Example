using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace RestMath
{
    // Start the service and browse to http://<machine_name>:<port>/Service1/help to view the service's generated help page
    // NOTE: By default, a new instance of the service is created for each call; change the InstanceContextMode to Single if you want
    // a single instance of the service to process all calls.	
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    //[JavascriptCallbackBehavior(UrlParameterName = "callback")]
    // NOTE: If the service is renamed, remember to update the global.asax.cs file
    public class Math
    {
        // TODO: Implement the collection resource that will contain the SampleItem instances
        [OperationContract]
        [WebGet(UriTemplate = "suma/{s1}/{s2}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        public Resultado Suma(string s1, string s2)
        {
            return new Resultado { result = Convert.ToInt32(s1) + Convert.ToInt32(s2), Status = 200 };
        }

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public Resultado Resta()
        {
            return new Resultado { result = Convert.ToInt32(23) - Convert.ToInt32(22), Status = 200 };
        }
    }
}
