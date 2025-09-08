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