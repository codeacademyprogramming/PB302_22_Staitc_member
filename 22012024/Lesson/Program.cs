
using Lesson;

Human hmn2 = new Human { Fullname = "Cavid Abbasov" };
Human hmn3 = new Human { Fullname = "Nermine Abbasova" };
Human hmn1 = new Human { Fullname = "Hikmet Abbasov" };

Console.WriteLine(Calculator.Add(10,20));
Console.WriteLine(Calculator.Subtract(10, 20));




Console.WriteLine(hmn1.No);
Console.WriteLine(hmn2.No);
Console.WriteLine(hmn3.No);


Console.WriteLine(Product.TotalIncome);
Product.CheckName("Abbas");



Product prd1 = new Product() { Price = 10 };
Product prd2 = new Product() { Price = 20 };
Product prd3 = new Product() { Price = 30 };

prd1.Sell();
prd2.Sell();
prd2.Sell();
prd3.Sell();

//Console.WriteLine(prd1.TotalIncome);
//Console.WriteLine(prd2.TotalIncome);
//Console.WriteLine(prd3.TotalIncome);

Console.WriteLine(Product.TotalIncome);
string name;

do
{
    Console.WriteLine("name: ");
    name = Console.ReadLine();

} while (!Product.CheckName(name));


string priceStr;
double price;
do
{
    Console.WriteLine("price: ");
    priceStr = Console.ReadLine();
} while (!double.TryParse(priceStr, out price));

Product prd4 = new Product
{
    Name = name,
    Price = price
};

prd4.AddIngredient("Yumurta");








