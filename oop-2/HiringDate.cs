using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    internal class HiringDate
    {
        private int day;
        private int year;
        private int month;
        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31)
                    day = value;
                else
                    Console.WriteLine("enter a valid day between 1 and 31 ");
            }

        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && (value <= 12))
                    month = value;
                else
                    Console.WriteLine("enter a valid month between 1 and 12");
            }
        }
        
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1 && (value <= 2025))
                    year = value;
                else
                    Console.WriteLine("enter a valid month between 1 and 2025");
            }
        }
        public HiringDate(int day ,int month,int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
