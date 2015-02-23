using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        void jerk_color(int points, int life, int j, int i)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Beep(1000, 250);
            new Program().graphical_content_displayer(points, life, j, i);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Beep(1030, 230);
            new Program().graphical_content_displayer(points, life, j, i);
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Beep(1060, 230);
            new Program().graphical_content_displayer(points, life, j, i);
            Console.Beep(1090, 230);
            Console.BackgroundColor = ConsoleColor.Gray;
            new Program().graphical_content_displayer(points, life, j, i);
            Console.Beep(1120, 230);
            Console.BackgroundColor = ConsoleColor.Red;
            new Program().graphical_content_displayer(points, life, j, i);
            Console.Beep(1150, 230);
            Console.BackgroundColor = ConsoleColor.White;
            new Program().graphical_content_displayer(points, life, j, i);
            Console.Beep(1180, 230);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            new Program().graphical_content_displayer(points, life, j, i);
            Console.Beep(1210, 230);
            Console.BackgroundColor = ConsoleColor.Yellow;
            new Program().graphical_content_displayer(points, life, j, i);
            Console.Beep(1240, 230);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            new Program().graphical_content_displayer(points, life, j, i);
            Console.Beep(1270, 230);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            new Program().graphical_content_displayer(points, life, j, i);
            Console.Beep(1300, 230);
            Console.BackgroundColor = ConsoleColor.Blue;
            new Program().graphical_content_displayer(points, life, j, i);
        }

        void sky()
        {
            Console.SetCursorPosition(55, 8);
            Console.Write("*");
            Console.SetCursorPosition(10, 10);
            Console.Write("*");
            Console.SetCursorPosition(2, 13);
            Console.Write("*");
            Console.SetCursorPosition(3, 7);
            Console.Write("*");
            Console.SetCursorPosition(14, 9);
            Console.Write("*");
            Console.SetCursorPosition(40, 9);
            Console.Write("*");
            Console.SetCursorPosition(35, 10);
            Console.Write("*");
            Console.SetCursorPosition(60, 7);
            Console.Write("*");
            Console.SetCursorPosition(30, 8);
            Console.Write("*");
            Console.SetCursorPosition(75,12);
            Console.Write("*");
            Console.SetCursorPosition(73,10);
            Console.Write("*");
        }

        void graphical_content_displayer(int Score, int life, int j, int i)
        {
            Console.Clear();
            Console.Write("\n\n\tSCORE : {0} \t\t\t\tLIFE : ", Score);
            for (int k = 0; k < life; k++)
            {
                Console.Write((char)2 + " ");
            }
            Console.Write("\n\n\tPRESS 'SPACE BAR' TO JUMP");
            sky();
            if (j >= 0)
            {
                Console.SetCursorPosition(13, 17);
            }
            else
            {
                Console.SetCursorPosition(13, 20);
            }
            Console.WriteLine("  {0}", (char)2);
            if (j >= 0)
            {
                Console.SetCursorPosition(13, 18);
            }
            else
            {
                Console.SetCursorPosition(13, 21);
            }
            Console.WriteLine(" /|\\");
            Console.SetCursorPosition(60 - (i % 60), 21);
            Console.WriteLine(" ==============");
            if (j >= 0)
            {
                Console.SetCursorPosition(13, 19);
            }
            else
            {
                Console.SetCursorPosition(13, 22);
            }
            Console.WriteLine("  |");
            Console.SetCursorPosition(60 - (i % 60), 22);
            Console.WriteLine("|  {0} {1} {0} {1} {0} {1} |",(char)2, (char)1);
            if (j >= 0)
            {
                Console.SetCursorPosition(13, 20);
                Console.WriteLine(" | |");
            }
            else
            {
                Console.SetCursorPosition(13, 23);
                Console.WriteLine(" / \\");
            }
            Console.SetCursorPosition(60 - (i % 60), 23);
            Console.WriteLine("'==o========o=='");
            Console.Write("--------------------------------------------------------------------------------");
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "JUMPUER by KARTHIK M A M";
            char c = '0';
            Console.WindowHeight = 40;
            int j = 0, Score = 0, points = 0, life = 3;
            double timer =150;
            for (int i = 0; true ; i++)
            {
                if(Score%13==0)
                {
                    points++;
                }
                j--;
                new Program().graphical_content_displayer(Score, life, j, i);
                c = '0';
                if(timer>30 && i%60 == 0)
                {
                    timer = timer - new Random().Next(1,10);
                }
                Task.Factory.StartNew(() => c = Console.ReadKey(true).KeyChar).Wait(TimeSpan.FromMilliseconds(timer));
                if (c == ' ')
                {
                    j = 20;
                }
                if (60 - (i % 60) <= 16)
                {
                    if (j < 0)
                    {
                        if (life > 0)
                        {
                            new Program().jerk_color(Score, life, j, i);
                            life--;
                            i=60;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n\t\t\tGAME OVER.....YOU ARE DEAD....!!!!!");
                            Console.WriteLine("\n\n\n\t\t\tTOTAL SCORE : {0}", Score);
                            Console.WriteLine("\n\n\n\t\t\tREGARDS KARTHIK M A M");
                            i = 60;
                            break;
                        }
                    }
                    else
                    {
                        if(60-(i%60)==1)
                            Score++;
                    }
                }
                Console.Clear();
            }
        }
    }
}
