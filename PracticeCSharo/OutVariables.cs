using System;


namespace TechDoctor
{
    public class OutVariables
    {
        private string input = "12334";
        private int numericResult;
        
        public  void TestOutVariables()
        {
            if (int.TryParse(input, out numericResult))
            {
                Console.WriteLine(numericResult);
            }
            else
            {
                Console.WriteLine("Couldn't parse input");
            }
        }
        
        
        public  void TestOutVariablesNewWay()
        {
            if (int.TryParse(input, out var nResult))
            {
                Console.WriteLine(nResult);
            }
            else
            {
                Console.WriteLine("Couldn't parse input");
            }
        }

        public void A()
        {
            
        }
    }
    
   
}