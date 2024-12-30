using System;

class Program
{
    static void Main()
    {
        int dogruCevapSayisi = 0;

        // Soru 1
        Console.WriteLine("1 -> Rick ve Morty kaç sezondur?\nA) 6  B) 7");
        string cevap1 = Console.ReadLine().ToUpper();

        if (cevap1 == "B")
        {
            dogruCevapSayisi++;
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: B");
        }

        // Soru 2
        Console.WriteLine("2 -> Game of Thrones serisi kaç kitaptan oluşmaktadır?\nA) 8  B) 10");
        string cevap2 = Console.ReadLine().ToUpper();

        if (cevap2 == "A")
        {
            dogruCevapSayisi++;
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: A");
        }

        // Ödülü kazanma ihtimali bittiyse;
        if (dogruCevapSayisi < 2)
        {
            Console.WriteLine("Yarışma sona erdi. Katıldığınız için teşekkürler!");
            return;
        }

        // Soru 3
        Console.WriteLine("3 -> Meltem'in en sevdiği dizi nedir?\nA) Game of Thrones  B) Yaprak Dökümü  C) İkisi de");
        string cevap3 = Console.ReadLine().ToUpper();

        if (cevap3 == "C")
        {
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: C");
        }

        // Final sonucunu yazdırıyoruz.
        if (dogruCevapSayisi >= 2)
        {
            Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
        }
        else
        {
            Console.WriteLine("Maalesef büyük ödülü kazanamadınız. Katıldığınız için teşekkürler!");
        }
    }
}
