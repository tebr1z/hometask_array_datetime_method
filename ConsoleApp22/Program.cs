using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, World!");

            #region Task 2
            Console.WriteLine("Dogum Gunnuzu yazin Gun/Ay/İl olaraq daxil edin");

            DateTime DogumTarixi = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            int yas = (DateTime.Now.Year - DogumTarixi.Year;
            
            string burc = BurcHes(DogumTarixi.Month, DogumTarixi.Day);
            Console.WriteLine("Burcunuz: " + burc);
            Console.WriteLine("Yasiniz " + yas);

            #endregion

            #region Task 3 Void
            //Console.WriteLine("Ili daxil edin");

            //int  year = Convert.ToInt32(Console.ReadLine());
            //ChekLeap(year);
            #endregion
        }



        #region Task 2


        static string BurcHes(int ay, int gun)
        {
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
                return "Qoch";
            else if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 21))
                return "Buga";
            else if ((ay == 5 && gun >= 22) || (ay == 6 && gun <= 22))
                return "Ekizler";
            else if ((ay == 6 && gun >= 23) || (ay == 7 && gun <= 22))
                return "Xerceng";
            else if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
                return "Shir";
            else if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22))
                return "Qiz";
            else if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22))
                return "Terezi";
            else if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 21))
                return "Eqreb";
            else if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21))
                return "Oxatan";
            else if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 20))
                return "Oglaq";
            else if ((ay == 1 && gun >= 21) || (ay == 2 && gun <= 19))
                return "Dolca";
            else
                return "Baliq";




        }

        #endregion


        #region Task 3 
        //static void ChekLeap (int year)
        //{
        //    bool IsleapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        //    if (IsleapYear)
        //    {
        //        Console.WriteLine("Leap ilidir");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Leap ili deyil");
        //    }
        //}

        #endregion



    }
}
