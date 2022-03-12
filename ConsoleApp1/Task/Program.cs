using System;
using System.Text;

namespace Task
{


    internal class Program
    {
        static void Main(string[] args)
        {
            try
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
            catch (Exception)
            {

                Console.WriteLine("Problem var.");
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
        L2: Console.Write("Çevrənin sahəsi üçün 1\n" +
                "Düzbucaqlının sahəsi üçün 2\n" +
                "Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi 3 düyməsin sıxın  ");
            byte a=Convert.ToByte(Console.ReadLine());
                
            switch (a)
            {
                case 1:
                    Console.Write("Radius daxil et: ");
                    double r=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Sahe(r)); 
                    break;
                case 2:
                    Console.Write("Ədəd daxil edin:");
                    double num1=Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ədəd daxil edin:");
                    double num2 =Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Sahe(num1, num2));
                    
                    break;
                case 3:
                    Console.Write("Ədəd daxil edin:");
                    double num3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ədəd daxil edin:");
                    double num4 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ədəd daxil edin:");
                    double num5 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Radius daxil et: ");
                    double r1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Sahe(num3, num4, num5, r1));
                    
                    break;
                default:
                    Console.WriteLine("Daxil edilmiş nömrə düzgün deyil\n" +
                      "Təkrar yoxlayın");
                    goto L2;
                    
            }
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

        /// <summary>
        /// Çevrənin sahəsi - S = p*r² (p=3). 
        /// </summary>
        /// <returns></returns>
        static double Sahe(double r)
        {
            double s = 3*r*r;
            return s;
        }
        /// <summary>
        /// Düz bucaqlının sahəsi - S = a* b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sahe(double a, double b)
        {
            double s = a * b;
            return s;
        }
        /// <summary>
        /// uçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p* r; p=(a+b+c)/2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        static double Sahe(double a, double b, double c, double r)
        {
            double s = (a + b +c)/2*r;
            return s;
        }
    }
}
