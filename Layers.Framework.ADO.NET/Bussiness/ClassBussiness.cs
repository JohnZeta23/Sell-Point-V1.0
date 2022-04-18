using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Framework.ADO.NET
{
    public static class ClassBussiness
    {
        public static bool LimiteCreditoLimite(int LimiteCredito)
        {
            bool Validacion = true;
            if (LimiteCredito >= 0) 
            { 
                Validacion = true;
            }

            if (LimiteCredito < 0)
            {
                Validacion = false;
            }

            return Validacion;
        }
          
    }
}
