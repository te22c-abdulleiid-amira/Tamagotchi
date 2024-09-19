Console.WriteLine("TAMAGOCHI");

tamagochi myTama = new tamagochi();

Console.WriteLine("GE den ett namn");
myTama.name = Console.ReadLine();

Console.WriteLine($"nu heter den {myTama.name}");

while (myTama.GetAlive() == true)
{
  Console.Clear();
  myTama.PrintStats();
  Console.WriteLine("vad vill du göra");
  Console.WriteLine($"1. lära {myTama.name}ett nytt ord");
  Console.WriteLine($"2. prata med {myTama.name}");
  Console.WriteLine($"3. mata {myTama.name}");
  Console.WriteLine($"4. göra ingenting");

  string doWhat = Console.ReadLine();
  if (doWhat == "1")
  {
    Console.WriteLine("vilket ord");
    string word = Console.ReadLine();
    myTama.Teach(word);
  }
  if (doWhat == "2")
  {
    myTama.Hi();
  }
  if (doWhat == "3")
  {
    myTama.Feed();
  }
  else
  {
    Console.WriteLine("gör inget");
  }
  myTama.Tick();
  Console.WriteLine("tryck ENTER för att fortsätta");
  Console.ReadLine();
}

Console.WriteLine($"hoppsan {myTama.name} dog");
Console.WriteLine("tryck på ENTER för att avsluta");
Console.ReadLine();