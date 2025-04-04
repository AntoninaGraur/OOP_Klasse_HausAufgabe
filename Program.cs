

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
        Console.WriteLine(" Farbe: " + lastwagen1.GetFarbe());
        Console.WriteLine(" Baujahr: " + lastwagen1.GetJahr());


        Console.ReadLine();

        Console.Write("Gib das Model ein:  ");
        string modelPKW = Console.ReadLine();

        Console.Write("Gib die Farbe ein:  ");
        string farbePKW = Console.ReadLine();

        Console.Write("Gib das Baujahr ein:  ");
        int jahrPKW;

        while (!int.TryParse(Console.ReadLine(), out jahrPKW))
        {
            Console.Write(" Ungültige Eingabe!");
        }

        PKWagen pKWagen1 = new(modelPKW, farbePKW, jahrPKW);


        Console.WriteLine("\n PKW  Details");
        Console.WriteLine("\n Model: " + pKWagen1.GetModel());
        Console.WriteLine(" Farbe: " + pKWagen1.GetFarbe());
        Console.WriteLine(" Baujahr: " + pKWagen1.GetJahr());


        Console.ReadLine();


        Console.Write("Gib das Model ein:  ");
        string modelMot = Console.ReadLine();

        Console.Write("Gib die Farbe ein:  ");
        string farbeMot = Console.ReadLine();

        Console.Write("Gib das Baujahr ein:  ");
        int jahrMot;

        while (!int.TryParse(Console.ReadLine(), out jahrMot))
        {
            Console.Write(" Ungültige Eingabe!");
        }

        Motorad motorad1 = new(modelMot, farbeMot, jahrMot);

        Console.WriteLine("\n Motorad Details");
        Console.WriteLine("\n Model: " + motorad1.GetModel());
        Console.WriteLine(" Farbe: " + motorad1.GetFarbe());
        Console.WriteLine(" Baujahr: " + motorad1.GetJahr());


        Console.ReadLine();
    }
}

