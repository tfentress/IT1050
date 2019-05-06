using System;
using System.Collections.Generic;
namespace Almost_Chess_Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ReadyForMore = true;
            string[][] grid = new string[8][];

            void SetBoard()
            {
                for (int i = 0; i < 8; i++)
                {
                    grid[i] = new string[8];

                    for (int j = 0; j < 3; j++)
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

                void PromptUser()
                {
                    Console.Write("Enter a target X coordinate between 0 and 7 : ");
                    int inputX = int.Parse(System.Console.ReadLine());

                    while (inputX < 0 || inputX > 7)
                    {
                        Console.WriteLine("NO!! Incorrect input. Resetting board. Press any key to continue...");
                        Console.ReadKey();
                        SetBoard();
                    }

                    Console.Write("Enter target Y coordinate between 0 and 7 : ");
                    int inputY = int.Parse(System.Console.ReadLine());

                    while (inputY < 0 || inputY > 7)
                    {
                        Console.WriteLine("NO!! Incorrect input. Resetting board. Press any key to continue...");
                        Console.ReadKey();
                        SetBoard();
                    }
                    Console.Write("Enter destination X coordinate between 0 and 7 : ");
                    int setX = int.Parse(System.Console.ReadLine());


                    Console.Write("Enter destination Y coordinate between 0 and 7 : ");
                    int setY = int.Parse(System.Console.ReadLine());

                    grid[inputX][inputY] = " ";
                    grid[setX][setY] = "X";

                    PrintBoard();
                    StartOver();
                }

                bool StartOver()
                {
                    Console.Write("GameOver!!!!! ...Do you want to try again? (y/n) : ");
                    if (Console.ReadLine().ToLower().Contains("y"))
                    {
                        return ReadyForMore = true;
                    }
                    else
                    {
                        return ReadyForMore = false;
                    }
                }
                void PrintBoard()
                {
                    Console.WriteLine();
                    Console.Clear();
                    System.Console.WriteLine("    0  1  2  3  4  5  6  7");

                    for (int i = 0; i < 8; i++)
                    {
                        System.Console.WriteLine(" <-------------------------->");
                        System.Console.Write(i + " ");
                        System.Console.Write("|");
                        for (int j = 0; j < 8; j++)
                        {
                            System.Console.Write("|" + grid[i][j] + "|");
                        }

                        for (int row = 0; row < 8; row++)
                        {
                            printDivider();


                            printRow(row);
                        }

                        printDivider();
                    }

                    void printRow(int row)
                    {
                        for (int col = 0; col < 8; col++)
                        {
                            bool shouldHaveX = row <= 1 || row >= 6;
                            string text = shouldHaveX ? " | X" : " |  ";
                            Console.Write(text);
                        }

                        Console.WriteLine(" |");
                    }

                    void printDivider()
                    {
                        Console.WriteLine(" +-------------------------------+");
                    }
                    SetBoard();

                    while (ReadyForMore == true)
                    {
                        PrintBoard();
                        PromptUser();
                    }

                }
            }
        }
        }
     
}
   

