using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapMath
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Math" en el código, en svc y en el archivo de configuración a la vez.
    public class Math : IMath
    {
        public int Suma(int s1, int s2)
        {
            return s1 + s2;
        }

        public int Resta(int r1, int r2)
        {
            return r1 - r2;
        }
    }
}
