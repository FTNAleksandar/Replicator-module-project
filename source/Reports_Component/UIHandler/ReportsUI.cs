using DataSet = Database_Component.DataSetModel.DataSet;
using Database_Component.DataSetModel;
using Reports_Component.Interface;
using Reports_Component.Interface.Impl;
using System;
using System.Collections.Generic;
using System.Data.Common;


namespace Reports_Component.UI_Handler
{
    public class ReportsUI
    {
        public void reportsUIhandler()
        {

            Console.WriteLine("========================WRITER STARTED========================");
            string answer;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Odaberite opciju:");
                Console.WriteLine("1 - Ispis potrosnje po ID brojila");
                Console.WriteLine("2 - Ispis potrosnje po Ulici");
                Console.WriteLine("X - Izlazak iz programa");


                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        HandleGetDataForId();
                        break;
                    case "2":
                        HandleGetDataForStreet();
                        break;


                }

            } while (!answer.ToUpper().Equals("X"));
        }


        void HandleGetDataForId()
        {
            
            Console.WriteLine();
            IReports reports = new ReportsImpl();

            Console.WriteLine("Unesite ID brojila: ");
            int BrojiloId = int.Parse(Console.ReadLine());

            try
            {
                List<DataSet> dataSets = reports.getMonthbyIdData(BrojiloId);

                reports.showDataset(dataSets);
            }
            catch(DbException db)
            {
                Console.WriteLine(db.Message);
            }
        }

        void HandleGetDataForStreet()
        {
            Console.WriteLine();
            IReports reports = new ReportsImpl();

            Console.WriteLine("Unesite ulicu: ");
            string ulica = Console.ReadLine();

            try
            {
                List<DataSet> dataSets = reports.getMonthbyStreetData(ulica);

                reports.showDataset(dataSets);
            }
            catch (DbException db)
            {
                Console.WriteLine(db.Message);
            }

        }
    }
}

