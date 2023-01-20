Console.WriteLine("Hur många tal vill du skriva?");
int Tot = int.Parse(Console.ReadLine());
int[] T = new int[Tot];
Console.WriteLine("Skriv " + Tot + " Tal");
for (int i = 0; i < Tot; i++)   {
    T[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < Tot; i++)   {
    Console.Write($"Tal {i+1}:");
    Console.Write(T[i]);
    Console.WriteLine();
}