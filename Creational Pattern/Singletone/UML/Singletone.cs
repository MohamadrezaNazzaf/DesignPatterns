namespace Singletone.UML;

public class Singletone
{
    private static readonly Singletone uniqeInstance = new Singletone();

    private Singletone()
    {
    }

    public static Singletone GetInstance()
    {
        return uniqeInstance;
    }
}