public static class donguler{
    public static void Calistir(){

        for(int i = 1; i<= 5; i++){
            Console.WriteLine("Tekrar Sayısı:" + i);
        }

        int sayac = 1;
        while(sayac <= 5){
            Console.WriteLine("Sayac: " + sayac);
            sayac++;
        }

        int x = 1;
        do{
            Console.WriteLine("x: " + x);
            x++;
        }while(x <= 5);

        int toplam = 0, sayi;

        Console.WriteLine("Şifrenizi girin (0 girince bitecek)");

        while(true){
            Console.Write("Sayı: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi == 0){
                break;
            }

            toplam ++;
        }

        Console.WriteLine("Girilen Yanlış sayısı: " +toplam);

        Console.Write("Bir Sayı Girin: ");
        int girdi = Convert.ToInt32(Console.ReadLine());
        bool asal = true;

        if(girdi < 2){
            asal = false;
        }
        else{
            int i = 2;
            while(i <= girdi / 2){
                if(girdi % i == 0){
                    asal = false;
                    break;
                }
                i++;
            }
        }
        if(asal){
            Console.WriteLine($"{girdi} bir asal sayıdır.");
        }else{
            Console.WriteLine($"{girdi} bir asal değildir.");
        }
    }
}