namespace OOPProje.Models{

    class Manager : Calisan{
        public string Departman {get;set;}

        public Manager(string ad, int yas, double maas,string departman) : base(ad,yas,maas){
            Departman = departman;
        }

        public override void BilgiGoster()
        {
             Console.WriteLine($"[Yönetici] {Ad} - {Departman} Departmanı - Maaş: {Maas}");
        }
    }
}