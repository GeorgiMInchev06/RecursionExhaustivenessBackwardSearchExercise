﻿using System;


int totalSolutions = 0;

Console.WriteLine("Въведете размер на дъската (n):");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете начална позиция (x):");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Въведете начална позиция (y):");
int y = int.Parse(Console.ReadLine());

int[,] board = new int[n, n];

void Solve(int[,] board, int x, int y, int count)
{
    if (x >= 0 && x < board.GetLength(0) && y >= 0 && y < board.GetLength(1) && board[x, y] == 0)
    {
        board[x, y] = count;
    }
    else
    {
        return;
    }

    if (count == board.Length)
    {
        PrintBoard(board);
        board[x, y] = 0;
        return;
    }

    Solve(board, x + 1, y + 2, count + 1);
    Solve(board, x - 1, y + 2, count + 1);
    Solve(board, x + 2, y + 1, count + 1);
    Solve(board, x - 2, y + 1, count + 1);
    Solve(board, x + 1, y - 2, count + 1);
    Solve(board, x - 1, y - 2, count + 1);
    Solve(board, x + 2, y - 1, count + 1);
    Solve(board, x - 2, y - 1, count + 1);

    board[x, y] = 0;
}

void PrintBoard(int[,] board)
{
    totalSolutions++;
    for (int i = 0; i < board.GetLength(0); i++)
    {
        for (int j = 0; j < board.GetLength(1); j++)
        {
            Console.Write("{0,3} ", board[i, j]);
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

Solve(board, x, y, 1);

Console.WriteLine($"Total Solutions: {totalSolutions}");