using ConsoleApp23.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №1");

                            double e, f, y;

                            Console.Write("Введите е: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите f: ");
                            f = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task1 task1 = new Task1(e, f, y);
                            task1.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №2");

                            double d, y;

                            Console.Write("Введите d: ");
                            d = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task2 task2 = new Task2(d, y);
                            task2.PrintSolution();

                            Console.ReadKey();
                        }
                        break;
                        
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №3");

                            double e, y, k;

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task3 task3 = new Task3(e, y, k);
                            task3.PrintSolution();
                            
                            Console.ReadKey();
                        }
                        break;

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №4");

                            double w, y;

                            Console.Write("Введите e: ");
                            w = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите k: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task4 task4 = new Task4(w, y);
                            task4.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №5");

                            double e, y, a, t;

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите a: ");
                            a = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Task5 task5 = new Task5(e, y, a, t);
                            task5.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №6");

                            double i, y;

                            Console.Write("Введите e: ");
                            i = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task6 task6 = new Task6(i, y);
                            task6.PrintSolution();
                            
                            Console.ReadKey();
                        }
                        break;

                    case "7":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №7");

                            double m, y;

                            Console.Write("Введите m: ");
                            m = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task7 task7 = new Task7(m, y);
                            task7.PrintSolution();
                            
                            Console.ReadKey();
                        }
                        break;

                    case "8":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №8");

                            double t, y;

                            Console.Write("Введите e: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task8 task8 = new Task8(t, y);
                            task8.PrintSolution();
                            
                            Console.ReadKey();
                        }
                        break;

                    case "9":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №9");

                            double y, w;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите w: ");
                            w = Convert.ToDouble(Console.ReadLine());

                            Task9 task9 = new Task9(w, y);
                            task9.PrintSolution();
                           
                            Console.ReadKey();
                        }
                        break;

                    case "10":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №10");

                            double y, t;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Task10 task10 = new Task10(t, y);
                            task10.PrintSolution();
                            
                            Console.ReadKey();
                        }
                        break;

                    case "11":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №11");

                            double y, n;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите n: ");
                            n = Convert.ToDouble(Console.ReadLine());

                            Task11 task11 = new Task11(n, y);
                            task11.PrintSolution();
                            
                            Console.ReadKey();
                        }
                        break;

                    case "12":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №12");

                            double y, t;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Task12 task12 = new Task12(t, y);
                            task12.PrintSolution();
                            
                            Console.ReadKey();
                        }
                        break;

                    case "13":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №13");

                            double y, e, h;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите h: ");
                            h = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Task13 task13 = new Task13(y, e, h);
                            task13.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "14":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №14");

                            double y, e, h;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите h: ");
                            h = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Task14 task14 = new Task14(y, e, h);
                            task14.PrintSolution();
                            
                            Console.ReadKey();
                        }
                        break;

                    case "15":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №15");

                            double y, j;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите j: ");
                            j = Convert.ToDouble(Console.ReadLine());

                            Task15 task15 = new Task15(y, j);
                            task15.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "16":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №16");

                            double t, e, r, y;

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите r: ");
                            r = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task16 task16 = new Task16(t, e, r, y);
                            task16.PrintSolution();

                            Console.ReadKey();
                        }
                        break;


                    case "17":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №17");

                            double y, n;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите n: ");
                            n = Convert.ToDouble(Console.ReadLine());

                            Task17 task17 = new Task17(y, n);
                            task17.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "18":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №18");

                            double y, k;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Task18 task18 = new Task18(y, k);
                            task18.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "19":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №19");

                            double y, q;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите q: ");
                            q = Convert.ToDouble(Console.ReadLine());

                            Task19 task19 = new Task19(y, q);
                            task19.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "20":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №20");

                            double t, l, y, e;

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите l: ");
                            l = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Task20 task20 = new Task20(t, l, y, e);
                            task20.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "21":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №21");

                            double k, p, x, d;

                            Console.Write("Введите k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите p: ");
                            p = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите d: ");
                            d = Convert.ToDouble(Console.ReadLine());

                            Task21 task21 = new Task21(k, p, x, d);
                            task21.PrintSolution();


                            Console.ReadKey();
                        }
                        break;

                    case "22":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №22");

                            double y, t;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Task22 task22 = new Task22(y, t);
                            task22.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "23":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №23");

                            double y, e, d;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите d: ");
                            d = Convert.ToDouble(Console.ReadLine());

                            Task23 task23 = new Task23(y, e, d);
                            task23.PrintSolution();

                            Console.ReadKey();
                        }
                        break;


                    case "24":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №24");

                            double k, e, y;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Task24 task24 = new Task24(k, e, y);
                            task24.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "25":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №25");

                            double c, t;

                            Console.Write("Введите c: ");
                            c = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            t = Convert.ToDouble(Console.ReadLine());


                            Task25 task25 = new Task25(c, t);
                            task25.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "26":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №26");

                            double u, y;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите u: ");
                            u = Convert.ToDouble(Console.ReadLine());

                            Task26 task26 = new Task26(u, y);
                            task26.PrintSolution();


                            Console.ReadKey();
                        }
                        break;

                    case "27":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №27");

                            double p, y;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите t: ");
                            p = Convert.ToDouble(Console.ReadLine());


                            Task27 task27 = new Task27(p, y);
                            task27.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "28":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №28");

                            double v, y, e;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите v: ");
                            v = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Task28 task28 = new Task28(v, y, e);
                            task28.PrintSolution();

                            Console.ReadKey();

                        }
                        break;

                    case "29":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №29");

                            double h, y, e;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите h: ");
                            h = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Task29 task29 = new Task29(h, y, e);
                            task29.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "30":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №30");

                            double p, y, e;

                            Console.Write("Введите y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите p: ");
                            p = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Task30 task30 = new Task30(p, y, e);
                            task30.PrintSolution();

                            Console.ReadKey();
                        }
                        break;


                    default:
                        Console.WriteLine("Выберите корректное задание!");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}
