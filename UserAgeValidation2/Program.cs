
//rakendus küsib kasutajalt sisestada tema vanuse
//kui kasutaja on noorem kui 13; siis konsoolis kuvatakse:
//"You are too young for this app"
//muul juhul kuvatakse "Welcome"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();
int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge,  out userAgeNum);


if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome");
    }
    else
    {
        Console.WriteLine("You are too young for this app");
    }
}
else
{
    Console.WriteLine("Could not read your age");

}
