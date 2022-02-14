Console.Write("What is your current grade? ");
double grade = double.Parse(Console.ReadLine());
char letterGrade = 'F';

//if(grade <= 100 && grade >= 90)
if(grade >= 89.5)
{
    letterGrade = 'A';
}
else if(grade >= 79.5)
{
    letterGrade = 'B';
}
//....
else if(grade >= 69.5)
{
    letterGrade = 'C';
}
else if(grade >= 59.5)
{
    letterGrade = 'D';
}
//after if statement

System.Console.WriteLine(letterGrade);


System.Console.Write("What is your name? ");
string name = Console.ReadLine();

switch(name)
{
    case "Matt":
    case "matt":
        System.Console.WriteLine($"Hello {name}!");
        break;
    case "Jone":
        System.Console.WriteLine($"Hello {name}");
        break;
    default:
        System.Console.WriteLine("Hello whomever you are!");
        break;
}

if(name == "Matt" || name == "matt")
{
     System.Console.WriteLine($"Hello {name}!");
}
else if(name == "Jone")
{
     System.Console.WriteLine($"Hello {name}!");
}
else
{
    System.Console.WriteLine("Hello whomever you are!");
}