using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Podaj liczbe n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int liczba = 2;
        int licznik = 0;

        Console.WriteLine("Pierwsze " + n + " liczb:");

        while (licznik < n)
        {
            if (CzyLiczbaPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                licznik++;
            }

            liczba++;
        }
    }

    public static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }
}