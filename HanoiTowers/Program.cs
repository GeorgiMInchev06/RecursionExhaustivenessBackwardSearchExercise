using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Въведете броя на дисковете:");
        int discs = int.Parse(Console.ReadLine());

        SolveHanoiTowers(discs, "1", "3", "2");
    }

    static void SolveHanoiTowers(int n, string startRod, string endRod, string tempRod)
    {
        if (n == 0)
        {
            return;
        }

        SolveHanoiTowers(n - 1, startRod, tempRod, endRod);

        Console.WriteLine($"{startRod}-->{endRod}");

        SolveHanoiTowers(n - 1, tempRod, endRod, startRod);
    }
}