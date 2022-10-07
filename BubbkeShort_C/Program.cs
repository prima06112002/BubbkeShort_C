using System;

namespace BubbleShort_C
{
    class program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];
        
        // Deklarasi variabnel int untuk menyimpan banyak data pada array

        // Fungsi / Method untuk menerima masukan
        public void read()
        {
            // menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write(a"Masukan banyaknya element pada array: ");
                string s = Console.ReadLine();
                new = Int32.Parse(s);
                if (new <= 20)
                    break;
                else
            }
        }
    }