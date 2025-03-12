using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300134
{
    public enum LaptopState
    {
        Closed,
        Open,
        Locked,
        PartiallyOpen
    }
    class FanLaptop
    {
        private LaptopState currentState;

        public FanLaptop()
        {
            currentState = LaptopState.Closed;
        }

        public void Open()
        {
            if (currentState == LaptopState.Closed)
            {
                Console.WriteLine("Laptop dibuka.");
                currentState = LaptopState.Open;
            }
            else if (currentState == LaptopState.PartiallyOpen)
            {
                Console.WriteLine("Laptop sekarang terbuka sepenuhnya.");
                currentState = LaptopState.Open;
            }
            else if (currentState == LaptopState.Locked)
            {
                Console.WriteLine("Laptop terkunci! Buka kunci dulu.");
            }
            else
            {
                Console.WriteLine("Laptop sudah terbuka.");
            }
        }

        public void Close()
        {
            if (currentState == LaptopState.Open)
            {
                Console.WriteLine("Laptop ditutup.");
                currentState = LaptopState.Closed;
            }
            else if (currentState == LaptopState.PartiallyOpen)
            {
                Console.WriteLine("Laptop ditutup dari posisi terbuka sebagian."); 
                currentState = LaptopState.Closed;
            }
            else
            {
                Console.WriteLine("Laptop sudah tertutup.");
            }
        }

        public void Turbo()
        {
            if (currentState == LaptopState.Closed)
            {
                Console.WriteLine("Fan Quiet berubah menjadi Turbo.");
                currentState = LaptopState.Locked;
            }
            else
            {
                Console.WriteLine("Tidak bisa mengunci! Laptop harus dalam keadaan tertutup."); 
            }
        }

        public void Balanced()
        {
            if (currentState == LaptopState.Locked)
            {
                Console.WriteLine("“Fan Quiet berubah menjadi Balanced.");
                currentState = LaptopState.Closed;
            }
            else
            {
                Console.WriteLine("Laptop tidak dalam keadaan terkunci.");
            }
        }

        public void PartiallyOpen()
        {
            if (currentState == LaptopState.Closed)
            {
                Console.WriteLine("Laptop dibuka sebagian.");
                currentState = LaptopState.PartiallyOpen;
            }
            else if (currentState == LaptopState.Open)
            {
                Console.WriteLine("Laptop ditutup sebagian.");
                currentState = LaptopState.PartiallyOpen;
            }
            else
            {
                Console.WriteLine("Tidak bisa membuka sebagian dari kondisi saat ini."); 
            }
        }

        public void ShowState()
        {
            Console.WriteLine($"Status Laptop saat ini: {currentState}");
        }
    }


}
        
