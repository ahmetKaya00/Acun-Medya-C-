using System;
using System.Threading.Tasks;

class Calisan{
    public string Ad {get;set;}
    public int Yas {get;set;}
}
class Program{

    static async Task Main(){
        //GERÇEK DÜNYA SENARYOSU

        List<Calisan> calisanlar = new List<Calisan>
        {
            new Calisan {Ad = "Ahmet", Yas = 30},
            new Calisan {Ad = "Mehmet", Yas = 25},
            new Calisan {Ad = "Ayşe", Yas = 26},
            new Calisan {Ad = "İrem", Yas = 35},
        };

        var filtrelenmis = calisanlar.Where(c => c.Yas > 30).ToList();

        foreach(var calisan in filtrelenmis){
            Console.WriteLine(calisan.Ad + " - " + calisan.Yas);
        }


        //SENKRON - ASENKRON
        
        Console.WriteLine("1. İşlem Başladı.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("2. İşlem Başladı.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("3. İşlem Başladı.");

        Console.WriteLine("İşlem Başlatılıyor");
        await UzunSureliIslem();
        Console.WriteLine("İşlem Tamamladı.");

        Thread t1 = new Thread(()=> IslemYap("İşlem 1"));
        Thread t2 = new Thread(()=> IslemYap("İşlem 2"));

        t1.Start();
        t2.Start();
    }

    static async Task UzunSureliIslem(){
        Console.WriteLine("Uzun süreli işlem başladı....");
        await Task.Delay(3000);
        Console.WriteLine("Uzun süreli işlem bitti..");
    }

    static void IslemYap(string isim){
        for(int i = 0; i <5; i++){
            Console.WriteLine($"{isim} çalişiyor...{i}");
            Thread.Sleep(1000);
        }
    }

}