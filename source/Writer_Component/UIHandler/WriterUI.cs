using Replicator.DataSetModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Writer.Interface;
using Writer.Interface.Impl;

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
                        HandleSingleInput();
                        break;
                        
                  
                }

            } while (!answer.ToUpper().Equals("X"));
        }

        internal void HandleSingleInput()
        {
            DataSet data = new DataSet();
            IWrite writer = new WriterImpl();

            Console.WriteLine();

            Console.WriteLine("Unesite ID brojila: ");
            data.BrojiloId = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite potrosnju vode: ");
            data.SpentWater = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Unesite mesec kada je izmerena potrosnja: ");
            data.Month = Console.ReadLine();


            writer.DataPassThrought(data);
        }
    }
}
