using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4_103022300109
{
    internal class KodeProduk
    {
        public enum produk {Laptop, Smartphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera};

        public static int getKodeProduk(produk Produk)
        {
            //String[] kodeProduk = {"E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };
            //return kodeProduk[(String)Produk];
            int[] kodeProduk = { 100, 101, 102, 103, 104, 105, 106, 107, 108, 109 };
            return kodeProduk[(int)Produk];
        }
    }
}
