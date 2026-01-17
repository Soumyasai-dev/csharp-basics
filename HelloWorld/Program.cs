Console.Write("Enter your name: "); 
string name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"Hello {name}, you are {age} years old.");

if(age<18)
{
    Console.WriteLine("You are a minor");
}
else
{
    Console.WriteLine("You are an adult");  
}