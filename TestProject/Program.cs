// int first = 5;


// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0;
decimal x = 0;

foreach (string str in values)
{
    if (decimal.TryParse(str, out x))
    {
        total += x;
    }

    else 
    {
        message += str;
    }
}

Console.WriteLine($"Total: {total}\nMessage: {message}");