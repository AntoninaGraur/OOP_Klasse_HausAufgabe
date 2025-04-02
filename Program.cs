

using OOP_Klasse_HausAufgabe;

class Programm
{
    static void Main()
    {

        Console.Write("Gib das Model ein:  ");
        string model = Console.ReadLine();

        Console.Write("Gib die Farbe ein:  ");
        string farbe = Console.ReadLine();

        Console.Write("Gib das Baujahr ein:  ");
        int jahr;


        while (!int.TryParse(Console.ReadLine(), out jahr))
        {
            Console.Write("Ungültige Eingabe!");
        }

        Lastwagen lastwagen1 = new(model, farbe, jahr);

        Console.WriteLine("\n Lastwagen Details" );
        Console.WriteLine("\n Model: " + lastwagen1.GetModel());
        Console.WriteLine("Farbe: " + lastwagen1.GetFarbe());
        Console.WriteLine("Baujahr: " + lastwagen1.GetJahr());




    }
}
