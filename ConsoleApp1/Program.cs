using System;

namespace Lesson1
{
    class Program
    {

        static void Main(string[] args)
        {
            
            bool success;

            double purse;
            do
            {
                Console.WriteLine("Введите остаток средств до зарплаты в рублях");
                success = double.TryParse(Console.ReadLine(), out purse);
            } while (!success);

            double theSalary;
            do
            {
                Console.WriteLine("Через сколько дней зарплата?");
                success = double.TryParse(Console.ReadLine(), out theSalary);
            } while (!success);

            double perDay = (purse / theSalary);
            Console.WriteLine($"В день нужно тратить {perDay} рублей");
            
            while (purse > 0)
            {
                double spending;
                do
                {
                    Console.WriteLine("Сколько вы планируете потратить?");
                    success = double.TryParse(Console.ReadLine(), out spending);
                } while (!success);


                if (spending > purse)
                {
                    Console.WriteLine("Денег не хватит");
                    Console.WriteLine($"Осталось {purse}"); ;
                }
                else if (spending <= purse)
                {
                    purse -= spending; 
                    perDay = (purse / theSalary);
                    
                    Console.WriteLine($"После покупки осталось {purse} рублей");

                    if (perDay > 0 )
                    {
                        Console.WriteLine($"В день нужно тратить {perDay} рублей");
                    }
                }
            }

            Console.WriteLine("Деньги закончились");


            Console.ReadKey();
        }

    }
}