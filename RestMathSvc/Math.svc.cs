using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;

namespace RestMathSvc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Math" in code, svc and config file together.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    //[JavascriptCallbackBehavior(UrlParameterName = "$callback")]
    public class Math : IMath
    {
        public Resultado Suma(string s1, string s2)
        {
            return new Resultado() { result = Convert.ToInt32(s1) + Convert.ToInt32(s2), Status = 200 };
        }


        public Resultado Resta(string s1, string s2)
        {
            return new Resultado() { result = Convert.ToInt32(s1) - Convert.ToInt32(s2), Status = 200 };
        }
    }
}
