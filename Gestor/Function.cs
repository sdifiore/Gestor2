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
    }
}