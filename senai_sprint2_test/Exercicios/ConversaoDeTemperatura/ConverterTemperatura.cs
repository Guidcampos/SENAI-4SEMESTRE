using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeTemperatura
{
    public class ConverterTemperatura
    {
        public static double TemperaturaCParaF(double x)
        {
            return (x * 1.8) + 32;
        }
    }
}
