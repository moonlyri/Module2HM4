using Module2HM4;
public class Program
{
   public static void Main(string[] args)
    {
        var service = new AnimalsService(new FileStorage());
        var av1 = new Aviary1();
        var av2 = new Aviary2();
        av1.Count();
        av2.Count();

    }
}
