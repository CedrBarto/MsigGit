using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube
{
    class Program
    {
        static void Main(string[] args)
        {
            string color;
            int size;
            int rubikscube1 = 0;

          
            Console.Write("Combien voulez-vous de cube entre 1 et 10 ?: ");
            rubikscube1 = Convert.ToInt32(Console.ReadLine());
            RubiksCube[] tab = new RubiksCube[rubikscube1];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Quelle couleur du cube voulez-vous entre rouge, bleu et vert ?: ");
                color = Console.ReadLine();
                RubiksCube rubikscube = new RubiksCube();
                rubikscube.color = color;
                Console.Write("Quelle dimension du cube voulez-vous ? (ex: 3 = 3x3): ");
                size = Convert.ToInt32(Console.ReadLine());
                rubikscube.size = size;
                rubikscube.symbol = "■";
                rubikscube.DrawOnConsole();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Votre/vos cube(s) ont été crées");
            Console.WriteLine("Appuyer sur ENTER pour fermer le programme");

    
            Console.ReadLine();
        }
    }
}
