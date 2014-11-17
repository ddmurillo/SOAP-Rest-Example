using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace RestMathSvc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMath" in both code and config file together.
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "suma/{s1}/{s2}", BodyStyle = WebMessageBodyStyle.Bare)]
        Resultado Suma(string s1, string s2);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "resta/{s1}/{s2}", BodyStyle = WebMessageBodyStyle.Bare)]
        Resultado Resta(string s1, string s2);
    }
}
