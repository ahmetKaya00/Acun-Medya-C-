namespace OOPProje.Models{

    class Calisan{

        public string Ad {get;set;}
        public int Yas {get;set;}
        public double Maas {get;set;}

        public Calisan(string ad, int yas, double maas){
            Ad = ad;
            Yas = yas;
            Maas = maas;
        }

        public virtual void BilgiGoster(){
            Console.WriteLine($"Çalışan: {Ad}, Yaş: {Yas}, Maaş: {Maas} TL");
        }
    }
}