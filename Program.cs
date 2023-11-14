

int numb;
Console.WriteLine("Please enter a number: ");
string input=Console.ReadLine();
bool is_parsed=Int32.TryParse(input, out numb);
if (is_parsed)
{
    Console.WriteLine($"The square of this number is {Math.Pow(numb, 2)}");
}
else { 
    Console.WriteLine("Invalid input!!!!!");
}