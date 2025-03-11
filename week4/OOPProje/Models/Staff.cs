namespace OOPProje.Models{
    class Staff : Calisan{
        public string Pozisyon {get;set;}

        public Staff(string ad, int yas, double maas,string pozisyon) : base(ad,yas,maas){
            Pozisyon = pozisyon;
        }

        public override void BilgiGoster()
        {
           Console.WriteLine($"[Personel] {Ad} - {Pozisyon} Pozisyonu - Maaş: {Maas}");
        }
    }
}