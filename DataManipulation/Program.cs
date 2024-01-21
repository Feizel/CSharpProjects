/*
Suppose you are a software developer on a team assigned to work with a logistics company. 
They have many needs for gathering and organizing their business data. 
Projects vary from tracking and reporting inventory, 
enabling specific data to be passed to and from business partners, and identifying possible fraudulent orders. 
Each project is different, but all require the processing of data. 
In these projects the applications will be performing data operations such as to add, 
delete, sort, combine, calculate, validate and format output.
*/

string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// System.Console.WriteLine("\nReversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     System.Console.WriteLine($"-- {pallet}");
// }

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}