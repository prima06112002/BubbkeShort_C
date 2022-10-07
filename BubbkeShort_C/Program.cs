using System;
using System.Collections;

namespace BubbleShort_C
{
    class program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];
        private int i;
        private int n;

        // Deklarasi variabnel int untuk menyimpan banyak data pada array

        // Fungsi / Method untuk menerima masukan
        public void read()
        {
            // menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukan banyaknya element pada array: ");
                string s = Console.ReadLine();
                new = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);

            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element Array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        public void BubleShortArray()
        {
            for (int i = 1; i < n; i++) // For n - passes
            {
                // Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args);
        {
            // Creating the object of the Bubblesort class
            Program myList = new Program();

            // Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            // Pemanggilan fungsi untuk mengurutkan array
            myList.BubblesortArray();
            // pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();


}

    internal class Program
    {
        public Program()
        {
        }
    }
}