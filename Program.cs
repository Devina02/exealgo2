using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exealgo2
{ 
    class program
    {
        private int[] arr = new int[33];
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
                arr[i] = Int32.Parse(s1);
            }
   
        }
    }
}
