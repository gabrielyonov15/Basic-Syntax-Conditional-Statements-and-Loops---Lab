﻿using System.Globalization;

namespace _13.HolidaysTwoDates
{
    internal class Program
    {
        static void Main(string[] args)
            {
                var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
                var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
                if (endDate < startDate)
                {
                    Console.WriteLine(0);
                    return;
                }
                var holidaysCount = 0;
                for (var date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        holidaysCount++;
                    }
                }
                Console.WriteLine(holidaysCount);
            }
        }
    }
