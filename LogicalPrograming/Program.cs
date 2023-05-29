using System;

class Util
{
    public static void temperatureConversion(double temperature, string fromUnit)
    {
        double convertedTemperature;
        string toUnit;

        if (fromUnit.ToLower() == "celsius")
        {
            convertedTemperature = (temperature * 9 / 5) + 32;
            toUnit = "Fahrenheit";
        }
        else if (fromUnit.ToLower() == "fahrenheit")
        {
            convertedTemperature = (temperature - 32) * 5 / 9;
            toUnit = "Celsius";
        }
        else
        {
            Console.WriteLine("Invalid temperature unit. Please specify either Celsius or Fahrenheit.");
            return;
        }

        Console.WriteLine($"{temperature} {fromUnit} is equivalent to {convertedTemperature} {toUnit}.");
    }

    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Invalid number of arguments. Please provide temperature and unit (Celsius or Fahrenheit) as command-line arguments.");
            return;
        }

        double temperature = Convert.ToDouble(args[0]);
        string fromUnit = args[1];

        temperatureConversion(temperature, fromUnit);
    }
}