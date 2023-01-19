using Reports_Component.UI_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Writer_Component.UIHandler;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string answer;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Odaberite opciju:");
                Console.WriteLine("1 - Reports komponenta");
                Console.WriteLine("2 - Writer komponenta");
                Console.WriteLine("X - Izlazak iz programa");


                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        HandleReportsUI();
                        break;
                    case "2":
                        HandleWriterUI();
                        break;


                }

            } while (!answer.ToUpper().Equals("X"));


            void HandleReportsUI()
            {
                ReportsUI reportUI = new ReportsUI();
                reportUI.reportsUIhandler();

            }

            void HandleWriterUI()
            {
                WriterUI writerUI = new WriterUI();

                writerUI.WriterUIhandler();
            }


        }
    }
}
