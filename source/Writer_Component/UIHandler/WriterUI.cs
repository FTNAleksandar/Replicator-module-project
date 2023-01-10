﻿using Replicator.DataSetModel;
using Replicator_Component.DataSetModel;
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
                Console.WriteLine("2 - Unos novog klijenta");
                Console.WriteLine("X - Izlazak iz programa");

               
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
        
        internal void HandleUserInput()
        {
            DataSetUser data = new DataSetUser();
            IWrite writer = new WriterImpl();

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
    }
}
