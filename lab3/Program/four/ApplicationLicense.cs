using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.four
{
    internal class ApplicationLicense
    {
        public int ProKey { get; set; } = 54321;
        public int TrialKey { get; set; } = 12345;

        public void Main()
        {
            int key;
            int num;
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("~~~~~~~~~~~~Меню~~~~~~~~~~~~");
                Console.WriteLine("1. Ввести існуючий trial ключ");
                Console.WriteLine("2. Ввести існуючий pro ключ");
                Console.WriteLine("3. Отримати безкоштовний ключ");
                Console.WriteLine("         0. Вихід");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("Введіть цифру для виконання операції: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (num)
                {
                    case 1:
                        Console.Write("Введіть trial ключ: ");
                        key = Convert.ToInt32(Console.ReadLine());
                        if(key == TrialKey)
                        {
                            bool ex = true;
                            int tmp;
                            while (ex)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                AllowTrial();
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.WriteLine("~~~~~Меню~~~~~");
                                Console.WriteLine("1. Дія перша ");
                                Console.WriteLine("2. Дія друга");
                                Console.WriteLine("   0. Вихід");
                                Console.WriteLine("~~~~~~~~~~~~~~~");
                                Console.Write("Введіть цифру для виконання операції: ");
                                tmp = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();

                                if (tmp == 0) ex = false;
                            }
                        }
                        else
                            Console.WriteLine("Ключ не вірний");
                        break;

                    case 2:
                        Console.Write("Введіть pro ключ: ");
                        key = Convert.ToInt32(Console.ReadLine());
                        if (key == ProKey)
                        {
                            bool ex = true;
                            int tmp;
                            while (ex)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                AllowPro();
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.WriteLine("~~~~~Меню~~~~~");
                                Console.WriteLine("1. Дія перша ");
                                Console.WriteLine("2. Дія друга");
                                Console.WriteLine("   0. Вихід");
                                Console.WriteLine("~~~~~~~~~~~~~~~");
                                Console.Write("Введіть цифру для виконання операції: ");
                                tmp = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();

                                if (tmp == 0) ex = false;
                            }
                        }
                        else
                            Console.WriteLine("Ключ не вірний");
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        AllowCommond();
                        Console.ResetColor();
                        Console.WriteLine();
                        break;

                    case 0:
                        exit = false;
                        break;

                    default:
                        break;
                }
            }
            
        }
        public void AllowTrial()
        {
            Console.WriteLine("Триальний режим");
        }

        public void AllowCommond()
        {
            Console.WriteLine("Безкоштовна версія");
        }

        public void AllowPro()
        {
            Console.WriteLine("Платна версія");
        }
    }
}
