/*
int hero = 10, monster = 10;

Random dice = new Random();
do {
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if(monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/

/*
// Code Project-1 - Write Code That validates integer input
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do {
    readResult = Console.ReadLine();
    if (readResult != null) {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);
    if(validNumber == true) {
        if(numValue <= 5 || numValue >= 10) {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    } else {
        Console.WriteLine($"Sorry, you entered an invalid number, please try again");
    }
} while( validNumber == false);

Console.WriteLine($"Your input ({numValue}) has been accepted.");
readResult = Console.ReadLine();
*/


// Code Project-2 - Write Code That validates string input
string? readResult;
string roleName = "";
bool validEntry = false;

do {
    Console.WriteLine("Enter your role name ( Administrator, Manager, or User )");
    readResult = Console.ReadLine();
    if(readResult != null) {
        roleName = readResult.Trim();
    }
    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") {
        validEntry = true;
    } else {
        Console.WriteLine($"Your role name that you entered, \"{roleName}\" is not valid. ");
    }
} while (validEntry == false);
Console.WriteLine($"Your input value ({roleName}) has been accepted.");


/*
// Code Project-3 - Write Code That achieves the project conditions
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringCount = myStrings.Length;

string myString  = "";
int periodLocation = 0;

for(int i = 0; i < stringCount; i++) {
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while(periodLocation != -1) {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
    mySentence =myString.Trim();
    Console.WriteLine(mySentence);
}    
*/