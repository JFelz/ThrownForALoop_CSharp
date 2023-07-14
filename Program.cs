string greeting = @"Welcome to Bleuprint!
The #1 Digital Marketplace!";

Console.WriteLine(greeting);

Console.WriteLine("Enter Your Product!");

string response = Console.ReadLine().Trim();

while (string.IsNullOrWhiteSpace(response))
{
    Console.WriteLine("Try Again! Please Enter A Response!");
    response = Console.ReadLine().Trim();
}
    Console.WriteLine($"You chose: {response}");