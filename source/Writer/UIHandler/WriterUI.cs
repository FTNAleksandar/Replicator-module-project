using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writer.UIHandler
{
    internal class WriterUI
    {

        public void WriterUIhandler()
        {

            Console.WriteLine("========================WRITER STARTED========================");
            string answer;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Odaberite opciju:");
                Console.WriteLine("1 - Unos nove potrosnje");
                Console.WriteLine("X - Izlazak iz programa");

               
              answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        throw new NotImplementedException();
                        
                  
                }

            } while (!answer.ToUpper().Equals("X"));
        }
    }
}
