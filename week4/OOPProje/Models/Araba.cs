namespace OOPProje.Models{

    class Araba{

        public string Marka {get;set;}
        public string Model {get;set;}
        public int Yil {get;set;}

        public Araba(string marka, string model, int yil){
            Marka = marka;
            Model = model;
            Yil = yil;
        }

        public void BilgiGoster(){
            Console.WriteLine($"Araba: {Marka} {Model} - {Yil}");
        }
    }
}