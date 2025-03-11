namespace OOPProje.Models{

    class Daire : Sekil
    {
        public double YariCap {get;set;}

        public Daire(double yaricap){
            YariCap = yaricap;
        }
        public override double AlanHesapla()
        {
            return Math.PI * YariCap * YariCap;
        }
    }
}