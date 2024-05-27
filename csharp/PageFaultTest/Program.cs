using System;
using System.Diagnostics;
using System.Threading;

public class MemoryStressTest
{
    private const int ArraySize = 10000000; 
    private const int NumArrays = 10;
    private const int Iterations = 1000; 

    public static void Main(string[] args)
    {
        int pid = Process.GetCurrentProcess().Id;
        Console.WriteLine("Process ID: " + pid);

        int[][] arrays = new int[NumArrays][];

        for (int i = 0; i < NumArrays; i++)
        {
            arrays[i] = new int[ArraySize];
        }

        for (int iter = 0; iter < Iterations; iter++)
        {
            if(iter % 100 == 0) {
                Console.WriteLine("Iteration: " + (iter + 1));
            }
            
            for (int i = 0; i < NumArrays; i++)
            {
                for (int j = 0; j < ArraySize; j++)
                {
                    arrays[i][j] = j + arrays[i][j] % 10;
                }
            }

            Thread.Sleep(100); 
        }
    }
}
