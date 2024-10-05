// See https://aka.ms/new-console-template for more information

// rakendus küsib kasutaja sugu (m/f)
//rakendus küsib perekonnanime
// vastavalt vastustele, rakendus tervitab järgmiselt:
//"weclome, MR [kasutaja perekonnanimi] / "welcome, MS. [kasutaja perekonnanimi]"

Console.WriteLine("Plese select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist string formaadis

Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome Mr.{userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome Mrs.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userLastName}!");
}


//Console.WriteLine($"welcome, {userGender}");
