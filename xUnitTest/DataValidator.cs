using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace xUnitTest
{
    public class DataValidator
    {
        public bool IsValidNif(string nif)
        {
            if(string.IsNullOrEmpty(nif))
                throw new ArgumentNullException(nameof(nif));
            Regex regex = new Regex(@"^\d{8}[A-HJ-NP-TV-Z]$");
            return regex.IsMatch(nif);
        }
    }
}
