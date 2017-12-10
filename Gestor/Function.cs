using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor
{
    public class Function
    {
        public static float Ceiling(float value, float significance)
        {
            float result = (value % significance) > Global.Tolerance
                ? ((int)(value / significance) * significance) + significance
                : (float)Math.Ceiling(value);

            return result;
        }

        public static int Floor(float value, float significance)
        {

            int result = (value % significance) > Global.Tolerance
                ? ((int)((value / significance) * significance))
                : (int)Math.Floor(value);

            return result;
        }

        public static float Multiplo(float valor, float limite)
        {
            while ((valor % limite) != 0)
            {
                valor--;
            }

            return valor;
        }
    }
}