using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab1

{
    class Part2

    {
        public DateTime GetDates(int dat_num)
        {
            bool validUserInput = false;
            DateTime date_out = new DateTime();

            bool p_result = false;

            while (validUserInput == false)

            {
                Console.Write(" enter date " + dat_num.ToString() + " in format MM/dd/yyyy:");
                String date1_str = Console.ReadLine();

                p_result = DateTime.TryParseExact(date1_str, "MM/dd/yyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date_out);
                //write date specific way

                if (p_result)

                {
                    validUserInput = true;
                }
                else
                {
                    System.Console.WriteLine("invalid input");
                }
            }//end while

            return date_out;
        }
        static void Main(string[] args)
        {
            Part2 p2 = new Part2();
            DateTime date1 = p2.GetDates(1);
            DateTime date2 = p2.GetDates(2);

            System.Console.WriteLine("difference between date1 and date2 in days=" + (date2 - date1).TotalDays.ToString());
            System.Console.WriteLine("difference between date1 and date2 in hours=" + (date2 - date1).TotalHours.ToString());
            System.Console.WriteLine("difference between date1 and date2 in minutes=" + (date2 - date1).TotalMinutes.ToString());
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
