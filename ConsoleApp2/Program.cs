
//1
Console.WriteLine("Please Enter Your Age");
int age = int.Parse(Console.ReadLine());
int year_of_brith = 2022 - age;
Console.WriteLine("Your Brith Year Is:" + year_of_brith);


//2
Console.WriteLine("Please Enter Your GPA");
float gpa = float.Parse(Console.ReadLine());
if (gpa <= 5 && gpa > 4)
{
    Console.WriteLine("Your Grade Is: A");
}
else if (gpa <= 4 && gpa > 3)
{
    Console.WriteLine("Your Grade Is: B");
}
else if(gpa <= 3 && gpa > 2)
{
    Console.WriteLine("Your Grade Is: C");    
}
else if(gpa <= 2 && gpa > 1)
{
    Console.WriteLine("Your Grade Is: D");
}
else
{
    Console.WriteLine("Your Grade Is: F");
}


//3
Console.WriteLine("Enter the first number ");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number ");
float num2 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter the operation ");
string oper = (Console.ReadLine());

switch (oper)
{
    case "add":
    case "+":
        float add = num1 + num2;
        Console.WriteLine($"The Result Is {add}");
        break;
    case "sub":
        float sub = num1 - num2;
        Console.WriteLine($"The Result Is {sub}");
        break;
    case "muli":
        float muli = num1 * num2;
        Console.WriteLine($"The Result Is {muli}");
        break;
    case "div":
        float div = num1 / num2;
        Console.WriteLine($"The Result Is {div}");
        break;
       
}

