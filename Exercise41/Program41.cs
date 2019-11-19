using System;
using System.Globalization;


namespace Exercise41
{
    class Program41
    {
        static void Main(string[] args)
        {
            string[] months = new string[] {"January","Februari","Mars","April",
            "May", "June", "July", "September", "October", "November", "December"};

            var str1 = "2014-01-22 12:00:00";
            var str2 = "20113-02-10 15:23>00";

            string[] str_1 = str1.Split('-',' ');
            string[] str_2 = str2.Split('-',' ');

            var year1 = str_1[0];
            var month1 = str_1[1];
            var day1 = str_1[2];

            var month_1 = months[int.Parse(month1) - 1];

            var year2 = str_2[0];
            var month2 = str_2[1];
            var day2 = str_2[2];

            var month_2 = months[int.Parse(month2) - 1];

            Console.WriteLine($"{day1}nd {month_1} {year1}");
            Console.WriteLine($"{day2}nd {month_2} {year2}");
        }
    }
}
