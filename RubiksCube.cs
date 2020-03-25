using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube
{
    class RubiksCube
    {

        public string color;
        public int size;
        public string symbol;

        public void DrawOnConsole()
        {
            if(color=="rouge")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color=="bleu")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color=="vert")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            string symbol2 = "■";
           
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size ; j++)
                {
                    Console.Write(""+symbol2);
                   
                }
                Console.WriteLine();
            }
        }


    }
}
