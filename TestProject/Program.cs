// Code challenge: write code to display the result of a coin flip

// Random coin = new Random();
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

string? permission = Console.ReadLine();
int level = 20;

if(permission.Contains("Admin")) {
    if(level > 55) {
        Console.WriteLine("Welcome, Super Admin user.");
    } else {
        Console.WriteLine("Welcome, Admin user.");
    }
} else if(permission.Contains("Manager")) {
    if(level >= 20) {
        Console.WriteLine("Contact an admin for access.");
    } else {
        Console.WriteLine("You do not have sufficient privileges.");
    }
} else {
    Console.WriteLine("You do not have sufficient privileges.");
}