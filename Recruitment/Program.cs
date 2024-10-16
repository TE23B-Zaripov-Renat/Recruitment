string enemyName = "";

Console.WriteLine("-- Potential recruits --");

List<string> names = ["[0] Micke", "[1] Martin", "[2] Lena", "[3] Karim", "[4] Liv"];



// while  Om man inte vet hur många gånger 
// for = om man vet hur många gånger
for (int i = 0; i <names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("\n-- Current recruits --\n");

Console.WriteLine("Choose a recruit:");

// names.Add("Nicholas");
// names.Remove("Lena");
// names.RemoveAt(3);
// names[0] = "Mikael";

// int i = Random.Shared.Next(names.Count);
// Console.WriteLine(names[i]);

Console.ReadLine();