using System;
using System.Collections.Generic;



namespace CxAPI_Core
{
 
    internal class Start
    {
        private static void Main(string[] args)
        {
            Configuration.configuration(args);
            dispatcher dsp = new dispatcher();

            resultClass token = dsp.dispatch();
            if (token.debug)
            {
                Console.ReadKey();
            }
        }
    }

}
