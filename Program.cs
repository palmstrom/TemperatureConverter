using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a degree to be converted");
            var temperature = Console.ReadLine();

            Console.WriteLine("Please select a number for the unit of temperature");
            Console.WriteLine("1. Farenheit \n 2. Celcius \n 3. Kelvin");
            var unit = Console.ReadLine();

            Console.WriteLine("Please select a number for the unit of temperature to be converted to");
            Console.WriteLine("1. Farenheit \n 2. Celcius \n 3. Kelvin");
            var unitConverted = Console.ReadLine();

            Console.WriteLine("The converted temperature is " + convertDegree(Convert.ToDouble(temperature), int.Parse(unit), int.Parse(unitConverted)));
            Console.ReadKey();

            /**
            * The following code converts from Farenheit to a different unit of measurement
            *
            */

            double farenheitToCelcius(double temperature)
            {
                return (temperature - 32) * 5 / 9;
            }

            double farenheitToKelvin(double temperature)
            {
                return ((temperature - 32) * 5 / 9) + 273.15;
            }

            /**
            * The following code converts from Celcius to a different unit of measurement
            *
            */

            double celciusToFarenheit(double temperature)
            {
                return (temperature * 9 / 5) + 32;
            }

            double celciusToKelvin(double temperature)
            {
                return temperature += 273.15;
            }

            /**
            * The following code converts from Kelvin to a different unit of measurement
            *
            */

            double kelvinToFarenheit(double temperature)
            {
                
                return ((temperature - 273.15) * 9 / 5) + 32;
            }

            double kelvinToCelcius(double temperature)
            {
                return temperature - 273.15;
            }

            double convertDegree(double temp, int u, int uc)
            {
                if (u == 1)
                {
                    if (uc == 1)
                    {
                        return temp;
                    }
                    else if (uc == 2)
                    {
                        return farenheitToCelcius(temp);
                    }
                    else if (uc == 3)
                    {
                        return farenheitToKelvin(temp);
                    }
                    else {
                        Console.WriteLine("Error converting");
                        return temp;
                    }
                }
                else if (u == 2)
                {
                    if (uc == 1)
                    {
                        return celciusToFarenheit(temp);
                    }
                    else if (uc == 2)
                    {
                        return temp;
                    }
                    else if (uc == 3)
                    {
                        return celciusToKelvin(temp);
                    } else {
                        Console.WriteLine("Error converting");
                        return temp;
                    }
                }
                else if (u == 3)
                {
                    if (uc == 1)
                    {
                        return kelvinToFarenheit(temp);
                    }
                    else if (uc == 2)
                    {
                        return kelvinToCelcius(temp);
                    }
                    else if (uc == 3)
                    {
                        return temp;
                    } else {
                        Console.WriteLine("Error converting");
                        return temp;
                    }
                }
                else
                {
                    Console.WriteLine("Error converting");
                    return temp;
                }
            }

        }
    }
}