using System;
using System.Collections;

namespace BubbkeShort_C
{
    class Program
    {
        /// <summary>
        /// Deklarasi array int dengan ukuran 20
        /// </summary>
        private int[] a = new int[20];
        private int i;
        private int n;

        /// <summary>
        /// Deklarasi variabel int untuk menyimpan banyak data pada array
        /// </summary>

        /// Fungsi / Method untuk menerima masukan
        public void read()
        {
            /// menerima angka untuk menentukan banyaknya data yang disimpan pada array
            /// <example> string s = membaca input dari pengguna,yaitu jumlah elemen pd array dan menyimpannya sebagai sebuah string
            /// </example>
            while (true)
            {
                Console.Write("Masukan banyaknya element pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("-----------------------");

            /// Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);

            }
        }
        public void display()
        {
            /// Menampilkan array yang tersusun
            /// <example> Baris pertama sampai ketiga mencetak sebuah header yang terdiri dari tiga baris, di mana baris pertama dan ketiga dicetak kosong, sedangkan pada baris kedua dicetak garis pemisah yang terdiri dari beberapa tanda '-'.
            /// Baris keempat memulai sebuah loop (pengulangan) for yang akan mencetak kosong sebanyak n kali ke dalam konsol. Variabel n di sini merupakan sebuah variabel yang mungkin didefinisikan sebelumnya dalam program.
            /// Baris terakhir mencetak sebuah baris kosong di konsol.</example>
          

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
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) ///For n - passes
            {
                /// Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) /// jika elemen tidak dalam urutan yang benar
                    {
                        /// Tukar elemen
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
            /// <summary>Creating the object of the Bubbleshort class </summary>
            Program myList = new Program();

            /// Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            /// pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            /// pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            ///Exit
            Console.WriteLine("\n\n Tekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}


      