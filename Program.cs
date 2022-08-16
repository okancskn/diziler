internal class Program
{
    private static void Main(string[] args)
    {
        
        // Dizi tanimlama

        string[] renkler = new string[5];

        string[] hayvanlar = {"Kedi","Köpek","Aslan","Maymun"};

        int[] sayilar;

        sayilar = new int[5];

        sayilar[3]=10;

        Console.WriteLine("Renkler 2. Elemanı: "+renkler[2]);
        Console.WriteLine("Hayvanlar 3. Elemanı: "+hayvanlar[3]);
        Console.WriteLine("Sayilar 3. Elemanı: "+sayilar[3]);


        // Deneme Ornek-1

        Console.WriteLine("Lutfen bir sayi giriniz: ");

        int sayi = Int32.Parse(Console.ReadLine());
        int sayac = 0;
        int[] degerler = new int[sayi];
        int toplam=0;

        while(sayac<sayi)

        {

            Console.WriteLine("Bir sayi daha giriniz: ");

            degerler[sayac] = Int32.Parse(Console.ReadLine());

            sayac++;

        }


        foreach (var eleman in degerler)
        {
            
            toplam += eleman;
            
        }

        Console.WriteLine("Girdiginiz sayilarin ortalamasi: "+toplam/sayi);

       /* for (int i = 0; i<= sayi-1; i++)
        {

            toplam += degerler[i];
            
        } */



    }
}