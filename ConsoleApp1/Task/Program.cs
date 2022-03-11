using System;
using System.Text;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
        L1: Console.Write("Verilmiş 4 tapşırıqdan birini yoxlamaq üçün 1-4 aralığında rəqəm daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                default:
                    Console.WriteLine("Daxil edilmiş nömrə düzgün deyil\n" +
                        "Təkrar yoxlayın");
                    goto L1;                    
            }

        }
        static void Task1()
        {
            Console.Write("Birinci rəqəmi daxil edin: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ikinci rəqəmi daxil edin: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Division(num1, num2));
        }
        static void Task2()
        {
            Console.Write("Bir soz daxil edin: ");
            string str = Console.ReadLine();

            Console.Write("Bir rəqəm daxil edin: ");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Repeat(str, num1)); 
        }
        static void Task3()
        {
            ///Array verilib ki n sayda reqem daxil edile bilsin
            Console.Write("Rəqəmlərin sayın daxil edin: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[number];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Rəqəm daxil edin: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(Sum(arr)); 
        }
        static void Task4()
        {

        }

        /// <summary>
        /// Bir method olsun iki parametr qəbul etsin və bu parametrlərdən birincini ikinciyə bölüb nəticəni geri qaytarsın.
        /// </summary>
        /// <param name="num1">Birinci eded</param>
        /// <param name="num2">Ikinci eded</param>
        /// <returns></returns>
        static double Division (double num1, double num2)
        {
            return num1 / num2;
        }
        /// <summary>
        /// Repeat deyə bir method olsun və iki parametr qəbul etsin 
        /// biri "word" digəri "count" yəni bu şəkildə 
        /// "Repeat(string word, int count)" bu method göndərilən 
        /// word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın.        
       /// </summary>
       /// <param name="word"></param>
       /// <param name="count"></param>
       /// <returns></returns>
        static string Repeat(string word, int count)
        {
            string returnWord = word;
            
            while (count>1)
            {
                returnWord +=word;
                count--;
            }
            
            return returnWord;
        }
        /// <summary>
        /// Bir method olsun göndərilən "n" sayda ədədin hamsını toplayıb geri qaytarsın.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int Sum (int [] num)
        {
            int sum = 0;
            foreach (int numItem in num)
            {
                sum+=numItem;   
            }
           return sum;
        }
        static double Sahe()
        {
            double s = 0;
            return s;
        }
    }
}
