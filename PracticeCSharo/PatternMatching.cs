using System;
using System.Threading;

namespace TechDoctor
{
    // is expressions and switch statements
    public class PatternMatching
    {

        public void IsExpression()
        {
            object count = "Abid is  wise man";
            
            if(count is int number)
                Console.WriteLine(number);
            else
            {
                switch (count)
                {
                    case byte i:
                        Console.WriteLine($"{count} is a byte");
                        break;
                        case int i:
                            Console.WriteLine($"{count} is an int");
                            break;
                        case float f:
                            Console.WriteLine($"{count} is a float");
                            break;
                    case double d:
                        Console.WriteLine($"{count} is a double");
                        break;
                        
                    case decimal d:
                        Console.WriteLine($"{count} is a decimal");
                        break;
                    case null:
                        Console.WriteLine($"{count} is a null");
                        break;
                    case string s when s.StartsWith("Abid"):
                        Console.WriteLine("The object is a string starting with Abid");
                        break;
                    default:
                        Console.WriteLine($"The object {count} inn some other type");
                        break;
                }
                
                
            }
        }

    }
}