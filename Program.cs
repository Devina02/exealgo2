using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exealgo2
{ 
    class program
    {
        private int[] Devina = new int[33];
        private int cmp_count = 0;
        private int mov_count = 0;
        private int n;
        public void input()
        {
            while (true)
            {
                Console.WriteLine("Masukan jumlah elemen atau data array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray maksimum 33 element atau data. \n");
            }
            Console.WriteLine("\n==================================");
            Console.WriteLine("Enter array elementa");
            Console.WriteLine("\n==================================");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Devina[i] = Int32.Parse(s1);
            }
   
        }
        void swap (int x, int y)
        {
            int temp;
            temp = Devina[x];
            Devina[x] = Devina[y];
            Devina[x] = temp;
        }
        public void exe (int low, int high)
        {
            int pivot, i, DP;
            if (low < high)
                    return;

            i = low + 1;
            DP = high;

            pivot = Devina[low];
            while (i <=DP)
            {
                while ((Devina[i] <= pivot) && (i <=high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                while ((Devina[DP] > pivot) && (DP >= low))
                {
                    DP--;
                    cmp_count++;
                }

                cmp_count++;
                if (i < DP)
                {
                    swap(i, DP);
                    mov_count++;
                }
            }
            if (low < DP)
            {
                swap(low, DP);
                mov_count++;
            }
            exe(low, DP - 1);
            exe(DP + 1, high);
        }
        void display()
        {

        }
    }
}
