using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Lib;
namespace BlackJack.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Your budget: ");
            //int budget = Convert.ToInt32(Console.ReadLine());

            Game g = new Game();
            g.Start("Name", 1000);
           
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1...... HIT");
                Console.WriteLine("2...... STAND");
                Console.WriteLine("3...... SPLIT");
                Console.WriteLine("4...... INSURE");
                Console.WriteLine("5...... SURRENDER");
                Console.Write("Your choice => ");
                int choice = Convert.ToInt32(Console.ReadLine());
                g.MainGame(choice);
            }
            

           // Console.ReadKey();
        }
    }
}
