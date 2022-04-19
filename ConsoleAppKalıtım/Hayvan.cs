using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKalıtım
{
    public class Hayvan
    {
        public string isim;
        public string cinsiyet;
        private int yas;

        public void hayvanbilgigoster()
        {

            Console.WriteLine("Hayvanın İsmi : " + isim);
            Console.WriteLine("Hayvanın Cinsiyeti : " + cinsiyet);

        }
    }
}
