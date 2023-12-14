namespace StrategyExampleApp.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Credit { get; set; }


    public void DisplayUser()
    {
        Console.WriteLine($"Id: {Id} Name: {Name} LastName: {LastName} Credit:{Credit}");
    }

}