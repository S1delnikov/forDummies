using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataTier
{
    public class Билет
    {
        public string Транспорт { get; set; }
        public string Пункт_отправки { get; set; }
        public string Пункт_назначения { get; set; }
        public float Цена { get; set; }
        public int КолВоБилетовНаАвтобус { get; set; }
        public double СуммаБилетовНаСамолёт { get; set; }

        public double СамыйДорогойБилет { get; set; }
    }

    public class ВсеБилеты
    {
        public static int countBus = 0;
        public static double sumAirplaneTickets = 0;
        public static double mostExpensiveTicket = 0;
        private static string path = @"Source.txt";
        private static char devider = '*';
        public static List<Билет> ПолучитьВсеБилеты()
        {
            List<Билет> list1 = new List<Билет>();
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            string line = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                string[] items = line.Split(devider);
                var item = new Билет()
                {
                    Транспорт = items[0].Trim(),
                    Пункт_отправки = items[1].Trim(),
                    Пункт_назначения = items[2].Trim(),
                    Цена = Convert.ToSingle(items[3])
                };
                list1.Add(item);
            }
            foreach (Билет tic in list1)
            {
                if (tic.Транспорт == "Автобус")
                    countBus++;
                if (tic.Транспорт == "Самолёт")
                    sumAirplaneTickets += (double)tic.Цена;
                if (mostExpensiveTicket < tic.Цена)
                    mostExpensiveTicket = tic.Цена;
            }
            foreach (Билет tic in list1)
            {
                tic.КолВоБилетовНаАвтобус = countBus;
                tic.СуммаБилетовНаСамолёт = sumAirplaneTickets;
                tic.СамыйДорогойБилет = mostExpensiveTicket;
            }
            return list1;
        }

        //private static int ПосчитатьАвтобусныеРейсы()
        //{

        //}

        public static void СохранитьВсеТовары(List<Билет> билеты)
        { }
    }
}