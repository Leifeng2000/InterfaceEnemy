internal class Program
{
    private static void Main(string[] args)
    {
        //Wood wood = new Wood();
        //wood.Efect();
        //Iron iron = new Iron();
        //iron.Efect();
        Grass grass = new Grass();
        grass.Efect();
    }
}

public interface IDamager
{
    void Efect();
}

public class Wood : IDamager
{
    public void Efect()
    {
        Console.WriteLine("Wood");
    }
    
}
public class Iron : IDamager
{
    public void Efect()
    {
        Console.WriteLine("Tao tia lua");
    }
}
public class Grass : IDamager
{
    public void Efect()
    {
        Console.WriteLine("Tao bun dat kh ban");
    }
}
public class Bulet
{
    Wood bulletCollider = new Wood();
}