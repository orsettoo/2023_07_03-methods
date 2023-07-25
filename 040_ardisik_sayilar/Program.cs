class Program
{
    static int ArdisikToplam(int sayi)
    {
        int toplam = 0;
        for (int i = 0; i < sayi; i++)
        {
            toplam += i;
        }
        return toplam;
    }

    static int ArdisikToplam2(int basla, int bitis)
    {
        int toplam = 0;
        for (int i = basla; i < bitis; i++)
        {
            toplam += i;
        }
        return toplam;
    }
    static int ArdisikToplam3(int basla, int bitis, int artis)
    {
        int toplam = 0;
        for (int i = basla; i < bitis; i += artis)
        {
            toplam += i;
        }
        return toplam;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("1..10 sayıların toplamı = " + ArdisikToplam(10));
        Console.WriteLine("1..20 sayıların toplamı = " + ArdisikToplam(20));
        Console.WriteLine("10..50 sayıların toplamı = " + ArdisikToplam2(10, 50));
        Console.WriteLine("70..90 sayıların toplamı = " + ArdisikToplam2(70, 90));
        Console.WriteLine("20..100 5er artan sayıların toplamı = " + ArdisikToplam3(20, 100, 5));
    }
}
