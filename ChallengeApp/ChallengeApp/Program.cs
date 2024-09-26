using System;

Console.WriteLine("Cześć Mateuszu, dobrze, że wróciłeś!");

var myAge = 31;
int myAge2 = 33;

Console.WriteLine(myAge);
float myNumber = float.MaxValue;

//zmienne tekstowe
string name = "Mateusz";
string surname = "Jahn";
char myVar = 'C';
// zmienna lgoiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);

if (myAge < myAge2)
{
    Console.WriteLine("Jestem tutaj 23");
}
else
{
    Console.WriteLine("Jestem tutaj 27");
}

//operatory ==, <=, >=,!=, 


//zadanie domowe TEMAT_ZMIENNE:

string imie;
string plec;
int wiek;

//1
if (wiek < 30 && plec == "k");
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
//2
if (imie == "Ewa" && wiek == 30) ;
{
    Console.WriteLine("Ewa, 30 lat");
}
//3
if (plec == "m" && wiek < 18) ;
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
//4
if (imie != Ewa || wiek > 30 || wiek > 18 && plec != "m") ;

//tablice
int[] grades = new int[5];
string[] daysOfWeek = new string[7];
daysOfWeek[0] = "poniedziałek";
daysOfWeek[1] = "wtorek";
daysOfWeek[2] = "środa";
daysOfWeek[3] = "czwartek";
Console.WriteLine(daysOfWeek[2]);

//pętla
for (int i = 0; i < daysOfWeek.Length; i = i + 1)
{
    Console.WriteLine(daysOfWeek[i]);
}

//listy
List <string> Pool = new List <string> ();

// for each
foreach (var day in daysOfWeek) ;


