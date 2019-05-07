using System;

namespace Lab_Almost_Chess
{
    class Program

    {

        static void Main(string[] args)
        {

            string[][] grid = new string[8][];
            bool GoForward = true;

            void designBoard()
            {

                for (int i = 0; i < 8; i++)
                {
                    grid[i] = new string[8];

                    for (int j = 0; j < 8; j++)
                    {
                        grid[i][j] = "X";
                    }
                }

                for (int i = 2; i < 6; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        grid[i][j] = " ";
                    }
                }
                PrintBoard();

                PromptUser();
              }
                void PrintBoard()

                {
                    Console.Clear();
                    Console.WriteLine("    0  1  2  3  4  5  6  7");

                    for (int i = 0; i < 8; i++)
                    {
                        Console.WriteLine(" <-------------------------->");
                        Console.Write(i + " ");
                        Console.Write("|");
                        for (int j = 0; j < 8; j++)
                        {
                            Console.Write("|" + grid[i][j] + "|");
                        }
                        Console.Write("|");
                        Console.WriteLine();

                    }
                    Console.WriteLine(" <-------------------------->");
                }

                void PromptUser()
                {
                    Console.Write("Enter  target X coordinate between 0 and 7 : ");
                    int targetX = int.Parse(Console.ReadLine());

                    while (targetX < 0 || targetX > 7)
                    {
                        Console.WriteLine("Stop!! You have typed an Inaccurate data this board will reset ..... Press any key to continue...");
                        Console.ReadKey();
                        designBoard();
                    }

                    Console.Write("Enter a target Y coordinate between 0 and 7 : ");
                    int targetY = int.Parse(Console.ReadLine());

                    while (targetY < 0 || targetY > 7)
                    {
                        Console.WriteLine("Stop!! You have typed an Inaccurate data this board will reset ..... Press any key to continue...");
                        Console.ReadKey();
                        designBoard();
                    }

                    Console.Write("Enter a destination X coordinate between 0 and 7 : ");
                    int destinationX = int.Parse(Console.ReadLine());
                    Console.Write("Enter a destination Y coordinate between 0 and 7 : ");
                    int destinationY = int.Parse(Console.ReadLine());

                    grid[targetX][targetY] = " ";
                    grid[destinationX][destinationY] = "X";

                    PrintBoard();
                    moveForward();

                }

                bool moveForward()
                {
                    Console.Write("Would you like to continue? (y/n) : ");


                    if (Console.ReadLine().ToLower().Contains("y"))
                    {
                        return GoForward = true;
                    }
                    else
                    {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Environment.Exit(0);
                    return GoForward = false;                  
                    }
                }

                designBoard();

                while (GoForward == true)
                {
                    PrintBoard();
                    PromptUser();
                }

                System.Threading.Thread.Sleep(50000);
            }

        }
   
}
