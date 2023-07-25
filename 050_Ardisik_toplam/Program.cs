class Program
{
    static int ArdisikToplam(int sayi)
    {
       
        return ArdisikToplam(1,sayi, 1);
    }
    static int ArdisikToplam(int basla, int bitis)
    {
        return ArdisikToplam(basla,bitis,1);
    }
    static int ArdisikToplam(int basla, int bitis, int artis)
    {
        int toplam = 0;
        for (int i = basla; i <= bitis; i += artis)
        {
            toplam += i;
        }
        return toplam;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("1..10 sayıların toplamı = " + ArdisikToplam(10));
        Console.WriteLine("1..20 sayıların toplamı = " + ArdisikToplam(20));
        Console.WriteLine("10..50 sayıların toplamı = " + ArdisikToplam(10, 50));
        Console.WriteLine("70..90 sayıların toplamı = " + ArdisikToplam(70, 90));
        Console.WriteLine("20..100 5er artan sayıların toplamı = " + ArdisikToplam(20, 50, 5));
        Console.WriteLine("50..200 7er artan sayıların toplamı = " + ArdisikToplam(50, 200, 7));
    }
}