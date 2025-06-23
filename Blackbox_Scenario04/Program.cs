using System;

class Program
{
    static void Main()
    {
        // Table-driven array berisi nama-nama hari dalam seminggu
        string[] daysOfWeek = {
            "Senin",    // index 0
            "Selasa",   // index 1
            "Rabu",     // index 2
            "Kamis",    // index 3
            "Jumat",    // index 4
            "Sabtu",    // index 5
            "Minggu"    // index 6
        };

        Console.Write("Masukkan nomor hari (1-7): ");
        if (int.TryParse(Console.ReadLine(), out int dayNumber))
        {
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                // Mengambil nama hari dari array dengan indeks dayNumber-1
                Console.WriteLine($"Hari ke-{dayNumber} adalah {daysOfWeek[dayNumber - 1]}");
            }
            else
            {
                Console.WriteLine("Nomor hari harus antara 1 sampai 7.");
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid. Masukkan angka.");
        }
    }
}
