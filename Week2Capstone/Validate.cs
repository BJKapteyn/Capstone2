using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Capstone
{
    class Validate
    {
        public static void OptionValidate(string sNum, out int x)
        {
            int num;
            try
            {
                num = Convert.ToInt32(sNum);
                if(num >= 1 && num <= 5)
                {
                    x = num;
                    return;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a positive number 1-5.");
                x = 0;
                OptionValidate(Console.ReadLine(), out x);
            }
        }

        public static void IsInRange(string choice, int minVal, int maxVal, out int x)
        {
            int num;
            try
            {
                num = Convert.ToInt32(choice);
                if (num >= minVal && num <= maxVal)
                {
                    x = num;
                    return;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Please enter a number {minVal}-{maxVal}.");
                x = 0;
                IsInRange(Console.ReadLine(), minVal, maxVal, out x);
            }
        }

        public static void IsDate(string choice, out string x)
        {
            Regex date = new Regex(@"[0-9]{2}/[0-9]{2}/[0-9]{4}");
            string[] sSplitDate = new string[3];
            int[] numSplitDate = new int[3];

            try
            {
                if(date.IsMatch(choice))
                {
                    sSplitDate = choice.Split('/');
                    for (int i = 0; i < 3; i++)
                    {
                        numSplitDate[i] = Convert.ToInt32(sSplitDate[i]);
                    }
                    if(!(numSplitDate[0] >= 1 && numSplitDate[0] <= 12))
                    {
                        throw new Exception("Please enter month 1-12");
                    }
                    if (!(numSplitDate[1] >= 1 && numSplitDate[1] <= 31))
                    {
                        throw new Exception("Please enter day 1-31");
                    }
                    if (!(numSplitDate[2] >= 1900 && numSplitDate[2] <= 2020))
                    {
                        throw new Exception("Please enter year 1900-2020");
                    }
                    x = choice;
                }
                else
                {
                    throw new Exception("Please format date as MM/DD/YYYY");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter date MM/DD/YYYY");
                IsDate(Console.ReadLine(), out x);


            }
        }

        public static void YayOrNay()
        {

        }
    }
}
