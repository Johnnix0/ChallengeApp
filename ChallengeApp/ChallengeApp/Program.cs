using System.ComponentModel.Design;

/// Dzien 3 zadanie domowe
string name = "Ewa";
string plec = "M"; //mezczyzna - 'M', kobieta - 'K'
int wiek = 33;

if (name != "Ewa" || wiek != 33)
{
    if (plec == "K" && wiek < 30)
    {
        Console.WriteLine("Kobieta ponizej 30 lat");
    }
    else
    {
        if (plec == "M" && wiek < 18)
        {
            Console.WriteLine("Niepelnoletni Mezczyzna");
        }
        else
        {
            Console.WriteLine("Nie potrafie okreslic tej osoby");
        }
    }
}
else
{
   Console.WriteLine("Ewa, lat 33");
}
