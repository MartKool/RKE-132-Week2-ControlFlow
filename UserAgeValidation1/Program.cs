// rakendus küsib kasutaja vanust
//kui kasutaja vanus on väiksem kui 13 siis
//konsoolis kuvatakse you are too young to use instagram
// muul juhl
//konsoolis kuvatakse "welcome to instagram"

using System.ComponentModel.Design;

Console.WriteLine("enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to instagram!");
}
else //if(userAge <13) 
{
    Console.WriteLine("you are too young to use instagram");
}