
//rakendus küsib kasutajalt valida tema sugu
//rakenus küsib kasutajalt perekonnanime
//lähtudes kasutaja valikust , rakendus tervitab teda järgmiselt
//"Welcome, Mr. (perekonnanimi)" /"Welcome, Ms.(perekonnanimi)"


Console.WriteLine("Please, select your gender (m/f)");
char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please, enter your  last name");
string userSurname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userSurname}!");
}

else  if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userSurname}!");
}

else
{
    Console.WriteLine($"Welcome, {userSurname}!");
}