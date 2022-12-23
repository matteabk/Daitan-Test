

//Allowing the user to choose the value of the cents to be selected and using a Parse to transform the input into an int type.
Console.WriteLine("Enter the value:");
var input = Console.ReadLine();
int value = int.Parse(input);

Array makeChangeTest(int total)
{
    //Creating a list to storage the solutions of the problem.
    List<string> responses = new List<string>();

    for (int quarters = 0; quarters * 25 <= total; ++quarters)
    {
        for (int dimes = 0; dimes * 10 <= total; ++dimes)
        {
            for (int nickels = 0; nickels * 5 <= total; ++nickels)
            {
                for (int pennies = 0; pennies * 1 <= total; ++pennies)
                {
                    int sum = quarters * 25 + dimes * 10 + nickels * 5 + pennies;
                    if (sum == total)
                    {
                        //Adding the solutions to the responses List.
                        responses.Add(($"{quarters}, {dimes}, {nickels}, {pennies}"));
                    }
                }

            }
        }
    }

    //Converting the list to an Array type.
    return responses.ToArray();
}

var array = makeChangeTest(value);

foreach (var item in array)
{
    //Displaying in the console screen all the responses that the makeChangeTest returned.
    Console.Write($"[{item}] ");
}

