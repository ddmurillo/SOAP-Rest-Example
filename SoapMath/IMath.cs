using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapMath
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMath" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        int Suma(int s1, int s2);

        [OperationContract]
        int Resta(int r1, int r2);
    }
}
