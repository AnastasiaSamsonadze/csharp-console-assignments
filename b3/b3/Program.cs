class Program
{
    public static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        string[] names = new string[N];
        int[] populations = new int[N];
        int[] participants = new int[N];
        for (int i = 0; i < N; i++)
        {
            names[i] = Console.ReadLine();
            populations[i] = Convert.ToInt32(Console.ReadLine());
            participants[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] categories = new int[7];
        for (int i = 0; i < N; i++)
        {
            if (populations[i] < 700)
            {
                categories[0] += participants[i];
            }
            else if (populations[i] >= 700 && populations[i] < 1500)
            {
                categories[1] += participants[i];
            }
            else if (populations[i] >= 1500 && populations[i] < 3000)
            {
                categories[2] += participants[i];
            }
            else if (populations[i] >= 3000 && populations[i] < 8000)
            {
                categories[3] += participants[i];
            }
            else if (populations[i] >= 8000 && populations[i] < 25000)
            {
                categories[4] += participants[i];
            }
            else if (populations[i] >= 25000 && populations[i] < 70000)
            {
                categories[5] += participants[i];
            }
            else if (populations[i] >= 70000)
            {
                categories[6] += participants[i];
            }
        }
        for (int j = 0; j < 7; j++)
        {
            Console.Write(categories[j] + " ");
        }
        int max = 0;
        int index = 0;
        for (int i = 0; i < N; i++)
        {
            if (participants[i] > max)
            {
                max = participants[i];
                index = i;
            }
        }
        Console.WriteLine("\n" + names[index]);
        Console.ReadLine();
    }
}