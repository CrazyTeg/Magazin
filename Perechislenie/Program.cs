using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perechislenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueOrders = new Queue<int>();    //  Создаем пустую очередь
            bool exitFlag = true;
            while (exitFlag)
            {
                Console.WriteLine("Для размещения заказа введите: add ");
                Console.WriteLine("Для выполнения заказа введите: run ");
                Console.WriteLine("Для выхода введите: exit ");
                var optionExec = Console.ReadLine();

                if (optionExec == "add" & queueOrders.Count < 10)        //  Задаем лимит очереди
                {
                    Console.WriteLine("Введите номер заказа: ");
                    var inputNumberOrder = Console.ReadLine();

                    if (Int32.TryParse(inputNumberOrder, out int numberOrder))
                    {
                        queueOrders.Enqueue(numberOrder);                         // Добавляем заказ в очередь
                        Console.WriteLine("Количество заказов в очереди {0}", queueOrders.Count);  // Выводим размер очереди
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(">>> Некорректный ввод, введите номер: <<<");
                    }
                }

                else if (optionExec == "run")
                {
                    if (queueOrders.Count == 0) { Console.WriteLine("В очереди заказов нет."); }
                    else
                    {
                        int v = queueOrders.Dequeue();     //  Удаляем заказ из очереди

                        Console.WriteLine("Выполнен заказ №{0}", v);   //  Выводим удаленный элемент на экран
                        Console.WriteLine();
                        Console.WriteLine("Количество заказов в очереди {0}", queueOrders.Count);
                        Console.WriteLine();
                    }
                }
                else if (optionExec == "exit")
                {
                    exitFlag = false;
                }
                else if (queueOrders.Count >= 10)
                {
                    Console.WriteLine("Лимит заказов превышен!!!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(">>> Вы ввели некорректное значение. <<<");
                    Console.WriteLine();
                }
            }
        }
    }
}
