//Rakendus küsib kasutaja sugu (m/f) ja perekonnanime
//Lähtudes kasutaja sisestusest tervitab:
//"Welcome, Mr. [perekonnanimi]" / "Welcome, Ms. [perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());
//Console.ReadLine() loeb andmeid ainult string formaadis

Console.WriteLine("Please, enter your last name:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
//if mitu korda järjest kasutades kontrollib alati kõik versioonid üle
//else if puhul kui esimene sobib siis edasi ei kontrolli
//Väiksem koormus arvutile