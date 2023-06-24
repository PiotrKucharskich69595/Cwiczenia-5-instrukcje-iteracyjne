using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int wysokosc = Convert.ToInt32(Console.ReadLine());

        RysujTrojkat(wysokosc);

        Console.ReadLine();
    }

    static void RysujTrojkat(int wysokosc)
    {
        int szerokosc = wysokosc * 2 - 1;
        int spacje = 0;

        for (int i = 0; i < wysokosc; i++)
        {
            for (int j = 0; j < spacje; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < szerokosc; j++)
            {
                Console.Write("+");
            }

            Console.WriteLine();

            spacje++;
            szerokosc += 2;
        }
    }
}