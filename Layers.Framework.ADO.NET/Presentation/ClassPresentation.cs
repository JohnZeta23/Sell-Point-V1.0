using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Framework.ADO.NET.Presentation
{
    public static class ClassPresentation
    {
        public static string mascara;

        public static int Indice = 0;
        public static void FormatoMascara(int Parametro) 
        {
            Indice = Parametro;

            if (Indice == 0) 
            {
                mascara = "999-99999-(9)";
            }

            if (Indice == 1)
            {
                mascara = "999-9999999-9";
            }

            if (Indice == 2)
            {
                mascara = null;
            }
        }
    }
}
