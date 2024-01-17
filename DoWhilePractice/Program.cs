/*
Code project 1 - write code that validates integer input
Your solution must include either a do-while or while iteration.
Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Inside the iteration block:
Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

string? userInput;
string valueEntered = "";
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10:");

do
{
    userInput = System.Console.ReadLine();

    if (userInput != null)
    {
        valueEntered = userInput;
    }

    validNumber = int.TryParse(valueEntered, out numericValue);

    if (validNumber == true)
    {
        if (numericValue <= 5 || numericValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        }
        else
        {
            System.Console.WriteLine("You entered an invalid number. Please try again!");
        }

    }

} while (validNumber == false);

Console.WriteLine($"Your input value ({numericValue}) has been accepted.");

userInput = Console.ReadLine();


/*
Code project 2 - write code that validates string input
Your solution must include either a do-while or while iteration.
Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.
Inside the iteration block:
Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();


/*
Code project 3 - Write code that processes the contents of a string array
Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.
Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.
In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.
Your solution must include an inner do-while or while loop that can be used to process the myString variable.
In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
In the inner loop, your solution must not display the period character.
In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
