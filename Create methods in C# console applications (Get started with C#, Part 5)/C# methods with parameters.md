## Test the method scope
Statements declared outside of any code block are called top-level statements. Variables declared in top-level statements are called 'global variables'. Global variables aren't restricted to any scope, and can be used anywhere throughout the program. Global variables can be useful for different methods that need to access the same data. However, it's important to pay attention to variable names in different scopes.
## Example 1
```c#
string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});
```
## Example 2
```c#
double pi = 3.14159;
void PrintCircleArea(int radius) {

    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius) {

    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleInfo(int radius) {

    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
    Console.WriteLine();
}

PrintCircleInfo(12);
PrintCircleInfo(24);
```
## Test pass by value
```c#
int a = 3;
int b = 4;
int c = 0;

void Multiply(int a, int b, int c)  {
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");
```
## Test pass by reference
```c#
int[] array = {1, 2, 3, 4, 5};

void PrintArray(int[] array) {
    foreach (int a in array) {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = 0;
    }
}

PrintArray(array);
Clear(array);
PrintArray(array);
```
## Test with strings
strings are an immutable type. Even though a string is a reference value type, unlike an array, its value can't be altered once it's assigned. You might have noticed this if you've used methods such as string.Replace or string.ToUpper
```c#
string status = "Healthy";

void SetHealth(string status, bool isHealthy) {
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}

Console.WriteLine($"Start: {status}");
SetHealth(status, false);
Console.WriteLine($"End: {status}");
```

## Exercise - Create an RSVP application
you'll create a brief application for guests to RSVP to an event. The guests will provide their party size and any allergies. You'll also add the option to restrict RSVPs to an invite-only guest list.
```c#
string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

void RSVP(string name, int partySize=1, string allergies = "none", bool inviteOnly = true) 
{
    if (inviteOnly)
    {
        // search guestList before adding rsvp
        bool found = false;
        foreach (string guest in guestList) {
            if ( guest.Equals(name) ) {
                found = true;
                break;
            }
        }
        if( !found ) {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Jony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();
```
## Challenge to display email addresses
Your challenge is to create a method that displays the correct email address for both internal and external employees. You're given lists of internal and external employee names. An employee's email address consists of their username and company domain name.

The username format is the first two characters of the employee first name, followed by their last name. For example, an employee named "Robert Bavin" would have the username "robavin". The domain for internal employees is "contoso.com".
```c#
using System.Runtime.ExceptionServices;

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

void DisplayEmail(string first, string last, string domain = "contoso.com") {
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
}
```
