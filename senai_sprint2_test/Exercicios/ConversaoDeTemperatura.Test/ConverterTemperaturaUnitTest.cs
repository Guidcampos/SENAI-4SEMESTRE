using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeTemperatura.Test
{
    
    public class ConverterTemperaturaUnitTest
    {
        [Fact]
        public static void ConverteCelciusParaFahrenheit() 
        {
            var celsius = 11;

            var esperadoFahrenheit = 51.8;

            var resultado = ConverterTemperatura.TemperaturaCParaF(celsius);

            Assert.Equal(esperadoFahrenheit, resultado);
        }
    }
}
