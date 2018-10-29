using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker firstWorker = new Worker("Tazhibek", "Aknur"); 
            Worker secondWorker = new Worker("Abdimash", "Dimash"); 
            Worker thirdWorker = new Worker("Abdishev", "Miras"); 
            Worker fourthWorker = new Worker("Orazbekova", "Balym"); 
            Worker fifthWorker = new Worker("Asmiyeva", "Inkara");

            List<Worker> workers = new List<Worker>(){ firstWorker, secondWorker, thirdWorker, fourthWorker, fifthWorker }; 
            Team team = new Team(workers);
            House house = new House();

            Console.WriteLine("Выберите: ");
            Console.WriteLine("1 - Постройка дома ");
            Console.WriteLine("2 - Отчет ");

            string chooseMenu = Console.ReadLine();
            if (int.Parse(chooseMenu) == 1) {
                Console.WriteLine("Построено: ");
                Console.WriteLine(house.Walls.Count + " - стен ");
                Console.WriteLine(house.Windows.Count + " - стен ");
                if (house.Roof.count == 0)
                {

                }
                else {
                    Console.WriteLine("Имя материала: ");
                    string materialName = Console.ReadLine();

                    
                }
            }
            //Console.WriteLine(" ");
            //Console.WriteLine(" ");



        }
    }
}
