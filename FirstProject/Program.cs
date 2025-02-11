using System;
class Program{
    static void Main(){
        Console.WriteLine("Merhaba, c# dünyası!");

        //Veri Tipleri
        /*
            int -> Tam sayı -> int number = 10;
            double -> Ondalıklı Sayı -> double pi = 3.14;
            bool -> Mantıksal Değer -> bool active = true;
            char -> Tek Karakter -> char harf = 'A';
            string -> Metin -> string name = "Ahmet";
        */

        int number = 10;
        double pi = 3.14;
        bool active = true;
        char harf = 'A';
        string name = "Ahmet";

        Console.WriteLine(number);
        Console.WriteLine(pi);
        Console.WriteLine(active);
        Console.WriteLine(harf);
        Console.WriteLine(name);

        Console.Write("Adınızı Girin: ");
        string ad = Console.ReadLine();

        Console.Write("Yaşınızı Girin: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Merhaba {ad}, {age} yaşındasın!");

        //OPERATÖRLER
        /*
        + Toplama
        - Çıkarma
        * Çarpma
        / Bölme
        % Mod (Kalan)
        */

        Console.Write("İlk sayıyı girin:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Toplam: {sayi1 + sayi2}");
        Console.WriteLine($"Çıkar: {sayi1 - sayi2}");
        Console.WriteLine($"Çarp: {sayi1 * sayi2}");
        Console.WriteLine($"Böl: {sayi1 / sayi2}");
        Console.WriteLine($"Kalan: {sayi1 % sayi2}");

        Console.Write("Adınızı Girin: ");
        string names = Console.ReadLine();

        Console.Write("Soyadınızı Girin: ");
        string lastName = Console.ReadLine();

        string tamAd1 = names + " " + lastName;
        string tamAd2 = string.Concat(names, " ", lastName);
        string tamAd3 = $"{names} {lastName}";

        Console.WriteLine("\nAdınız ve Soyadınız Birleştirildi:");
        Console.WriteLine($"1. Yöntem {tamAd1}");
        Console.WriteLine($"2. Yöntem {tamAd2}");
        Console.WriteLine($"3. Yöntem {tamAd3}");

        Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine();

        Console.WriteLine("\nString Metodları Uygulaması");
        Console.WriteLine($"Büyük harf: {cumle.ToUpper()}");
        Console.WriteLine($"Küçük harf: {cumle.ToLower()}");
        Console.WriteLine($"Kaç Karakter Var ?: {cumle.Length}");
        Console.WriteLine($"İlk Beş Karakter: {cumle.Substring(0,5)}");
        Console.WriteLine($"Boşlukları Kaldır: {cumle.Trim()}");
        Console.WriteLine($"'a' harfi içeriyor mu ?: {cumle.Contains("a")}");
        Console.WriteLine($"'e' harfi nerede?: {cumle.IndexOf("e")}");
        Console.WriteLine($"'Merhaba' ile başlıyor mu ?: {cumle.StartsWith("Merhaba")}");
        Console.WriteLine($"'Dünya' ile bitiyor mu ?: {cumle.EndsWith("Dünya")}");

        const double PI = 3.14159;

        
        Gunler bugün = Gunler.Salı;
        Console.WriteLine($"Bugün günlerden: {bugün}");

        Random rastgele = new Random();
        int sayi = rastgele.Next(1,101);

        Console.WriteLine($"Üretilen rastgele sayı: {sayi}");

        DateTime suAn = DateTime.Now;
        Console.WriteLine($"Şu an: {suAn}");

        DateTime dogumGunu = new DateTime(2000,1,20);
        Console.WriteLine($"Doğum günü: {dogumGunu}");


        Console.Write("Doğum yılınızı yazınız: ");
        int yilYas = Convert.ToInt32(Console.ReadLine());

        int suankiYil = DateTime.Now.Year;
        int yas = suankiYil - yilYas;

        Console.WriteLine($"Senin Yaşın {yas}");


    }
}

enum Gunler {Pazartesi, Salı, Çarşamba, Perşembe, Cuma}