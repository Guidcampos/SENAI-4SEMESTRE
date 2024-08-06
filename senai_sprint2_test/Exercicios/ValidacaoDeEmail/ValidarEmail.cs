using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidacaoDeEmail
{
    public class ValidarEmail
    {
        public static bool ValidacaoEmail(string email) 
        {
            try
            {
               
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
