using OOPProje.Models;

class Program{

    static void Main(){
        Araba araba1 = new Araba("Toyota","Corolla",2022);
        Araba araba2 = new Araba("Honda","Civic",2021);

        araba1.BilgiGoster();
        araba2.BilgiGoster();

        Kullanici kullanici1 = new Kullanici("Ahmet","ahmet@gmail.com","12345");
        Kullanici kullanici2 = new Kullanici("Mehmet","ahmet@gmail.com","12345");
        kullanici1.BilgiGoster();
        kullanici2.BilgiGoster();




        Manager yonetici1 = new Manager("Mehmet",40,15000,"IT");
        Staff personel1 = new Staff("Ayşe",20,8000,"Satış");

        yonetici1.BilgiGoster();
        personel1.BilgiGoster();



        Hayvan hayvan1 = new Kedi();
        Hayvan hayvan2 = new Kopek();

        hayvan1.SesCikar();
        hayvan2.SesCikar();



        Sekil sekil = new Daire(5);
        Console.WriteLine("Dairenin Alanı: " + sekil.AlanHesapla());


        IOdeme krediKartiOdeme = new KrediKartiOdeme();
        IOdeme havaleOdeme = new Havale();

        krediKartiOdeme.OdemeYap(1000);
        havaleOdeme.OdemeYap(5000);

    }
}