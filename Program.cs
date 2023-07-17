Console.WriteLine(@"Please enter a product number: 
Products:");
List<Plant> plants = new List<Plant>()
{
    new Plant()
    {
        Name
        LightNeeds
        AskingPrice
        City
        ZIP
        Sold
    }
}
DateTime thisYear2023 - new DateTime(2023, 1, 1, 12, 0, 0);
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Football",
        Price = 24,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2008
    },
    new Product()
    {
        Name = "Soccer Ball",
        Price = 14,
        Sold = false,
        StockDate - new DateTime(2020, 9, 14),
        ManufactureYear = 2010
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 25,
        Sold = false,
        StockDate - new DateTime(2019, 4, 18),
        ManufactureYear = 2010
    },
    new Product()
    {
        Name = "Tennis Racket",
        Price = 19,
        Sold = false,
        StockDate - new DateTime(2020, 3, 14),
        ManufactureYear = 2020
    },
    new Product()
    {
        Name = "Basketball",
        Price = 40,
        Sold = false,
        StockDate - new DateTime(2023, 2, 14),
        ManufactureYear = 2022
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 5,
        Sold = false,
        StockDate - new DateTime(2023, 5, 22),
        ManufactureYear = 2020
    },
    new Product()
    {
        Name = "Volleyball",
        Price = 15,
        Sold = false,
        StockDate - new DateTime(2008, 6, 3),
        ManufactureYear = 1995
    }
};

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
};

int response = int.Parse(Console.ReadLine().Trim());

while (response < 1 || response > 7)
{
    Console.WriteLine("Please enter a valid number!");
    response = int.Parse(Console.ReadLine().Trim());
}

Product chosenProduct = products[response - 1];

DateTime now = DateTime.Now;
TimeSpan timeInStock = now - chosenProduct.StockDate;

Console.WriteLine(@$"You chose: {chosenProduct.Name}, 
which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old.
It {(chosenProduct.Sold? "Is not available." : $"has been in stock for {timeInStock.Days"});


