using System;
using System.Collections.Generic;
using System.Text;

namespace Phoneword
{
    public class BiblicalQLogic
    {

        public string Question1(string answer)
        {
            switch (answer)
            {
                case "1":
                    return "not true";

                default:
                    break;
            }

            return null;
        }

    }
}
