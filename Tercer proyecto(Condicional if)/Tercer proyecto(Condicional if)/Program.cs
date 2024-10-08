
/*
Console.WriteLine("Bob's Big Giveaway");
Console.WriteLine("Choose a door: 1, 2 or 3: ");
string userValue = Console.ReadLine();

if (userValue == "1")
{
    string message = "You won a new car!";
    Console.WriteLine(message);
}

else if (userValue == "2")
{
    string message = "You won a new boat!";
    Console.WriteLine(message);
}
else if (userValue == "3") {

    string message = "You won a new cat!";
    Console.WriteLine(message);
}
else
{
    string message = "Sorry, we didn't understand";
    Console.WriteLine(message);
}

Console.ReadLine();

*/

Console.WriteLine("Bob's Big Giveaway");
Console.Write("Choose a door: 1, 2 or 3: ");
string userValue = Console.ReadLine();

string message = (userValue == "1") ? "boat" : "strand of lint";

//Console Write("You won a ");
//Console Write(message);
//Console Write(".");


Console.WriteLine("You won a {0}.", message);


Console.ReadLine();

