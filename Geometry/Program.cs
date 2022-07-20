Random random = new Random();
int minRandom = 1;
int maxRandom = 4;
int an = 0;
int k;
do
{
    int fig = random.Next(minRandom, maxRandom);
    switch (fig)
    {
        case 1:
            an = 4;
            int number = 7;
            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == 6)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 1 && i <= 5)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (j == 0 || j == 6)
                        {
                            Console.Write("*");
                        }
                        else if (j >= 1 && j <= 5)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            break;

        case 2:
            an = 3;
            for (int x = 1; x <= 5; x++)
            {
                for (int y = x; y < 5; y++)
                {
                    Console.Write(" ");
                }
                for (int y = 1; y <= (2 * x - 1); y++)
                {
                    if (x == 5 || y == 1 || y == (2 * x - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            break;
        case 3:
            an = 8;
            double dist;
            for (int i = 0; i <= 2 * 3; i++)
            {
                for (int j = 0; j <= 2 * 3; j++)
                {
                    dist = Math.Sqrt((i - 3) *
                            (i - 3) + (j - 3)
                                        * (j - 3));
                    if (dist > 3 - 0.5 &&
                                   dist < 3 + 0.5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine("");
            }
            break;
    }
    Console.WriteLine("How many angles figura has ?");
    int num = int.Parse(Console.ReadLine());
    try
    {
        if (num != an)
        {
            throw new Exception($"You aren`t right, number of angels is {an}");
        }
        else
        {
            Console.WriteLine("You are right");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Errore: {e.Message}");
    }

    Console.WriteLine("Input key - 1 - to continue, 0 - to exit");
    k = int.Parse(Console.ReadLine());
} while (k == 1);
return;