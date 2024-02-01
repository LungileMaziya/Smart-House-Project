
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace smart_House_Project.Utilities
{
    public static class FieldValidation
    {
        public static bool IsValidSAIDNumber(string SAIDNumber)
        {
            if (string.IsNullOrEmpty(SAIDNumber)) { return false; }
            else
            {
                return Regex.IsMatch(SAIDNumber, @"^[0-9]{13}$");
            }
        }
    }
}
