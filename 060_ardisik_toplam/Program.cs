class Program
{

    static int ArdisikToplam(int bitis, int basla = 1, int artis = 1)
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
        Console.WriteLine("10..50 sayıların toplamı = " + ArdisikToplam(50, 10));
        Console.WriteLine("70..90 sayıların toplamı = " + ArdisikToplam(90, 70));
        Console.WriteLine("20..100 5er artan sayıların toplamı = " + ArdisikToplam(50, 20, 5));
        Console.WriteLine("50..200 7er artan sayıların toplamı = " + ArdisikToplam(200, 50, 7));
    }
}
