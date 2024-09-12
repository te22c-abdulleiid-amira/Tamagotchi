public class Weapon 
{
    public string Name;
    public int MinDamage;
    public int MaxDamage;

//     public void Attack() // detta är en metod
//     {
//         Console.WriteLine($"Attacking with {Name}");
//     }
    public int Attack()
    {
        Console.WriteLine($"Attacking with {Name}");
        return Random.Shared.Next(MinDamage, MaxDamage);
    }

}