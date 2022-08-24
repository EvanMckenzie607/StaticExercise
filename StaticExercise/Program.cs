using StaticExercise;


Console.WriteLine("Hello whats the tempature in Fareneit outside?!");

var farenheitTemp = Double.Parse(Console.ReadLine());

Console.WriteLine("Lets convert that to Celsius!");


Console.WriteLine($"{farenheitTemp} " +
    $"degrees Ferenheit is " +
    $"{TempConverter.FahrenheitToCelsius(farenheitTemp)}" +
    $" degrees" +
    $" Celsius!");

Console.WriteLine("Now lets convert a tempature to celsius!\n" +
    "Please feed the console a number :)");

var celsiusTemp = Double.Parse(Console.ReadLine());

Console.WriteLine($"{celsiusTemp} degrees Celsius is " +
    $"{TempConverter.CelsiusToFarenheit(celsiusTemp)} " +
    $"degrees" +
    $"Farenheit!");



