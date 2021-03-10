using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi kalkulator";

            //int a = 10; // declarasi variabel a, dengan nilai awal 10;
            //int a = 6; // declarasi variabel b, dengan nilai awal 6;

            int selectMenu = SelectMenu();
            if (selectMenu < 1 || selectMenu > 4)
            {
                Console.WriteLine();
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                ExitProgram();
            }

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); //Proses casting
            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine()); //Proses casting

            Console.WriteLine(); // tambahkan baris kosong
            if (selectMenu == 1) Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            else if (selectMenu == 2) Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            else if (selectMenu == 3) Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            else Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int SelectMenu()
        {
            Console.WriteLine("Menu Kalkulator");

            Console.WriteLine();

            Console.WriteLine("1. Penambahan ");
            Console.WriteLine("2. Pengurangan ");
            Console.WriteLine("3. Perkalian ");
            Console.WriteLine("4. Pembagian ");
            Console.WriteLine();
            Console.WriteLine("Pilih Menu [1..4] : ");

            return int.Parse(Console.ReadLine());
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }

        static void ExitProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}
