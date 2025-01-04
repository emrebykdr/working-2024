using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program : IProgram
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.İsimYaz();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            program.islem(b, a);
            Console.WriteLine("sayı giriniz");
            Console.WriteLine("girdiğiniz sayı"+program.sayigel());
            
        }
        public void İsimYaz()
        {
            Console.WriteLine("emre");
        }
        public void islem(int a, int b)
        {

            int sonuc = a + b;

            Console.WriteLine(sonuc);

        }
        public int sayigel()
        {
            return Convert.ToInt32(Console.ReadLine()); 

        } 
    }
}