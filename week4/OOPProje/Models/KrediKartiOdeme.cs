namespace OOPProje.Models{

    class KrediKartiOdeme : IOdeme
    {
        public void OdemeYap(double tutar)
        {
            Console.WriteLine($"Kredi Kartı ile {tutar} TL ödeme yapıldı!");
        }
    }
}