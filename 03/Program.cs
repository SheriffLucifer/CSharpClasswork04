GetRandomNum();

void GetRandomNum()
{
    Console.Write("[");
    for (int i = 8; i > 0; i--)
    {
        int num = new Random().Next(0, 2);
        Console.Write($"{num}");
        if (i > 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}