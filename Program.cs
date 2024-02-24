using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w05_bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot chuoi bat ki: ");
            string s=Console.ReadLine();
            Console.Write("Nhap mot ki tu can kiem tra: ");
            char c=char.Parse(Console.ReadLine());
            check(s, c);
            Console.ReadKey();
        }
        public static void check(string s,char c)
        {
            int count= 0;
            foreach(char x in s)
            {
                if (x == c)
                    count++;
            }
            Console.WriteLine("So lan xuat hien cua ki tu "+"\""+c+"\""+" la "+count);
        }
    }
}
