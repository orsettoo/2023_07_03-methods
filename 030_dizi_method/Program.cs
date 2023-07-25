class Program
{
    static void DiziGoster(int[] dizi)
    {
        Console.WriteLine("dizide "+dizi.Length+"tane sayı var ");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine(dizi[i]);
        }
    }
    
    static int EnBuyukSayi(int[] dizi)
    {
        int enbuyuk = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > enbuyuk)
            {
                enbuyuk= dizi[i]; 
            }
        }
        return enbuyuk;
    }
    static void Main(string[] args)
    {
        int[] notlar = { 12, 78, 45, 96 };
        //Console.WriteLine(EnBuyukSayi(notlar));
        
        DiziGoster(notlar);
        Console.Write("en büyük =");
        Console.WriteLine(EnBuyukSayi(notlar));
    }
}

//toplam ve ortalama bul.
