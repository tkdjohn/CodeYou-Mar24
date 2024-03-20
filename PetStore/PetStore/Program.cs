// See https://aka.ms/new-console-template for more information

using PetStore;
using System.Text.Json;

string userInput;
Console.WriteLine("Press 1 to add a product.");
Console.WriteLine("Type 'exit' to quit.");
userInput = Console.ReadLine();

while (userInput.ToLower() != "exit") {
    if (userInput == "1") {
        Console.WriteLine("Adding a Dog Leash.");
        var dogLeash = new DogLeash
        {
            Name = "Dog Leash",
            Price = 24.95M,
            Description = "It's a leash. What more do you want to know?"
        };

        Console.Write($"How many {dogLeash.Name}s do you want? ");
        userInput = Console.ReadLine();
        dogLeash.Quantity = int.Parse(userInput);

        Console.Write("Enter the length in inches: ");
        userInput = Console.ReadLine();
        dogLeash.LengthInches = int.Parse(userInput);

        Console.Write("Enter the meterial of the leash: ");
        dogLeash.Material = Console.ReadLine();

        Console.WriteLine(JsonSerializer.Serialize(dogLeash));
    }

    Console.WriteLine("Press 1 to add a product.");
    Console.WriteLine("Type 'exit' to quit.");
    userInput = Console.ReadLine();
};
