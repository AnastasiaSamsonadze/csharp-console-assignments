// ANASTASIA SAMSONADZE WWV6IR


using System;

struct FuelData
{
    public string Date;
    public double Amount;
    public int Quantities;
}

class Program
{
    static void Main(string[] args)
    {
        const int MaxN = 100;

        FuelData[] fuelData = new FuelData[MaxN];

        // Input data
        int N = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            fuelData[i] = new FuelData
            {
                Date = input[0],
                Amount = double.Parse(input[1]),
                Quantities = int.Parse(input[2])
            };
        }

        // Subtask A
        bool exist = false;
        string when = "never";
        for (int i = 0; i < N; i++)
        {
            if (fuelData[i].Amount == 20000)
            {
                exist = true;
                when = fuelData[i].Date;
                break;
            }
        }
        Console.WriteLine($"Subtask A: {when}");

        // Subtask B
        double sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += fuelData[i].Amount;
        }
        Console.WriteLine($"Subtask B: {sum}");

        // Subtask C
        int cnt = 0;
        bool[] days = new bool[MaxN];
        for (int i = 0; i < N; i++)
        {
            if (fuelData[i].Quantities > 40)
            {
                days[i] = true;
                cnt++;
            }
        }
        Console.Write("Subtask C: ");
        if (cnt == 0)
        {
            Console.WriteLine("none");
        }
        else
        {
            for (int i = 0; i < N; i++)
            {
                if (days[i])
                {
                    Console.Write(fuelData[i].Date + " ");
                }
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
