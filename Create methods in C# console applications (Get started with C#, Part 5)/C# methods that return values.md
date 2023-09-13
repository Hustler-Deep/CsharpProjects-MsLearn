# C# Methods that return values
## Understand return type syntax
```c#
double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}

for(int i=0; i<items.Length; i++) {
    total += GetDiscountedPrice(i);
}
if(TotalMeetsMinimum()) {
    total -= 5.00; 
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");
```
## Return numbers from methods
```c#
double usd = 23.73;
int vnd = UsdToVnd(usd);

int UsdToVnd(double usd) {
    int rate = 23500;
    return (int) (rate * usd);
}

double VndToUsd(int vnd) {
    double rate = 23500;
    return vnd / rate;
}

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");
```
## Return strings from methods
```c#
string input = "There are snakes at the zoo";

string ReverseWord(string word) {
    string result = "";
    for ( int i = word.Length - 1; i >= 0; i--) {
        result += word[i];
    }

    return result;
}

string ReverseSentence(string input) {
    string result = "";
    string[] words = input.Split(" ");

    foreach (string word in words) {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

```
## Return Booleans from methods
```c#

```










