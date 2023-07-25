class Program
{
    static int AlanHesapla(int kenar)
    {
        int sonuc = 0;
        sonuc = kenar * kenar;
        return sonuc;
    }
        
    static double AlanHesapla(double yaricap, double PI = 3.14)
    {
        
        return PI * yaricap * yaricap;
    }
    static int AlanHesapla(int kenar1, int kenar2)
    {
        return kenar1*kenar2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("kenar = 5 alan = "+AlanHesapla(5));
        Console.WriteLine("kenar 1 = 5, kenar2 = 10 Alan ="+AlanHesapla(5,10));
        Console.WriteLine("Yari çap = 5 , Alan =" + AlanHesapla(5.0,3.15));
    }
}
