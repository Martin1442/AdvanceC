using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var Country = new Dictionary<string, string>()
            {
                { "Macedonia", "Skopje" },
                { "Bulgaria", "Sofia" },
                { "Serbia", "Belgrade" },
                { "Albania", "Tirana" },
                { "Grece", "Atina" }
            };


            do
            {
                Console.WriteLine("To find country capitals town type 1 / Or to add country and capitals town type 2 ");
                int input;
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter number 1 or 2");
                    continue;
                }

                try
                {
                    if (input == 1)
                    {
                        Console.WriteLine("Enter country to find the capitals city:");
                        var capitals = Console.ReadLine();
                        
                        if (Country.ContainsKey(capitals))
                        {
                            Console.WriteLine($"{capitals} capital city is {Country[capitals]}");
                        }
                        else Console.WriteLine("I cant find that country");
                        continue;
                    }
                    else if (input == 2)
                    {
                        try
                        {
                            Console.WriteLine("Add country name");
                            string countryName = Console.ReadLine();

                            Console.WriteLine("Add country capitals city name");
                            string capitalsCity = Console.ReadLine();

                            Country.Add(countryName, capitalsCity);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("You cant add country that already exists");
                            foreach (var item in Country)
                            {
                                Console.WriteLine($"Country: {item.Key}  /  City: {item.Value}");
                            }
                        }
                        continue;
                    }
                }
                catch (SystemException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            } while (true);


        }
    }
}
