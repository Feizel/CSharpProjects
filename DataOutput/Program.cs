//Currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//Measurement
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

decimal measurement2 = 123456.78912m;
Console.WriteLine($"Measurement: {measurement2:N4} units");

//Percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

//Example
decimal price2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);

yourDiscount += $"A discount of {((price2 - salePrice)/price2):P2}!"; //inserted
Console.WriteLine(yourDiscount);
