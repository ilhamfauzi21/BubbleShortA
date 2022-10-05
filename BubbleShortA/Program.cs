using ilham;
using System;
using System.Xml.Linq;

namespace ilham
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        //deklarasi variabel int untuk menyimpan banyaknya data array private intn;
        private int n;
        // fungsi / method untuk menerima masukan 
        public void read()
        {
            // menerima angka untuk menentukan banyaknya data yang di simpan pada array
            while (true)
            {
                Console.Write("masukan banyak element pada array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray vdapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("_______________________");
            Console.WriteLine("MASUKKAN ELEMEN ARRAY");
            Console.WriteLine("______________________");

            // pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("elemen array yang telah tersusun");
            Console.WriteLine("--------------------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }

        public void BublleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // creating the object of the Bublesort class
            Program mylist = new Program();
            // pemanggilan fungsi untuk menerima elemen array
            mylist.read();
            // pemanggilan fungsi untuk mengurutkan array
            mylist.BublleSortArray();
            // pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();
            // Exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}