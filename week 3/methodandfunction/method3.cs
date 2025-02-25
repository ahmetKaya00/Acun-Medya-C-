public class MethodUc{

    public static int KaresiniAl(int x){
        return x * x;
    }

    public static Func<int,int> karesi = x => x * x;

    public static Func<int,int,int> Topla = (x,y) => x+y;

    public static Action<string>Selamla = isim => Console.WriteLine("Merhaba " + isim);

    public static Predicate<int> CiftMi = sayi => sayi % 2 == 0;



}