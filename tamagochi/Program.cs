Weapon axe = new()
{
    Name = "KillerQueen",
    MinDamage = 10,
    MaxDamage = 20
};
axe.Attack(); // nu kör metoden från weapon.cs

int damage = Random.Shared.Next (axe.MinDamage, axe.MaxDamage);

Console.WriteLine(damage);

Console.ReadLine();
