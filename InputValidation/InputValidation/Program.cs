using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex rg = new Regex("^[a-zA-Z._%+-]");
            Console.WriteLine("Please enter first and last name (John Smith)");
            String sInput = Console.ReadLine(); 
            Match mt = rg.Match(sInput);

            while(mt.Success == false)
            {
                Console.WriteLine("*** Incorrect Format. Please try again. ***");
                Console.WriteLine("Valid name format: John Smith");
                sInput = Console.ReadLine();
                mt = rg.Match(sInput);
            }

            Console.WriteLine("You entered: " + sInput + ", which is an acceptible name format.");

            rg = new Regex(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$"); 
            Console.WriteLine("Valid phone number formats: 555-55-5555 or (999)999-9999"); 
            sInput = Console.ReadLine(); 
            mt = rg.Match(sInput);

            while(mt.Success == false)
            {
                Console.WriteLine("*** Incorrect Format. Please try again. ***");
                Console.WriteLine("Valid phone number formats: 555-55-5555 or (999)999-9999");
                sInput = Console.ReadLine();
                mt = rg.Match(sInput);
            }

            Console.WriteLine("You entered an acceptible number format.\nPress enter to exit.");
            
            
            Console.Read();
        }
    }
}
