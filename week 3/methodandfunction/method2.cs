public class MethodIki{

    public static void selamver(){
        Console.WriteLine("Merhaba, Hoş geldiniz!");
    }

    public static int Topla (int a, int b){
        return a+b;
    }

    public static void degerArttir(ref int sayi){
        sayi += 10;
    }

    public static void Hesapla(int a, int b, out int toplam, out int fark){
        toplam = a + b;
        fark = a - b;
    }

    public static int Toplama(params int[] sayilar){
        int toplam = 0;
        foreach(var sayi in sayilar){
            toplam += sayi;
        }
        return toplam;
    }

    public static void LogYaz(string mesaj, string seviye = "Bilgi"){
        Console.WriteLine($"[{DateTime.Now}] {seviye}: {mesaj}");
    }
}