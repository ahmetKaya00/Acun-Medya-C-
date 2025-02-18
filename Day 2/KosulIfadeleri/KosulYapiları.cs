public static class KosulYapilari{

    public static void Calistir(){
        int yas = 17;

        if(yas >= 18){
            Console.WriteLine("Ehliyet alabilirsiniz.");
        }else{
            Console.WriteLine("Ehliyet alamazsınız.");
        }

        int not = 70;

        if(not >= 85){
            Console.WriteLine("Çok İyi!");
        }
        else if(not >= 70){
            Console.WriteLine("İyi");
        }
        else if(not >= 50){
            Console.WriteLine("Orta");
        }
        else{
            Console.WriteLine("Başarısız");
        }

        int gun = 4;

        switch(gun){
            case 1:
            Console.WriteLine("Pazartesi");
            break;
            case 2:
            Console.WriteLine("Salı");
            break;
            case 3:
            Console.WriteLine("Çarşamba");
            break;
            default:
            Console.WriteLine("Geçersiz Gün!");
            break;
        }

        Console.Write("Bir Sayı Girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if(sayi < 0){
            Console.WriteLine("Sayınız negatiftir!");
        }
        else if(sayi > 0){
            Console.WriteLine("Sayınız Pozitiftir.");
        }
        else{
            Console.WriteLine("Sayınız 0'dır.");
        }
    }
}