using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Utils
{
    public static class Globals
    {
        public static DateTime GetFechaActual()
        {
            return DateTime.UtcNow.AddHours(-5);
        }

        public static bool ValidatePassword(string pwd, int minLength = 6, int numUpper = 1, int numLower = 1, int numNumbers = 1, int numSpecial = 1)
        {
            System.Text.RegularExpressions.Regex upper = new System.Text.RegularExpressions.Regex("[A-Z]");
            System.Text.RegularExpressions.Regex lower = new System.Text.RegularExpressions.Regex("[a-z]");
            System.Text.RegularExpressions.Regex number = new System.Text.RegularExpressions.Regex("[0-9]");
            System.Text.RegularExpressions.Regex special = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");
            if (pwd.Length < minLength)
                return false;
            if (upper.Matches(pwd).Count < numUpper)
                return false;
            if (lower.Matches(pwd).Count < numLower)
                return false;
            if (number.Matches(pwd).Count < numNumbers)
                return false;
            if (special.Matches(pwd).Count < numSpecial)
                return false;
            return true;
        }
    }
}
