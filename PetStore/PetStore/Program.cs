// See https://aka.ms/new-console-template for more information

using PetStore;
using System.Text.Json;

var productLogic = new ProductLogic();

string userInput = PrintMenu();

while (!userInput.Equals("exit", StringComparison.CurrentCultureIgnoreCase)) {
    if (userInput == "1") {
        Console.WriteLine("Adding a Dog Leash.");
        var dogLeash = new DogLeash();

        Console.Write($"Enter the Quantity: ");
        dogLeash.Quantity = int.Parse(Console.ReadLine());

        Console.Write("Enter the Name: ");
        dogLeash.Name = Console.ReadLine(); 

        Console.Write("Enter the Price: ");
        userInput = Console.ReadLine();
        dogLeash.Price = decimal.Parse(userInput);

        Console.Write("Enter the Description: ");
        dogLeash.Description = Console.ReadLine();

        Console.Write("Enter the length in inches: ");
        userInput = Console.ReadLine();
        dogLeash.LengthInches = int.Parse(userInput);

        Console.Write("Enter the meterial of the leash: ");
        dogLeash.Material = Console.ReadLine();

        productLogic.AddProduct(dogLeash);
        Console.WriteLine($"Added {dogLeash.Name} to inventory.");
    } 
    else if (userInput == "2") 
    {
        //TODO: prompt user for leash name, and get/print the leash
        Console.Write("Which leash would you like to see? ");
        userInput = Console.ReadLine();
        var leash = productLogic.GetDogLeashByName(userInput);
        Console.WriteLine(JsonSerializer.Serialize( leash ));
    }

    userInput = PrintMenu();
};

static string PrintMenu()
{
    Console.WriteLine("Press 1 to add a product.");
    Console.WriteLine("Press 2 to retrieve a specific dog leash.");
    Console.WriteLine("Type 'exit' to quit.");
    return Console.ReadLine();
}