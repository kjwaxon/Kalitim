using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.isim = "Tekir";
            kedi.cinsiyet = "Erkek";
            kedi.hayvanbilgigoster();

            Console.ReadKey();
            
        }
    }
}
