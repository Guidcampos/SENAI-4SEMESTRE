using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoDeEmail.Test
{
    public class ValidarEmailUnitTest
    {
        [Theory]
        [InlineData("gui@email.com", true)]
        [InlineData("gui.@com",false)]
        [InlineData("gui@emailcom.", false)]

        public static void EmailValido(string email, bool resultadoEsperado)
        {
            var resultado = ValidarEmail.ValidacaoEmail(email);

            Assert.Equal(resultadoEsperado, resultado);
        }

    }
}
