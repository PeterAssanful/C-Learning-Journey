string username = "Kwm;e";
int userAge = 30;
double accountBalance=124.56;
bool isPremiumUser=true;

Console.WriteLine($"Hello, {username}!");
Console.WriteLine($"Age: {userAge}");
Console.WriteLine($"Account Balance: ${accountBalance}");
Console.WriteLine($"Premium User: {isPremiumUser}");



string favoritFood="Fufu with Palm Nut Soup";
int numberOfSiblings= 9;

Console.WriteLine($"My favouritt food is {favoritFood}");
Console.WriteLine($"I have {numberOfSiblings} siblings.");

if (userAge > 18)
    { 
    
    Console.WriteLine("Access granted: You're an adult");
    
    }
else
{
    Console.WriteLine("Access Denied: You still mama's breast milk");
}

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"This is message number {i}");
}

for (int i = 1; i <= 12; i++)
{
    int result = 9 * i;

    Console.WriteLine($"9 x {i} = {result}");
}