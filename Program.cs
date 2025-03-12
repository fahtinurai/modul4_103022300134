using System;
using modul4_103022300134;

while (true)
{
    Console.WriteLine("Pilih menu:");
    Console.WriteLine("1. KodeProduk");
    Console.WriteLine("2. FanLaptop");
    Console.WriteLine("3. Keluar");
    Console.Write("Masukkan pilihan Anda: ");
    string pilihan = Console.ReadLine();

    switch (pilihan)
    {
        case "1":
            HandleKodeProduk();
            break;
        case "2":
            HandleFanLaptop();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
            break;
    }
}


void HandleKodeProduk()
{
    KodeProduk kodeProduk = new KodeProduk();
    Console.Write("Masukkan nama produk: ");
    string elektronik = Console.ReadLine();
    string kode = kodeProduk.GetKodeProduk(elektronik);
    Console.WriteLine($"Kode produk untuk {elektronik} adalah {kode}");
}

void HandleFanLaptop()
{
    Laptop myLaptop = new Laptop();
    while (true)
    {
        Console.WriteLine("Masukkan perintah (buka/balance/tutup/turbo/ kunci keluar): ");
        string command = Console.ReadLine().ToLower();

        switch (command)
        {
            case "buka":
                myLaptop.Open();
                break;
            case "tutup":
                myLaptop.Close();
                break;
            case "balance":
                myLaptop.balance();
                break;
            case "turbo":
                myLaptop.turbo();
                break;
            case "kunci keluar":
                return;
            default:
                Console.WriteLine("Perintah tidak valid. Silakan coba lagi.");
                break;
        }
        myLaptop.ShowState();
    }
}
