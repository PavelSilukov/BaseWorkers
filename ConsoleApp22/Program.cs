using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static int defis = 50;
        static void Main(string[] args)
        {
            WorkerBase instance = new WorkerBase();
            while (true)
            {
                Console.WriteLine("Таблица рабочих");
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 -\tдобавление нового сотрудника");
                Console.WriteLine("2 -\tвывод списка работников по стажу");
                Console.WriteLine("3 -\tвывод всех работников");
                Console.WriteLine("q -\tвыход из программы");
                Console.WriteLine(new string('-', defis));

                string operation = Console.ReadLine();

                void AddWorker ()
                {
                    Console.WriteLine("Введите Имя работника:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Введите должность сотрудника");
                    string post = Console.ReadLine();


                    DateTime workStart = DateTime.Now;

                    bool flag = true;

                    while (flag)
                    {
                        Console.WriteLine("Введите дату поступления на работу в формате: xx/xx/xxxx число, месяц, год ");
                        string time = Console.ReadLine();
                        if (DateTime.TryParse(time, out workStart))
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели неверный формат даты");
                        }
                    }
                    Worker worker1 = new Worker(name, post, workStart);

                    instance.AddWorker(worker1);

                    Console.WriteLine("Чтобы добавить еще одного рабочего нажмите \"y\" или любую другую клавишу для перехода в главное меню");
                    string addWorker = Console.ReadLine();
                    if (addWorker == "y")
                    {
                        Console.WriteLine(new string('-', defis));
                        AddWorker();
                        
                    }
                    else
                    {
                        Console.Clear();
                        
                    }
                }


                switch (operation)
                {
                    case "1":
                        AddWorker();
                        break;
                                                                     
                    case "2":
                        Console.WriteLine("Введите стаж работника");
                        int experience = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Сотрудники, стаж которых больше {0} года(ов):", experience);
                        foreach (var worker in instance.GetExpeirenceWorker(experience))
                        {                  
                            Console.WriteLine("Имя - {0}, должность - {1}", worker.Name, worker.Post);
                        }
                        Console.WriteLine(new string ('-',defis));
                        Console.WriteLine("Нажмите любую клавишу для перехода в главное меню");
                        string return1 = Console.ReadLine();
                        if (return1!=null)
                        {
                            Console.Clear();
                            break;
                        }
                        break;

                     case "3":
                        Console.WriteLine("Вывод всех работников по алфавиту");
                        
                        foreach (var worker in instance.OrderWokers())
                        {
                            Console.WriteLine("Имя - {0}, должность - {1}, дата поступления на работу - {2:d}", worker.Name, worker.Post, worker.WorkStart);
                        }

                        Console.WriteLine("Нажмите любую клавишу для перехода в главное меню");
                        string return2 = Console.ReadLine();
                        if (return2 != null)
                        {
                            Console.Clear();
                            break;
                        }
                        break;

                     case "q":
                        Environment.Exit(0);
                        break;

                     default:
                        int i = 0;
                        while (i < 3)
                        {
                            Console.WriteLine("Вы ввели недопустимый символ!");
                            Console.WriteLine("Выход из программы  Вернуться в меню");
                            Console.WriteLine("      q                    r           ");
                            string sing = Console.ReadLine();
                            if (sing == "q")
                            {
                                Environment.Exit(0);
                                break;
                            }
                            else if (sing == "r")
                            {
                                Console.Clear();
                                break;
                            }
                            else { i++; }
                        }
                        Console.Clear();
                        break;
       
                }
            }
            
        }
        
        
    }
}
