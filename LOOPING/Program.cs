using System;
class Contoh_Looping
{
    static void Main()
    {
        Console.Clear();
        int i;
        i = 1; //nilai awal, preparation
        Console.WriteLine("Contoh Latihan Looping dengan WHILE");
        while (i <= 9) // nilai akhir, decision
        {
            Console.Write(i + " ");
            i = i + 1;//counter, proses
        }
    }
}
