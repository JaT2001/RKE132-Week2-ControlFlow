//Rakendus küsib kasutaja vanust
//Kui on noorem kui 13. aastane kuvab:
//"You are too young to use Instagram"
//Kui vanem kuvab:
//"Welcome to Instagram"


Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine());

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram.");
}