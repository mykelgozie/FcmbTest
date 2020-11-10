using System;
using System.Collections.Generic;
using System.Text;

namespace Fcmb
{
    public class AtmClass
    {

        public string CheckAtmCard(string num)
        {
            var result = "";

            if (num.Length >= 16 && num.Length <= 19)
            {
                var mask = "XXXX";
                var openNumber = num.Substring(4, num.Length - 8);
                var final = mask + openNumber + mask;
                result = final;
            }
            else
            {
                result = "Invalid Atm Card ";
            }

            return result;
        }
    }
}
