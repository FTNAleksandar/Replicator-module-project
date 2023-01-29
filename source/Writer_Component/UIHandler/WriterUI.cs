using System;
using Writer_Component.Interface;
using Writer_Component.Interface.Impl;
using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;
using System.Linq.Expressions;

namespace Writer_Component.UIHandler
{
    public class WriterUI
    {
        public void WriterUIhandler()
        {


            string answer;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Odaberite opciju:");
                Console.WriteLine("1 - Unos nove potrosnje");
                Console.WriteLine("2 - Unos novog klijenta");
                Console.WriteLine("X - Izlazak u meni");


                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        HandleUsageInput();
                        break;
                    case "2":
                        HandleUserInput();
                        break;


                }

            } while (!answer.ToUpper().Equals("X"));
        }

        internal void HandleUsageInput()
        {
            DataSet data = new DataSet();
            IWriter writer = new WriterImpl();


            Console.WriteLine();

           
                Console.WriteLine("Unesite ID brojila(celobrojna vrednost): ");
                data.BrojiloId = int.Parse(Console.ReadLine());

                Console.WriteLine("Unesite potrosnju vode: ");
                data.SpentWater = decimal.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("Unesite mesec(malim slovima): ");
                    data.Month = Console.ReadLine();
                }
                while (data.Month != "januar" && data.Month != "februar" && data.Month != "mart" && data.Month != "april" && data.Month != "maj" && data.Month != "jun"
                     && data.Month != "jul" && data.Month != "avgust" && data.Month != "septembar" && data.Month != "oktobar" && data.Month != "novembar" && data.Month != "decembar");

                writer.DataPassThrought(data);
            
           
        }

      
        internal void HandleUserInput()
        {
            try
            {
                DataSetUser data = new DataSetUser();
                IWriter writer = new WriterImpl();

                Console.WriteLine("Unesite ID brojila: ");
                data.BrojiloId = int.Parse(Console.ReadLine());

                Console.WriteLine("Unesite ime i prezime klijenta: ");
                data.UserName = Console.ReadLine();

                Console.WriteLine("Unesite ulicu klijenta: ");
                data.UserStreet = Console.ReadLine();

                Console.WriteLine("Unesite broj kuce klijenta: ");
                data.UserStreetNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Unesite grad klijenta: ");
                data.UserCity = Console.ReadLine();

                Console.WriteLine("Unesite postanski broj klijenta: ");
                data.UserZip = Console.ReadLine();

                writer.UserDataPassThrought(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
