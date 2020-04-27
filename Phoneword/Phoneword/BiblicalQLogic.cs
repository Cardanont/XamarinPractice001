using System;
using System.Collections.Generic;
using System.Text;

namespace Phoneword
{
    public static class BiblicalQLogic
    {

        public static string Question1(string answer)
        {
            if (answer == "10")
                return "That's true!";

            return "That's wrong try again :)";
        }

    }
}
