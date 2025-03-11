namespace OOPProje.Models{

    class Havale : IOdeme
    {
        public void OdemeYap(double tutar)
        {
           Console.WriteLine($"Kredi Kartı ile {tutar} TL havale yapıldı!");
        }
    }
}