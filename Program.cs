
static void skrivVelkomst()
{
    Console.Clear();
    Console.WriteLine("_____________________");
    Console.WriteLine("Velkommen til min app");
    Console.WriteLine("_____________________");

}



static int ReadInt(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}



ConsoleKey tast;
do
{
    skrivVelkomst();
    int alder = ReadInt("Indtast et tal: ");
    int morAlder = ReadInt("indtast et andet tal: ");
    Console.WriteLine("Differencen mellem dig og din mor er: " + (morAlder - alder) + " år.");
    Console.WriteLine ("Tryk på en tast for at starte forfra. ESC for at afslutte...");
    tast = Console.ReadKey().Key;
} while (tast != ConsoleKey.Escape);