namespace OOPProje.Models{

    class Kullanici{

        private string sifre;
        public string Ad {get;set;}
        public string Email {get;set;}

        public string Sifre{
            get {return "****";}
            set {sifre = value;}
        }

        public Kullanici(string ad, string email, string sifre){
            Ad = ad;
            Email = email;
            this.sifre = sifre;
        }

        public void BilgiGoster(){
            Console.WriteLine($"Kullanıcı: {Ad}, Email: {Email}, Şifre: {Sifre}");
        }

    }
}