//bool tOrF = true;
//false

//1 == 1 //true
//2 != 3 //true
//2 != 2 //false
//2 > 3 //false
//2 < 3 //true
//3 >= 3 //true
//2 <= 3 //true


Console.Write("Is it cold outside? (yes / no) "); 

//Yes, yEs, YES, yES, yeS, YeS, YEs, yes
//yes 

//y

string answer = Console.ReadLine().ToLower();

if(answer != "yes" && answer != "no")
{
    System.Console.WriteLine("Come on, follow the instructions!");
    Console.Write("Is it cold outside? (yes / no) "); 
    answer = Console.ReadLine().ToLower();
}

if(answer == "yes")
{
    System.Console.WriteLine("Wear a jacket!");
    System.Console.WriteLine("...mood change...");
    System.Console.WriteLine("Pull it together and get in the car!");
    Console.Write("Is it at least sunny? ");
    string newChoice = Console.ReadLine().ToUpper();
    if(newChoice == "YES")
    {
        System.Console.WriteLine("Maybe it will warm up! :D");
    }
    
}
else
{
    System.Console.WriteLine("I guess it is warm outside!");
    System.Console.WriteLine("+10 mood, and run outside with wings!!!");
}

System.Console.WriteLine("Have a nice day.");