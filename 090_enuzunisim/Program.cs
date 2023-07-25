class Program
{
    static void IsimListele(string[] isimler)
    {
        Console.WriteLine("dizide"+isimler.Length+"tane isim var ");
        Console.WriteLine("------------------------------------------");
        for (int i = 0; i < isimler.Length; i++)
        {
            Console.Write(i + 1 + ". " );
            Console.Write(isimler[i]);
            Console.Write(" - " + isimler[i].Length);
            Console.WriteLine();
        }
    }
    
    static string EnUzunIsim(string[] adlar)
    {
        string ad = "";
        int maxlength = 0;
        int ndx = 0;
        for (int i = 0; i < adlar.Length; i++)
        {
            if (adlar[i].Length > maxlength) ;
            ndx = i;
        }
        ad= adlar[ndx];
        return ad;
    }
    static void Main(string[] args)
    {
        string[] isimler = { "lizge", "arda", "yavuz", "özge", "şeyma", "muhammed" };
        IsimListele(isimler);
        Console.WriteLine(EnUzunIsim(isimler)); Console.WriteLine();
    }
}
