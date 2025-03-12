namespace MODUL4_103022300109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daftar Produk");
            Console.WriteLine("Produk\t | KodeProduk");
            Console.WriteLine("----------------------");
            foreach(KodeProduk.produk produk in Enum.GetValues(typeof(KodeProduk.produk)))
            {
   
                Console.WriteLine("{0}\t | {1}", produk, "E" + KodeProduk.getKodeProduk(produk));
            }

            Console.WriteLine("----------------------");

            FanLoop fan = new FanLoop();
            String input = "";
            while (input != "keluar") { 
                Console.WriteLine("Masukkan perintah (modeUp, modeDown, turboShortcut, keluar)");
                input = Console.ReadLine();
                if(Enum.TryParse(input, out kegiatan kegiatan))
                {
                    fan.ubahFan(kegiatan);
                    fan.getStatusFan();
                }
                else
                {
                    Console.WriteLine("Perintah tidak dikenal");
                }
            }
        }
    }
}
